namespace MusicLibraryManager.GUI
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMain = new Sunny.UI.UIPanel();
            this.chkShowPassword = new Sunny.UI.UICheckBox();
            this.btnCancel = new Sunny.UI.UIButton();
            this.btnRegister = new Sunny.UI.UIButton();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.lblEmail = new Sunny.UI.UILabel();
            this.txtFullName = new Sunny.UI.UITextBox();
            this.lblFullName = new Sunny.UI.UILabel();
            this.txtConfirmPassword = new Sunny.UI.UITextBox();
            this.lblConfirmPassword = new Sunny.UI.UILabel();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.lblPassword = new Sunny.UI.UILabel();
            this.txtUsername = new Sunny.UI.UITextBox();
            this.lblUsername = new Sunny.UI.UILabel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.chkShowPassword);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnRegister);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.txtFullName);
            this.pnlMain.Controls.Add(this.lblFullName);
            this.pnlMain.Controls.Add(this.txtConfirmPassword);
            this.pnlMain.Controls.Add(this.lblConfirmPassword);
            this.pnlMain.Controls.Add(this.txtPassword);
            this.pnlMain.Controls.Add(this.lblPassword);
            this.pnlMain.Controls.Add(this.txtUsername);
            this.pnlMain.Controls.Add(this.lblUsername);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(500, 600);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Text = null;
            this.pnlMain.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkShowPassword.Location = new System.Drawing.Point(60, 450);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(200, 29);
            this.chkShowPassword.TabIndex = 13;
            this.chkShowPassword.Text = "Hiển thị mật khẩu";
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancel.Location = new System.Drawing.Point(270, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 45);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "❌ Hủy";
            this.btnCancel.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Location = new System.Drawing.Point(60, 500);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(190, 45);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "📝 Đăng ký";
            this.btnRegister.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEmail.Location = new System.Drawing.Point(60, 410);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmail.ShowText = false;
            this.txtEmail.Size = new System.Drawing.Size(380, 32);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Watermark = "Email (không bắt buộc)";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEmail.Location = new System.Drawing.Point(60, 380);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(150, 25);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFullName
            // 
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFullName.Location = new System.Drawing.Point(60, 340);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFullName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Padding = new System.Windows.Forms.Padding(5);
            this.txtFullName.ShowText = false;
            this.txtFullName.Size = new System.Drawing.Size(380, 32);
            this.txtFullName.TabIndex = 8;
            this.txtFullName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFullName.Watermark = "Nhập họ tên đầy đủ";
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFullName.Location = new System.Drawing.Point(60, 310);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(150, 25);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = "Họ tên: *";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(60, 270);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.ShowText = false;
            this.txtConfirmPassword.Size = new System.Drawing.Size(380, 32);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtConfirmPassword.Watermark = "Nhập lại mật khẩu";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(60, 240);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(200, 25);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "Xác nhận mật khẩu: *";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPassword.Location = new System.Drawing.Point(60, 200);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(380, 32);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "Ít nhất 6 ký tự";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPassword.Location = new System.Drawing.Point(60, 170);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(150, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Mật khẩu: *";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtUsername.Location = new System.Drawing.Point(60, 130);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(5);
            this.txtUsername.ShowText = false;
            this.txtUsername.Size = new System.Drawing.Size(380, 32);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUsername.Watermark = "Nhập tên đăng nhập";
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblUsername.Location = new System.Drawing.Point(60, 100);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(200, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Tên đăng nhập: *";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(60, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📝 ĐĂNG KÝ TÀI KHOẢN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng ký - Music Library Manager";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel pnlMain;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblUsername;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UILabel lblPassword;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UILabel lblConfirmPassword;
        private Sunny.UI.UITextBox txtConfirmPassword;
        private Sunny.UI.UILabel lblFullName;
        private Sunny.UI.UITextBox txtFullName;
        private Sunny.UI.UILabel lblEmail;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UIButton btnRegister;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UICheckBox chkShowPassword;
    }
}

