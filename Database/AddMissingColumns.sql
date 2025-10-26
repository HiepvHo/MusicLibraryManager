-- =============================================
-- Script: Thêm các cột còn thiếu vào bảng Songs
-- =============================================

USE MusicLibraryDB;
GO

PRINT '===== THÊM CÁC CỘT CÒN THIẾU =====';
GO

-- Kiểm tra và thêm UpdatedDate vào Songs
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[Songs]') AND name = 'UpdatedDate')
BEGIN
    ALTER TABLE Songs ADD UpdatedDate DATETIME NULL;
    PRINT '✅ Đã thêm cột UpdatedDate vào bảng Songs';
END
ELSE
BEGIN
    PRINT '⚠️ Cột UpdatedDate đã tồn tại trong bảng Songs';
END
GO

-- Cập nhật giá trị UpdatedDate cho Songs
UPDATE Songs SET UpdatedDate = ISNULL(UpdatedDate, CreatedDate);
ALTER TABLE Songs ALTER COLUMN UpdatedDate DATETIME NOT NULL;
PRINT '✅ Đã cập nhật UpdatedDate cho Songs';
GO

-- Kiểm tra và thêm UpdatedDate vào Artists
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[Artists]') AND name = 'UpdatedDate')
BEGIN
    ALTER TABLE Artists ADD UpdatedDate DATETIME DEFAULT GETDATE();
    UPDATE Artists SET UpdatedDate = CreatedDate WHERE UpdatedDate IS NULL;
    PRINT '✅ Đã thêm cột UpdatedDate vào bảng Artists';
END
ELSE
BEGIN
    PRINT '⚠️ Cột UpdatedDate đã tồn tại trong bảng Artists';
END
GO

-- Kiểm tra và thêm UpdatedDate vào Albums (nếu chưa có)
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[Albums]') AND name = 'UpdatedDate')
BEGIN
    ALTER TABLE Albums ADD UpdatedDate DATETIME DEFAULT GETDATE();
    PRINT '✅ Đã thêm cột UpdatedDate vào bảng Albums';
END
ELSE
BEGIN
    PRINT '⚠️ Cột UpdatedDate đã tồn tại trong bảng Albums';
END
GO

-- Kiểm tra và thêm UpdatedDate vào Playlists
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[Playlists]') AND name = 'UpdatedDate')
BEGIN
    ALTER TABLE Playlists ADD UpdatedDate DATETIME DEFAULT GETDATE();
    UPDATE Playlists SET UpdatedDate = CreatedDate WHERE UpdatedDate IS NULL;
    PRINT '✅ Đã thêm cột UpdatedDate vào bảng Playlists';
END
ELSE
BEGIN
    PRINT '⚠️ Cột UpdatedDate đã tồn tại trong bảng Playlists';
END
GO

PRINT '';
PRINT '===== HOÀN TẤT THÊM CÁC CỘT =====';
PRINT '✅ Tất cả bảng đã có cột UpdatedDate';
GO

