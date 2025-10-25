-- =============================================
-- Script: Thêm các stored procedures còn thiếu
-- Mô tả: Thêm sp_UpdateArtist và sp_UpdateGenre nếu chưa có
-- =============================================

USE MusicLibraryDB;
GO

-- =============================================
-- Stored Procedure: sp_UpdateArtist
-- Mô tả: Cập nhật thông tin ca sĩ
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UpdateArtist]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[sp_UpdateArtist];
GO

CREATE PROCEDURE sp_UpdateArtist
    @ArtistID INT,
    @ArtistName NVARCHAR(200),
    @Biography NVARCHAR(MAX) = NULL,
    @Country NVARCHAR(100) = NULL,
    @ImagePath NVARCHAR(500) = NULL
AS
BEGIN
    -- Không dùng SET NOCOUNT ON để ExecuteNonQuery return số dòng bị ảnh hưởng
    
    UPDATE Artists
    SET ArtistName = @ArtistName,
        Biography = @Biography,
        Country = @Country,
        ImagePath = @ImagePath,
        UpdatedDate = GETDATE()
    WHERE ArtistID = @ArtistID;
END;
GO

-- =============================================
-- Stored Procedure: sp_UpdateGenre
-- Mô tả: Cập nhật thông tin thể loại
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UpdateGenre]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[sp_UpdateGenre];
GO

CREATE PROCEDURE sp_UpdateGenre
    @GenreID INT,
    @GenreName NVARCHAR(100),
    @Description NVARCHAR(500) = NULL
AS
BEGIN
    -- Không dùng SET NOCOUNT ON để ExecuteNonQuery return số dòng bị ảnh hưởng
    
    UPDATE Genres
    SET GenreName = @GenreName,
        Description = @Description
    WHERE GenreID = @GenreID;
END;
GO

PRINT 'Đã thêm thành công sp_UpdateArtist và sp_UpdateGenre!';
GO

