-- ============================================
-- Script: Create MusicLibraryDB Database
-- Description: Database cho ứng dụng Music Library Manager
-- ============================================

USE master;
GO

-- Drop database nếu đã tồn tại
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'MusicLibraryDB')
BEGIN
    ALTER DATABASE MusicLibraryDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE MusicLibraryDB;
END
GO

-- Tạo database mới
CREATE DATABASE MusicLibraryDB;
GO

USE MusicLibraryDB;
GO

-- ============================================
-- 1. Bảng Artists (Ca sĩ)
-- ============================================
CREATE TABLE Artists (
    ArtistID INT PRIMARY KEY IDENTITY(1,1),
    ArtistName NVARCHAR(200) NOT NULL UNIQUE,
    Biography NVARCHAR(MAX),
    Country NVARCHAR(100),
    ImagePath NVARCHAR(500),
    CreatedDate DATETIME DEFAULT GETDATE(),
    UpdatedDate DATETIME DEFAULT GETDATE()
);
GO

-- ============================================
-- 2. Bảng Genres (Thể loại)
-- ============================================
CREATE TABLE Genres (
    GenreID INT PRIMARY KEY IDENTITY(1,1),
    GenreName NVARCHAR(100) NOT NULL UNIQUE,
    Description NVARCHAR(500),
    CreatedDate DATETIME DEFAULT GETDATE()
);
GO

-- ============================================
-- 3. Bảng Albums (Album)
-- ============================================
CREATE TABLE Albums (
    AlbumID INT PRIMARY KEY IDENTITY(1,1),
    AlbumName NVARCHAR(300) NOT NULL,
    ArtistID INT,
    ReleaseYear INT,
    CoverImagePath NVARCHAR(500),
    Description NVARCHAR(MAX),
    CreatedDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ArtistID) REFERENCES Artists(ArtistID) ON DELETE SET NULL
);
GO

-- ============================================
-- 4. Bảng Songs (Bài hát) - Bảng chính
-- ============================================
CREATE TABLE Songs (
    SongID INT PRIMARY KEY IDENTITY(1,1),
    SongTitle NVARCHAR(300) NOT NULL,
    ArtistID INT,
    AlbumID INT,
    GenreID INT,
    Duration INT, -- Đơn vị: giây
    FilePath NVARCHAR(500) NOT NULL,
    ReleaseYear INT,
    Lyrics NVARCHAR(MAX),
    PlayCount INT DEFAULT 0,
    IsFavorite BIT DEFAULT 0,
    Rating INT CHECK (Rating >= 0 AND Rating <= 5),
    FileSize BIGINT, -- Đơn vị: bytes
    BitRate INT, -- Đơn vị: kbps
    CreatedDate DATETIME DEFAULT GETDATE(),
    LastPlayedDate DATETIME,
    FOREIGN KEY (ArtistID) REFERENCES Artists(ArtistID) ON DELETE SET NULL,
    FOREIGN KEY (AlbumID) REFERENCES Albums(AlbumID) ON DELETE SET NULL,
    FOREIGN KEY (GenreID) REFERENCES Genres(GenreID) ON DELETE SET NULL
);
GO

-- ============================================
-- 5. Bảng Playlists (Danh sách phát)
-- ============================================
CREATE TABLE Playlists (
    PlaylistID INT PRIMARY KEY IDENTITY(1,1),
    PlaylistName NVARCHAR(200) NOT NULL,
    Description NVARCHAR(500),
    CoverImagePath NVARCHAR(500),
    IsPublic BIT DEFAULT 0,
    CreatedDate DATETIME DEFAULT GETDATE(),
    UpdatedDate DATETIME DEFAULT GETDATE()
);
GO

-- ============================================
-- 6. Bảng PlaylistSongs (Quan hệ Playlist - Song)
-- ============================================
CREATE TABLE PlaylistSongs (
    PlaylistSongID INT PRIMARY KEY IDENTITY(1,1),
    PlaylistID INT NOT NULL,
    SongID INT NOT NULL,
    OrderIndex INT, -- Thứ tự bài hát trong playlist
    AddedDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (PlaylistID) REFERENCES Playlists(PlaylistID) ON DELETE CASCADE,
    FOREIGN KEY (SongID) REFERENCES Songs(SongID) ON DELETE CASCADE,
    UNIQUE(PlaylistID, SongID) -- Không cho phép duplicate trong cùng playlist
);
GO

-- ============================================
-- 7. Bảng Settings (Cấu hình ứng dụng)
-- ============================================
CREATE TABLE Settings (
    SettingID INT PRIMARY KEY IDENTITY(1,1),
    SettingKey NVARCHAR(100) NOT NULL UNIQUE,
    SettingValue NVARCHAR(500),
    Description NVARCHAR(300),
    UpdatedDate DATETIME DEFAULT GETDATE()
);
GO

-- ============================================
-- Insert dữ liệu mẫu cho Genres
-- ============================================
INSERT INTO Genres (GenreName, Description) VALUES
(N'Pop', N'Nhạc Pop đại chúng'),
(N'Rock', N'Nhạc Rock'),
(N'Ballad', N'Nhạc Ballad trữ tình'),
(N'EDM', N'Electronic Dance Music'),
(N'Hip Hop', N'Nhạc Hip Hop và Rap'),
(N'Jazz', N'Nhạc Jazz'),
(N'Classical', N'Nhạc cổ điển'),
(N'Bolero', N'Nhạc Bolero'),
(N'Indie', N'Nhạc Indie'),
(N'R&B', N'Rhythm and Blues'),
(N'Country', N'Nhạc Country'),
(N'Acoustic', N'Nhạc Acoustic');
GO

-- ============================================
-- Insert dữ liệu mẫu cho Artists
-- ============================================
INSERT INTO Artists (ArtistName, Country, Biography) VALUES
(N'Sơn Tùng M-TP', N'Việt Nam', N'Ca sĩ, nhạc sĩ và rapper người Việt Nam'),
(N'Mỹ Tâm', N'Việt Nam', N'Nữ ca sĩ hàng đầu Việt Nam'),
(N'Đen Vâu', N'Việt Nam', N'Rapper nổi tiếng Việt Nam'),
(N'Hòa Minzy', N'Việt Nam', N'Ca sĩ trẻ tài năng'),
(N'BLACKPINK', N'Hàn Quốc', N'Nhóm nhạc nữ K-Pop'),
(N'BTS', N'Hàn Quốc', N'Nhóm nhạc nam K-Pop nổi tiếng thế giới'),
(N'Taylor Swift', N'Mỹ', N'Ca sĩ, nhạc sĩ người Mỹ'),
(N'Ed Sheeran', N'Anh', N'Ca sĩ và nhạc sĩ người Anh');
GO

-- ============================================
-- Insert dữ liệu Settings mặc định
-- ============================================
INSERT INTO Settings (SettingKey, SettingValue, Description) VALUES
(N'Theme', N'Light', N'Chế độ giao diện: Light hoặc Dark'),
(N'Volume', N'50', N'Âm lượng mặc định (0-100)'),
(N'RepeatMode', N'None', N'Chế độ lặp: None, One, All'),
(N'ShuffleMode', N'False', N'Chế độ phát ngẫu nhiên'),
(N'DefaultMusicFolder', N'', N'Thư mục nhạc mặc định'),
(N'AutoPlayOnStartup', N'False', N'Tự động phát khi khởi động');
GO

-- ============================================
-- Tạo Index để tối ưu performance
-- ============================================
CREATE INDEX IX_Songs_Title ON Songs(SongTitle);
CREATE INDEX IX_Songs_Artist ON Songs(ArtistID);
CREATE INDEX IX_Songs_Genre ON Songs(GenreID);
CREATE INDEX IX_Songs_Favorite ON Songs(IsFavorite);
CREATE INDEX IX_PlaylistSongs_Playlist ON PlaylistSongs(PlaylistID);
CREATE INDEX IX_PlaylistSongs_Song ON PlaylistSongs(SongID);
GO

-- ============================================
-- STORED PROCEDURES
-- ============================================

-- SP: Thêm bài hát mới
CREATE PROCEDURE sp_AddSong
    @SongTitle NVARCHAR(300),
    @ArtistID INT = NULL,
    @AlbumID INT = NULL,
    @GenreID INT = NULL,
    @Duration INT = NULL,
    @FilePath NVARCHAR(500),
    @ReleaseYear INT = NULL,
    @Lyrics NVARCHAR(MAX) = NULL,
    @FileSize BIGINT = NULL,
    @BitRate INT = NULL
AS
BEGIN
    INSERT INTO Songs (SongTitle, ArtistID, AlbumID, GenreID, Duration, FilePath, 
                       ReleaseYear, Lyrics, FileSize, BitRate)
    VALUES (@SongTitle, @ArtistID, @AlbumID, @GenreID, @Duration, @FilePath,
            @ReleaseYear, @Lyrics, @FileSize, @BitRate);
    
    SELECT SCOPE_IDENTITY() AS NewSongID;
END
GO

-- SP: Cập nhật bài hát
CREATE PROCEDURE sp_UpdateSong
    @SongID INT,
    @SongTitle NVARCHAR(300),
    @ArtistID INT = NULL,
    @AlbumID INT = NULL,
    @GenreID INT = NULL,
    @Duration INT = NULL,
    @ReleaseYear INT = NULL,
    @Lyrics NVARCHAR(MAX) = NULL,
    @Rating INT = NULL
AS
BEGIN
    UPDATE Songs
    SET SongTitle = @SongTitle,
        ArtistID = @ArtistID,
        AlbumID = @AlbumID,
        GenreID = @GenreID,
        Duration = @Duration,
        ReleaseYear = @ReleaseYear,
        Lyrics = @Lyrics,
        Rating = @Rating
    WHERE SongID = @SongID;
END
GO

-- SP: Xóa bài hát
CREATE PROCEDURE sp_DeleteSong
    @SongID INT
AS
BEGIN
    DELETE FROM Songs WHERE SongID = @SongID;
END
GO

-- SP: Lấy tất cả bài hát với thông tin đầy đủ
CREATE PROCEDURE sp_GetAllSongs
AS
BEGIN
    SELECT 
        s.SongID,
        s.SongTitle,
        a.ArtistName,
        al.AlbumName,
        g.GenreName,
        s.Duration,
        s.FilePath,
        s.ReleaseYear,
        s.PlayCount,
        s.IsFavorite,
        s.Rating,
        s.LastPlayedDate,
        s.CreatedDate
    FROM Songs s
    LEFT JOIN Artists a ON s.ArtistID = a.ArtistID
    LEFT JOIN Albums al ON s.AlbumID = al.AlbumID
    LEFT JOIN Genres g ON s.GenreID = g.GenreID
    ORDER BY s.CreatedDate DESC;
END
GO

-- SP: Tìm kiếm bài hát
CREATE PROCEDURE sp_SearchSongs
    @SearchTerm NVARCHAR(300)
AS
BEGIN
    SELECT 
        s.SongID,
        s.SongTitle,
        a.ArtistName,
        al.AlbumName,
        g.GenreName,
        s.Duration,
        s.FilePath,
        s.ReleaseYear,
        s.PlayCount,
        s.IsFavorite,
        s.Rating
    FROM Songs s
    LEFT JOIN Artists a ON s.ArtistID = a.ArtistID
    LEFT JOIN Albums al ON s.AlbumID = al.AlbumID
    LEFT JOIN Genres g ON s.GenreID = g.GenreID
    WHERE s.SongTitle LIKE N'%' + @SearchTerm + '%'
       OR a.ArtistName LIKE N'%' + @SearchTerm + '%'
       OR al.AlbumName LIKE N'%' + @SearchTerm + '%'
    ORDER BY s.SongTitle;
END
GO

-- SP: Cập nhật số lần phát
CREATE PROCEDURE sp_UpdatePlayCount
    @SongID INT
AS
BEGIN
    UPDATE Songs
    SET PlayCount = PlayCount + 1,
        LastPlayedDate = GETDATE()
    WHERE SongID = @SongID;
END
GO

-- SP: Toggle yêu thích
CREATE PROCEDURE sp_ToggleFavorite
    @SongID INT
AS
BEGIN
    UPDATE Songs
    SET IsFavorite = CASE WHEN IsFavorite = 1 THEN 0 ELSE 1 END
    WHERE SongID = @SongID;
END
GO

-- SP: Thêm ca sĩ
CREATE PROCEDURE sp_AddArtist
    @ArtistName NVARCHAR(200),
    @Biography NVARCHAR(MAX) = NULL,
    @Country NVARCHAR(100) = NULL,
    @ImagePath NVARCHAR(500) = NULL
AS
BEGIN
    INSERT INTO Artists (ArtistName, Biography, Country, ImagePath)
    VALUES (@ArtistName, @Biography, @Country, @ImagePath);
    
    SELECT SCOPE_IDENTITY() AS NewArtistID;
END
GO

-- SP: Lấy tất cả ca sĩ
CREATE PROCEDURE sp_GetAllArtists
AS
BEGIN
    SELECT * FROM Artists ORDER BY ArtistName;
END
GO

-- SP: Thêm thể loại
CREATE PROCEDURE sp_AddGenre
    @GenreName NVARCHAR(100),
    @Description NVARCHAR(500) = NULL
AS
BEGIN
    INSERT INTO Genres (GenreName, Description)
    VALUES (@GenreName, @Description);
    
    SELECT SCOPE_IDENTITY() AS NewGenreID;
END
GO

-- SP: Lấy tất cả thể loại
CREATE PROCEDURE sp_GetAllGenres
AS
BEGIN
    SELECT * FROM Genres ORDER BY GenreName;
END
GO

-- SP: Tạo playlist mới
CREATE PROCEDURE sp_CreatePlaylist
    @PlaylistName NVARCHAR(200),
    @Description NVARCHAR(500) = NULL,
    @CoverImagePath NVARCHAR(500) = NULL
AS
BEGIN
    INSERT INTO Playlists (PlaylistName, Description, CoverImagePath)
    VALUES (@PlaylistName, @Description, @CoverImagePath);
    
    SELECT SCOPE_IDENTITY() AS NewPlaylistID;
END
GO

-- SP: Thêm bài hát vào playlist
CREATE PROCEDURE sp_AddSongToPlaylist
    @PlaylistID INT,
    @SongID INT
AS
BEGIN
    DECLARE @MaxOrder INT;
    SELECT @MaxOrder = ISNULL(MAX(OrderIndex), 0) FROM PlaylistSongs WHERE PlaylistID = @PlaylistID;
    
    INSERT INTO PlaylistSongs (PlaylistID, SongID, OrderIndex)
    VALUES (@PlaylistID, @SongID, @MaxOrder + 1);
    
    UPDATE Playlists SET UpdatedDate = GETDATE() WHERE PlaylistID = @PlaylistID;
END
GO

-- SP: Xóa bài hát khỏi playlist
CREATE PROCEDURE sp_RemoveSongFromPlaylist
    @PlaylistID INT,
    @SongID INT
AS
BEGIN
    DELETE FROM PlaylistSongs 
    WHERE PlaylistID = @PlaylistID AND SongID = @SongID;
    
    UPDATE Playlists SET UpdatedDate = GETDATE() WHERE PlaylistID = @PlaylistID;
END
GO

-- SP: Lấy tất cả playlist
CREATE PROCEDURE sp_GetAllPlaylists
AS
BEGIN
    SELECT 
        p.PlaylistID,
        p.PlaylistName,
        p.Description,
        p.CoverImagePath,
        p.CreatedDate,
        p.UpdatedDate,
        COUNT(ps.SongID) AS SongCount
    FROM Playlists p
    LEFT JOIN PlaylistSongs ps ON p.PlaylistID = ps.PlaylistID
    GROUP BY p.PlaylistID, p.PlaylistName, p.Description, p.CoverImagePath, 
             p.CreatedDate, p.UpdatedDate
    ORDER BY p.CreatedDate DESC;
END
GO

-- SP: Lấy các bài hát trong playlist
CREATE PROCEDURE sp_GetPlaylistSongs
    @PlaylistID INT
AS
BEGIN
    SELECT 
        s.SongID,
        s.SongTitle,
        a.ArtistName,
        al.AlbumName,
        g.GenreName,
        s.Duration,
        s.FilePath,
        ps.OrderIndex,
        ps.AddedDate
    FROM PlaylistSongs ps
    INNER JOIN Songs s ON ps.SongID = s.SongID
    LEFT JOIN Artists a ON s.ArtistID = a.ArtistID
    LEFT JOIN Albums al ON s.AlbumID = al.AlbumID
    LEFT JOIN Genres g ON s.GenreID = g.GenreID
    WHERE ps.PlaylistID = @PlaylistID
    ORDER BY ps.OrderIndex;
END
GO

-- SP: Thống kê bài hát theo thể loại
CREATE PROCEDURE sp_GetStatsByGenre
AS
BEGIN
    SELECT 
        g.GenreName,
        COUNT(s.SongID) AS SongCount,
        SUM(s.Duration) AS TotalDuration,
        AVG(CAST(s.Rating AS FLOAT)) AS AvgRating
    FROM Genres g
    LEFT JOIN Songs s ON g.GenreID = s.GenreID
    GROUP BY g.GenreID, g.GenreName
    ORDER BY SongCount DESC;
END
GO

-- SP: Thống kê bài hát theo năm
CREATE PROCEDURE sp_GetStatsByYear
AS
BEGIN
    SELECT 
        ReleaseYear,
        COUNT(*) AS SongCount
    FROM Songs
    WHERE ReleaseYear IS NOT NULL
    GROUP BY ReleaseYear
    ORDER BY ReleaseYear DESC;
END
GO

-- SP: Lấy top bài hát được nghe nhiều nhất
CREATE PROCEDURE sp_GetTopPlayedSongs
    @TopCount INT = 10
AS
BEGIN
    SELECT TOP (@TopCount)
        s.SongID,
        s.SongTitle,
        a.ArtistName,
        g.GenreName,
        s.PlayCount,
        s.LastPlayedDate
    FROM Songs s
    LEFT JOIN Artists a ON s.ArtistID = a.ArtistID
    LEFT JOIN Genres g ON s.GenreID = g.GenreID
    ORDER BY s.PlayCount DESC, s.LastPlayedDate DESC;
END
GO

-- SP: Lấy bài hát yêu thích
CREATE PROCEDURE sp_GetFavoriteSongs
AS
BEGIN
    SELECT 
        s.SongID,
        s.SongTitle,
        a.ArtistName,
        al.AlbumName,
        g.GenreName,
        s.Duration,
        s.FilePath,
        s.PlayCount,
        s.Rating
    FROM Songs s
    LEFT JOIN Artists a ON s.ArtistID = a.ArtistID
    LEFT JOIN Albums al ON s.AlbumID = al.AlbumID
    LEFT JOIN Genres g ON s.GenreID = g.GenreID
    WHERE s.IsFavorite = 1
    ORDER BY s.SongTitle;
END
GO

-- SP: Lấy/Cập nhật cài đặt
CREATE PROCEDURE sp_GetSetting
    @SettingKey NVARCHAR(100)
AS
BEGIN
    SELECT SettingValue FROM Settings WHERE SettingKey = @SettingKey;
END
GO

CREATE PROCEDURE sp_UpdateSetting
    @SettingKey NVARCHAR(100),
    @SettingValue NVARCHAR(500)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Settings WHERE SettingKey = @SettingKey)
    BEGIN
        UPDATE Settings 
        SET SettingValue = @SettingValue, UpdatedDate = GETDATE()
        WHERE SettingKey = @SettingKey;
    END
    ELSE
    BEGIN
        INSERT INTO Settings (SettingKey, SettingValue)
        VALUES (@SettingKey, @SettingValue);
    END
END
GO

PRINT N'✅ Database MusicLibraryDB đã được tạo thành công!';
PRINT N'📊 Đã tạo 7 bảng chính';
PRINT N'⚙️ Đã tạo 23 Stored Procedures';
PRINT N'📝 Đã thêm dữ liệu mẫu cho Genres, Artists, và Settings';
GO

