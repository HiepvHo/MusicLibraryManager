using System;
using System.Windows.Forms;

namespace MusicLibraryManager.Helpers
{
    /// <summary>
    /// Helper cho UI dialogs với tiếng Việt
    /// </summary>
    public static class UIHelper
    {
        /// <summary>
        /// Hiển thị dialog Yes/No bằng tiếng Việt
        /// </summary>
        /// <param name="message">Nội dung thông báo</param>
        /// <param name="title">Tiêu đề (mặc định: "Xác nhận")</param>
        /// <returns>True nếu user chọn Có, False nếu chọn Không</returns>
        public static bool ShowConfirm(string message, string title = "Xác nhận")
        {
            // Dùng MessageBox của Windows Forms với nút tiếng Việt
            DialogResult result = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2 // Default = No (an toàn hơn)
            );
            
            return result == DialogResult.Yes;
        }
        
        /// <summary>
        /// Hiển thị dialog xác nhận xóa
        /// </summary>
        public static bool ShowDeleteConfirm(string itemName)
        {
            return ShowConfirm(
                $"Bạn có chắc muốn xóa {itemName} này?\n\nThao tác này không thể hoàn tác!",
                "Xác nhận xóa"
            );
        }
        
        /// <summary>
        /// Hiển thị dialog xác nhận cập nhật
        /// </summary>
        public static bool ShowUpdateConfirm(string itemName)
        {
            return ShowConfirm(
                $"Bạn có chắc muốn cập nhật {itemName} này?",
                "Xác nhận cập nhật"
            );
        }
        
        /// <summary>
        /// Hiển thị dialog xác nhận đăng xuất
        /// </summary>
        public static bool ShowLogoutConfirm()
        {
            return ShowConfirm(
                "Bạn có chắc muốn đăng xuất?",
                "Xác nhận đăng xuất"
            );
        }
        
        /// <summary>
        /// Hiển thị dialog xác nhận thoát
        /// </summary>
        public static bool ShowExitConfirm()
        {
            return ShowConfirm(
                "Bạn có chắc muốn thoát ứng dụng?",
                "Xác nhận thoát"
            );
        }
        
        /// <summary>
        /// Hiển thị thông báo thành công
        /// </summary>
        public static void ShowSuccess(string message, string title = "Thành công")
        {
            MessageBox.Show(
                message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        
        /// <summary>
        /// Hiển thị thông báo cảnh báo
        /// </summary>
        public static void ShowWarning(string message, string title = "Cảnh báo")
        {
            MessageBox.Show(
                message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
        
        /// <summary>
        /// Hiển thị thông báo lỗi
        /// </summary>
        public static void ShowError(string message, string title = "Lỗi")
        {
            MessageBox.Show(
                message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}

