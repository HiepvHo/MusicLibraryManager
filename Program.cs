using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicLibraryManager.GUI;
using MusicLibraryManager.Entities;

namespace MusicLibraryManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Hiển thị form đăng nhập trước
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Nếu đăng nhập thành công, mở MainForm với thông tin user
                User currentUser = loginForm.CurrentUser;
                Application.Run(new MainForm(currentUser));
            }
            else
            {
                // Nếu không đăng nhập, thoát ứng dụng
                Application.Exit();
            }
        }
    }
}
