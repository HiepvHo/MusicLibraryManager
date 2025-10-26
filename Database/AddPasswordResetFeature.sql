-- =============================================
-- Script: Thêm tính năng Reset Password qua Email
-- =============================================

USE MusicLibraryDB;
GO

PRINT '';
PRINT '╔════════════════════════════════════════════════════════╗';
PRINT '║      THÊM TÍNH NĂNG RESET PASSWORD QUA EMAIL         ║';
PRINT '╚════════════════════════════════════════════════════════╝';
PRINT '';

-- =============================================
-- BƯỚC 1: TẠO BẢNG PASSWORDRESETTOKENS
-- =============================================
PRINT '===== BƯỚC 1: TẠO BẢNG PASSWORDRESETTOKENS =====';
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PasswordResetTokens]') AND type in (N'U'))
BEGIN
    DROP TABLE PasswordResetTokens;
    PRINT '✅ Đã xóa bảng PasswordResetTokens cũ';
END
GO

CREATE TABLE PasswordResetTokens (
    TokenID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    Token NVARCHAR(255) NOT NULL UNIQUE,
    ExpiresAt DATETIME NOT NULL,
    IsUsed BIT NOT NULL DEFAULT 0,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    UsedDate DATETIME NULL,
    
    CONSTRAINT FK_PasswordResetTokens_Users FOREIGN KEY (UserID) 
        REFERENCES Users(UserID) ON DELETE CASCADE
);
PRINT '✅ Đã tạo bảng PasswordResetTokens';
GO

-- Tạo index để tăng tốc query
CREATE INDEX IX_PasswordResetTokens_Token ON PasswordResetTokens(Token);
PRINT '✅ Đã tạo index IX_PasswordResetTokens_Token';
GO

CREATE INDEX IX_PasswordResetTokens_UserID ON PasswordResetTokens(UserID);
PRINT '✅ Đã tạo index IX_PasswordResetTokens_UserID';
GO

-- =============================================
-- BƯỚC 2: TẠO STORED PROCEDURES
-- =============================================
PRINT '';
PRINT '===== BƯỚC 2: TẠO STORED PROCEDURES =====';
GO

-- =============================================
-- sp_GetUserByEmail - Lấy thông tin user qua email
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'sp_GetUserByEmail') AND type in (N'P'))
    DROP PROCEDURE sp_GetUserByEmail;
GO

CREATE PROCEDURE sp_GetUserByEmail
    @Email NVARCHAR(100)
AS
BEGIN
    SELECT 
        UserID,
        Username,
        FullName,
        Email,
        Role,
        CreatedDate
    FROM Users
    WHERE Email = @Email;
END;
GO
PRINT '✅ sp_GetUserByEmail';

-- =============================================
-- sp_CreateResetToken - Tạo token reset password
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'sp_CreateResetToken') AND type in (N'P'))
    DROP PROCEDURE sp_CreateResetToken;
GO

CREATE PROCEDURE sp_CreateResetToken
    @UserID INT,
    @Token NVARCHAR(255),
    @ExpiryMinutes INT = 30
AS
BEGIN
    -- Vô hiệu hóa các token cũ chưa dùng của user này
    UPDATE PasswordResetTokens
    SET IsUsed = 1, UsedDate = GETDATE()
    WHERE UserID = @UserID AND IsUsed = 0;
    
    -- Tạo token mới
    INSERT INTO PasswordResetTokens (UserID, Token, ExpiresAt, IsUsed)
    VALUES (@UserID, @Token, DATEADD(MINUTE, @ExpiryMinutes, GETDATE()), 0);
    
    SELECT SCOPE_IDENTITY() AS TokenID;
END;
GO
PRINT '✅ sp_CreateResetToken';

-- =============================================
-- sp_VerifyResetToken - Kiểm tra token có hợp lệ không
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'sp_VerifyResetToken') AND type in (N'P'))
    DROP PROCEDURE sp_VerifyResetToken;
GO

CREATE PROCEDURE sp_VerifyResetToken
    @Token NVARCHAR(255)
AS
BEGIN
    SELECT 
        t.TokenID,
        t.UserID,
        u.Username,
        u.Email,
        t.ExpiresAt,
        t.IsUsed,
        CASE 
            WHEN t.IsUsed = 1 THEN 'USED'
            WHEN t.ExpiresAt < GETDATE() THEN 'EXPIRED'
            ELSE 'VALID'
        END AS TokenStatus
    FROM PasswordResetTokens t
    INNER JOIN Users u ON t.UserID = u.UserID
    WHERE t.Token = @Token;
END;
GO
PRINT '✅ sp_VerifyResetToken';

-- =============================================
-- sp_MarkTokenAsUsed - Đánh dấu token đã sử dụng
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'sp_MarkTokenAsUsed') AND type in (N'P'))
    DROP PROCEDURE sp_MarkTokenAsUsed;
GO

CREATE PROCEDURE sp_MarkTokenAsUsed
    @Token NVARCHAR(255)
AS
BEGIN
    UPDATE PasswordResetTokens
    SET IsUsed = 1, UsedDate = GETDATE()
    WHERE Token = @Token;
END;
GO
PRINT '✅ sp_MarkTokenAsUsed';

-- =============================================
-- sp_UpdatePasswordByUserID - Cập nhật mật khẩu
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'sp_UpdatePasswordByUserID') AND type in (N'P'))
    DROP PROCEDURE sp_UpdatePasswordByUserID;
GO

CREATE PROCEDURE sp_UpdatePasswordByUserID
    @UserID INT,
    @PasswordHash NVARCHAR(255)
AS
BEGIN
    UPDATE Users
    SET PasswordHash = @PasswordHash
    WHERE UserID = @UserID;
    
    -- Trả về số dòng đã update
    SELECT @@ROWCOUNT AS RowsAffected;
END;
GO
PRINT '✅ sp_UpdatePasswordByUserID';

-- =============================================
-- sp_CleanupExpiredTokens - Xóa token đã hết hạn
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'sp_CleanupExpiredTokens') AND type in (N'P'))
    DROP PROCEDURE sp_CleanupExpiredTokens;
GO

CREATE PROCEDURE sp_CleanupExpiredTokens
AS
BEGIN
    DELETE FROM PasswordResetTokens
    WHERE ExpiresAt < DATEADD(DAY, -7, GETDATE()); -- Xóa token cũ hơn 7 ngày
    
    SELECT @@ROWCOUNT AS DeletedCount;
END;
GO
PRINT '✅ sp_CleanupExpiredTokens';

-- =============================================
-- HOÀN TẤT
-- =============================================
PRINT '';
PRINT '╔════════════════════════════════════════════════════════╗';
PRINT '║            HOÀN TẤT SETUP!                            ║';
PRINT '╚════════════════════════════════════════════════════════╝';
PRINT '';
PRINT '✅ Bảng PasswordResetTokens đã được tạo';
PRINT '✅ 6 Stored Procedures đã được tạo:';
PRINT '   1. sp_GetUserByEmail';
PRINT '   2. sp_CreateResetToken';
PRINT '   3. sp_VerifyResetToken';
PRINT '   4. sp_MarkTokenAsUsed';
PRINT '   5. sp_UpdatePasswordByUserID';
PRINT '   6. sp_CleanupExpiredTokens';
PRINT '';
PRINT '📌 Token settings:';
PRINT '   - Thời hạn: 30 phút';
PRINT '   - Format: GUID (A1B2C3D4-...)';
PRINT '   - Cleanup: Tự động xóa token cũ hơn 7 ngày';
PRINT '';
PRINT '🎯 Sẵn sàng cho Password Reset feature!';
PRINT '';
GO

