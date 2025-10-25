-- ============================================
-- Script: Add Users Table for Login System
-- Description: Thêm bảng Users và dữ liệu mẫu
-- ============================================

USE MusicLibraryDB;
GO

-- Tạo bảng Users
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
BEGIN
    CREATE TABLE Users (
        UserID INT PRIMARY KEY IDENTITY(1,1),
        Username NVARCHAR(50) NOT NULL UNIQUE,
        Password NVARCHAR(256) NOT NULL, -- Mã hóa SHA256
        FullName NVARCHAR(100) NOT NULL,
        Email NVARCHAR(100),
        IsActive BIT DEFAULT 1,
        CreatedDate DATETIME DEFAULT GETDATE(),
        LastLoginDate DATETIME
    );
    
    PRINT N'✅ Đã tạo bảng Users';
END
GO

-- Tạo index
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Users_Username')
BEGIN
    CREATE INDEX IX_Users_Username ON Users(Username);
    PRINT N'✅ Đã tạo index cho Username';
END
GO

-- ============================================
-- Stored Procedures cho User
-- ============================================

-- SP: Đăng nhập
IF OBJECT_ID('sp_Login', 'P') IS NOT NULL
    DROP PROCEDURE sp_Login;
GO

CREATE PROCEDURE sp_Login
    @Username NVARCHAR(50),
    @Password NVARCHAR(256)
AS
BEGIN
    -- Kiểm tra user và password
    IF EXISTS (
        SELECT 1 FROM Users 
        WHERE Username = @Username 
        AND Password = @Password 
        AND IsActive = 1
    )
    BEGIN
        -- Cập nhật LastLoginDate
        UPDATE Users 
        SET LastLoginDate = GETDATE()
        WHERE Username = @Username;
        
        -- Trả về thông tin user
        SELECT 
            UserID,
            Username,
            FullName,
            Email,
            LastLoginDate
        FROM Users
        WHERE Username = @Username;
    END
    ELSE
    BEGIN
        -- Trả về empty result nếu sai
        SELECT NULL AS UserID;
    END
END
GO

-- SP: Thêm user mới (Đăng ký)
IF OBJECT_ID('sp_RegisterUser', 'P') IS NOT NULL
    DROP PROCEDURE sp_RegisterUser;
GO

CREATE PROCEDURE sp_RegisterUser
    @Username NVARCHAR(50),
    @Password NVARCHAR(256),
    @FullName NVARCHAR(100),
    @Email NVARCHAR(100) = NULL
AS
BEGIN
    -- Kiểm tra username đã tồn tại chưa
    IF EXISTS (SELECT 1 FROM Users WHERE Username = @Username)
    BEGIN
        SELECT -1 AS UserID; -- Username đã tồn tại
        RETURN;
    END
    
    -- Thêm user mới
    INSERT INTO Users (Username, Password, FullName, Email)
    VALUES (@Username, @Password, @FullName, @Email);
    
    SELECT SCOPE_IDENTITY() AS UserID;
END
GO

-- SP: Đổi mật khẩu
IF OBJECT_ID('sp_ChangePassword', 'P') IS NOT NULL
    DROP PROCEDURE sp_ChangePassword;
GO

CREATE PROCEDURE sp_ChangePassword
    @UserID INT,
    @OldPassword NVARCHAR(256),
    @NewPassword NVARCHAR(256)
AS
BEGIN
    -- Kiểm tra mật khẩu cũ
    IF EXISTS (
        SELECT 1 FROM Users 
        WHERE UserID = @UserID 
        AND Password = @OldPassword
    )
    BEGIN
        UPDATE Users 
        SET Password = @NewPassword
        WHERE UserID = @UserID;
        
        SELECT 1 AS Success;
    END
    ELSE
    BEGIN
        SELECT 0 AS Success; -- Mật khẩu cũ sai
    END
END
GO

-- ============================================
-- Thêm dữ liệu mẫu (Password đã mã hóa SHA256)
-- ============================================

-- Xóa dữ liệu cũ nếu có
DELETE FROM Users;
GO

-- Thêm user mẫu
-- Username: admin, Password: admin123 (SHA256)
INSERT INTO Users (Username, Password, FullName, Email) VALUES
(N'admin', N'240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9', N'Quản trị viên', N'admin@musiclibrary.com'),
(N'user1', N'0A041B9462CAA4A31BAC3567E0B6E6FD9100787DB2AB433D96F6D178CABFCE90', N'Người dùng 1', N'user1@example.com');
-- Password cho user1: 123456

GO

PRINT N'';
PRINT N'✅ HOÀN THÀNH!';
PRINT N'📊 Đã tạo bảng Users';
PRINT N'⚙️ Đã tạo 3 Stored Procedures';
PRINT N'👤 Đã thêm 2 user mẫu:';
PRINT N'   - Username: admin   | Password: admin123';
PRINT N'   - Username: user1   | Password: 123456';
GO

