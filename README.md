# 🎵 Music Library Manager

Ứng dụng quản lý và phát nhạc trên nền tảng Windows với giao diện hiện đại sử dụng Sunny.UI.

## 📋 Tổng quan

**MusicLibraryManager** là phần mềm quản lý thư viện nhạc cá nhân, cho phép người dùng:
- Quản lý bài hát (thêm, sửa, xóa, tìm kiếm)
- Quản lý ca sĩ và thể loại
- Tạo và quản lý playlist
- Xem thống kê và báo cáo
- Giao diện Dark/Light mode

## 🛠️ Công nghệ sử dụng

- **Ngôn ngữ**: C# (.NET Framework 4.7.2)
- **UI Framework**: Sunny.UI 3.8.9
- **Database**: SQL Server (ADMIN\SQLEXPRESS)
- **Kiến trúc**: 3 lớp (GUI - BUS - DAL)

## 📁 Cấu trúc dự án

```
MusicLibraryManager/
├── Database/
│   ├── CreateDatabase.sql       # Script tạo database
│   └── README.md               # Hướng dẫn database
├── Entities/                   # Entity classes
│   ├── Song.cs
│   ├── Artist.cs
│   ├── Genre.cs
│   ├── Playlist.cs
│   └── ...
├── DAL/                        # Data Access Layer
│   ├── DatabaseHelper.cs
│   ├── SongDAO.cs
│   ├── ArtistDAO.cs
│   └── ...
├── BUS/                        # Business Logic Layer
│   ├── SongBUS.cs
│   ├── ArtistBUS.cs
│   └── ...
├── GUI/                        # User Interface
│   ├── MainForm.cs
│   ├── SongManagementForm.cs
│   ├── ArtistGenreManagementForm.cs
│   ├── PlaylistManagementForm.cs
│   ├── StatisticsForm.cs
│   └── SettingsForm.cs
└── App.config                  # Connection string

```

## 🚀 Hướng dẫn cài đặt

### Bước 1: Tạo Database

1. Mở **SQL Server Management Studio** hoặc **Visual Studio**
2. Kết nối đến server: `ADMIN\SQLEXPRESS`
3. Mở file `Database/CreateDatabase.sql`
4. Chạy script (F5 hoặc Execute)
5. Database `MusicLibraryDB` sẽ được tạo với:
   - 7 bảng chính
   - 23 stored procedures
   - Dữ liệu mẫu (12 thể loại, 8 ca sĩ)

### Bước 2: Cấu hình Connection String

File `App.config` đã được cấu hình sẵn:
```xml
<connectionStrings>
  <add name="MusicLibraryDB" 
       connectionString="Data Source=ADMIN\SQLEXPRESS;Initial Catalog=MusicLibraryDB;Integrated Security=True;TrustServerCertificate=True" 
       providerName="System.Data.SqlClient"/>
</connectionStrings>
```

Nếu SQL Server của bạn khác, hãy chỉnh sửa `Data Source`.

### Bước 3: Build & Run

1. Mở solution trong Visual Studio
2. Build solution (Ctrl+Shift+B)
3. Chạy ứng dụng (F5)

## 📊 Database Schema

### Bảng chính:

**Artists** - Thông tin ca sĩ
- ArtistID (PK)
- ArtistName
- Biography
- Country
- ImagePath

**Genres** - Thể loại nhạc
- GenreID (PK)
- GenreName
- Description

**Songs** - Bài hát (bảng trung tâm)
- SongID (PK)
- SongTitle
- ArtistID (FK)
- GenreID (FK)
- AlbumID (FK)
- Duration
- FilePath
- ReleaseYear
- PlayCount
- IsFavorite
- Rating

**Playlists** - Danh sách phát
- PlaylistID (PK)
- PlaylistName
- Description

**PlaylistSongs** - Quan hệ nhiều-nhiều
- PlaylistID (FK)
- SongID (FK)

## 🎨 Tính năng

### 1. Quản lý Bài hát
- ➕ Thêm bài hát mới (hỗ trợ: mp3, wav, wma, flac, m4a, aac)
- ✏️ Sửa thông tin bài hát
- 🗑️ Xóa bài hát
- 🔍 Tìm kiếm theo tên, ca sĩ
- ❤️ Đánh dấu yêu thích

### 2. Quản lý Ca sĩ & Thể loại
- Thêm, sửa, xóa ca sĩ
- Quản lý thông tin: tên, quốc gia, tiểu sử
- Thêm, sửa, xóa thể loại nhạc

### 3. Playlist
- Tạo playlist mới
- Thêm/xóa bài hát vào playlist
- Quản lý nhiều playlist

### 4. Thống kê & Báo cáo
- Thống kê theo thể loại
- Top bài hát được nghe nhiều nhất
- Danh sách bài hát yêu thích

### 5. Cài đặt
- Dark/Light mode
- Chọn thư mục nhạc mặc định

## 🎯 Kiến trúc 3 lớp

### GUI (Presentation Layer)
- Hiển thị giao diện người dùng
- Xử lý sự kiện click, input
- Không chứa logic nghiệp vụ

### BUS (Business Logic Layer)
- Xử lý logic nghiệp vụ
- Validation dữ liệu
- Gọi DAL để truy xuất data

### DAL (Data Access Layer)
- Kết nối database
- Thực thi SQL queries
- Return data cho BUS

## 📝 Stored Procedures chính

```sql
-- SONGS
sp_GetAllSongs
sp_AddSong
sp_UpdateSong
sp_DeleteSong
sp_SearchSongs
sp_UpdatePlayCount
sp_ToggleFavorite
sp_GetFavoriteSongs
sp_GetTopPlayedSongs

-- ARTISTS
sp_GetAllArtists
sp_AddArtist

-- GENRES
sp_GetAllGenres
sp_AddGenre
sp_GetStatsByGenre

-- PLAYLISTS
sp_GetAllPlaylists
sp_CreatePlaylist
sp_GetPlaylistSongs
sp_AddSongToPlaylist
sp_RemoveSongFromPlaylist
```

## 🔧 Xử lý lỗi thường gặp

### Lỗi: Không kết nối được database
✅ **Giải pháp:**
- Kiểm tra SQL Server đã chạy chưa
- Kiểm tra connection string trong `App.config`
- Chạy lại script `CreateDatabase.sql`

### Lỗi: Thiếu tham chiếu Sunny.UI
✅ **Giải pháp:**
- Mở NuGet Package Manager
- Restore packages
- Rebuild solution

### Lỗi: File nhạc không tồn tại
✅ **Giải pháp:**
- Đảm bảo đường dẫn file chính xác
- File nhạc phải tồn tại trên máy
- Định dạng được hỗ trợ: mp3, wav, wma, flac, m4a, aac

## 📞 Hỗ trợ

Nếu gặp vấn đề:
1. Kiểm tra file `Database/README.md` để verify database
2. Xem log lỗi trong Output window của Visual Studio
3. Kiểm tra connection string

## 🎓 Mục đích học tập

Dự án này phù hợp để:
- Học kiến trúc 3 lớp
- Thực hành C# WinForms
- Làm việc với SQL Server
- Sử dụng UI Framework (Sunny.UI)
- Áp dụng OOP, Design Patterns

## 📄 License

Project này được tạo cho mục đích học tập và nghiên cứu.

---

**Phiên bản:** 1.0.0  
**Ngày tạo:** 2025  
**Framework:** .NET Framework 4.7.2

