-- =============================================
-- Script: Setup hoàn chỉnh Play History
-- Tạo bảng + Tất cả stored procedures
-- =============================================

USE MusicLibraryDB;
GO

PRINT '';
PRINT '╔════════════════════════════════════════════════════════╗';
PRINT '║     SETUP HOÀN CHỈNH PLAY HISTORY FEATURE            ║';
PRINT '╚════════════════════════════════════════════════════════╝';
PRINT '';

-- =============================================
-- BƯỚC 1: TẠO BẢNG PLAYHISTORY
-- =============================================
PRINT '===== BƯỚC 1: TẠO BẢNG PLAYHISTORY =====';
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PlayHistory]') AND type in (N'U'))
BEGIN
    DROP TABLE PlayHistory;
    PRINT '✅ Đã xóa bảng PlayHistory cũ';
END
GO

CREATE TABLE PlayHistory (
    HistoryID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    SongID INT NOT NULL,
    PlayedDate DATETIME NOT NULL DEFAULT GETDATE(),
    PlayDuration INT NULL,
    DeviceName NVARCHAR(100) NULL,
    
    CONSTRAINT FK_PlayHistory_Users FOREIGN KEY (UserID) 
        REFERENCES Users(UserID) ON DELETE CASCADE,
    CONSTRAINT FK_PlayHistory_Songs FOREIGN KEY (SongID) 
        REFERENCES Songs(SongID) ON DELETE NO ACTION
);
PRINT '✅ Đã tạo bảng PlayHistory';
GO

CREATE INDEX IX_PlayHistory_UserID_PlayedDate ON PlayHistory(UserID, PlayedDate DESC);
PRINT '✅ Đã tạo index IX_PlayHistory_UserID_PlayedDate';
GO

CREATE INDEX IX_PlayHistory_SongID ON PlayHistory(SongID);
PRINT '✅ Đã tạo index IX_PlayHistory_SongID';
GO

-- =============================================
-- BƯỚC 2: TẠO STORED PROCEDURES
-- =============================================
PRINT '';
PRINT '===== BƯỚC 2: TẠO STORED PROCEDURES =====';
GO

-- =============================================
-- sp_AddPlayHistory
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'sp_AddPlayHistory') AND type in (N'P'))
    DROP PROCEDURE sp_AddPlayHistory;
GO

CREATE PROCEDURE sp_AddPlayHistory
    @UserID INT,
    @SongID INT,
    @PlayDuration INT = NULL,
    @DeviceName NVARCHAR(100) = NULL
AS
BEGIN
    INSERT INTO PlayHistory (UserID, SongID, PlayedDate, PlayDuration, DeviceName)
    VALUES (@UserID, @SongID, GETDATE(), @PlayDuration, @DeviceName);
    
    SELECT SCOPE_IDENTITY() AS HistoryID;
END;
GO
PRINT '✅ sp_AddPlayHistory';

-- =============================================
-- sp_GetRecentlyPlayed
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'sp_GetRecentlyPlayed') AND type in (N'P'))
    DROP PROCEDURE sp_GetRecentlyPlayed;
GO

CREATE PROCEDURE sp_GetRecentlyPlayed
    @UserID INT,
    @TopN INT = 50
AS
BEGIN
    SELECT TOP (@TopN)
        h.HistoryID,
        h.UserID,
        h.SongID,
        s.SongTitle,
        s.ArtistID,
        a.ArtistName,
        s.GenreID,
        g.GenreName,
        s.Duration,
        s.FilePath,
        h.PlayedDate,
        h.PlayDuration,
        h.DeviceName
    FROM PlayHistory h
    INNER JOIN Songs s ON h.SongID = s.SongID
    LEFT JOIN Artists a ON s.ArtistID = a.ArtistID
    LEFT JOIN Genres g ON s.GenreID = g.GenreID
    WHERE h.UserID = @UserID
    ORDER BY h.PlayedDate DESC;
END;
GO
PRINT '✅ sp_GetRecentlyPlayed';

-- =============================================
-- sp_GetMostPlayedSongs
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'sp_GetMostPlayedSongs') AND type in (N'P'))
    DROP PROCEDURE sp_GetMostPlayedSongs;
GO

CREATE PROCEDURE sp_GetMostPlayedSongs
    @UserID INT,
    @TopN INT = 20
AS
BEGIN
    SELECT TOP (@TopN)
        s.SongID,
        s.SongTitle,
        a.ArtistName,
        g.GenreName,
        COUNT(h.HistoryID) AS PlayCount,
        MAX(h.PlayedDate) AS LastPlayed
    FROM PlayHistory h
    INNER JOIN Songs s ON h.SongID = s.SongID
    LEFT JOIN Artists a ON s.ArtistID = a.ArtistID
    LEFT JOIN Genres g ON s.GenreID = g.GenreID
    WHERE h.UserID = @UserID
    GROUP BY s.SongID, s.SongTitle, a.ArtistName, g.GenreName
    ORDER BY PlayCount DESC;
END;
GO
PRINT '✅ sp_GetMostPlayedSongs';

-- =============================================
-- sp_GetPlayHistoryByDate
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'sp_GetPlayHistoryByDate') AND type in (N'P'))
    DROP PROCEDURE sp_GetPlayHistoryByDate;
GO

CREATE PROCEDURE sp_GetPlayHistoryByDate
    @UserID INT,
    @FromDate DATETIME,
    @ToDate DATETIME
AS
BEGIN
    SELECT 
        h.HistoryID,
        h.UserID,
        h.SongID,
        s.SongTitle,
        a.ArtistName,
        g.GenreName,
        h.PlayedDate,
        h.PlayDuration,
        h.DeviceName,
        s.FilePath,
        s.Duration
    FROM PlayHistory h
    INNER JOIN Songs s ON h.SongID = s.SongID
    LEFT JOIN Artists a ON s.ArtistID = a.ArtistID
    LEFT JOIN Genres g ON s.GenreID = g.GenreID
    WHERE h.UserID = @UserID
      AND h.PlayedDate BETWEEN @FromDate AND @ToDate
    ORDER BY h.PlayedDate DESC;
END;
GO
PRINT '✅ sp_GetPlayHistoryByDate';

-- =============================================
-- sp_ClearPlayHistory
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'sp_ClearPlayHistory') AND type in (N'P'))
    DROP PROCEDURE sp_ClearPlayHistory;
GO

CREATE PROCEDURE sp_ClearPlayHistory
    @UserID INT,
    @OlderThanDays INT = NULL
AS
BEGIN
    IF @OlderThanDays IS NULL
    BEGIN
        -- Xóa tất cả
        DELETE FROM PlayHistory WHERE UserID = @UserID;
    END
    ELSE
    BEGIN
        -- Xóa cũ hơn X ngày
        DELETE FROM PlayHistory 
        WHERE UserID = @UserID 
          AND PlayedDate < DATEADD(DAY, -@OlderThanDays, GETDATE());
    END
END;
GO
PRINT '✅ sp_ClearPlayHistory';

-- =============================================
-- sp_DeleteHistoryItem
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'sp_DeleteHistoryItem') AND type in (N'P'))
    DROP PROCEDURE sp_DeleteHistoryItem;
GO

CREATE PROCEDURE sp_DeleteHistoryItem
    @HistoryID INT,
    @UserID INT
AS
BEGIN
    DELETE FROM PlayHistory 
    WHERE HistoryID = @HistoryID 
      AND UserID = @UserID;
END;
GO
PRINT '✅ sp_DeleteHistoryItem';

-- =============================================
-- sp_GetListeningStats
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'sp_GetListeningStats') AND type in (N'P'))
    DROP PROCEDURE sp_GetListeningStats;
GO

CREATE PROCEDURE sp_GetListeningStats
    @UserID INT
AS
BEGIN
    SELECT 
        COUNT(*) AS TotalPlays,
        COUNT(DISTINCT SongID) AS UniqueSongs,
        COUNT(DISTINCT CAST(PlayedDate AS DATE)) AS DaysWithActivity,
        MIN(PlayedDate) AS FirstPlay,
        MAX(PlayedDate) AS LastPlay,
        (SELECT COUNT(*) FROM PlayHistory 
         WHERE UserID = @UserID 
           AND PlayedDate >= DATEADD(DAY, -7, GETDATE())) AS PlaysLast7Days,
        (SELECT COUNT(*) FROM PlayHistory 
         WHERE UserID = @UserID 
           AND PlayedDate >= DATEADD(DAY, -30, GETDATE())) AS PlaysLast30Days
    FROM PlayHistory
    WHERE UserID = @UserID;
END;
GO
PRINT '✅ sp_GetListeningStats';

-- =============================================
-- HOÀN TẤT
-- =============================================
PRINT '';
PRINT '╔════════════════════════════════════════════════════════╗';
PRINT '║               HOÀN TẤT SETUP!                         ║';
PRINT '╚════════════════════════════════════════════════════════╝';
PRINT '';
PRINT '✅ Bảng PlayHistory đã được tạo';
PRINT '✅ 7 Stored Procedures đã được tạo:';
PRINT '   1. sp_AddPlayHistory';
PRINT '   2. sp_GetRecentlyPlayed';
PRINT '   3. sp_GetMostPlayedSongs';
PRINT '   4. sp_GetPlayHistoryByDate';
PRINT '   5. sp_ClearPlayHistory';
PRINT '   6. sp_DeleteHistoryItem';
PRINT '   7. sp_GetListeningStats';
PRINT '';
PRINT '🎯 Bạn có thể Build và chạy app ngay bây giờ!';
PRINT '';
GO

