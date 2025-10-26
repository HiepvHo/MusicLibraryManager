namespace MusicLibraryManager.GUI
{
    partial class ForgotPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlStep1 = new Sunny.UI.UIPanel();
            this.btnCancel = new Sunny.UI.UISymbolButton();
            this.btnSendCode = new Sunny.UI.UISymbolButton();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.lblTitle1 = new Sunny.UI.UILabel();
            this.pnlStep2 = new Sunny.UI.UIPanel();
            this.chkShowPassword = new Sunny.UI.UICheckBox();
            this.lblResendCode = new Sunny.UI.UILabel();
            this.btnBack = new Sunny.UI.UISymbolButton();
            this.btnResetPassword = new Sunny.UI.UISymbolButton();
            this.txtConfirmPassword = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.txtNewPassword = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.txtToken = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.lblEmailSent = new Sunny.UI.UILabel();
            this.lblTitle2 = new Sunny.UI.UILabel();
            this.pnlStep1.SuspendLayout();
            this.pnlStep2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStep1
            // 
            this.pnlStep1.Controls.Add(this.btnCancel);
            this.pnlStep1.Controls.Add(this.btnSendCode);
            this.pnlStep1.Controls.Add(this.txtEmail);
            this.pnlStep1.Controls.Add(this.uiLabel2);
            this.pnlStep1.Controls.Add(this.uiLabel1);
            this.pnlStep1.Controls.Add(this.lblTitle1);
            this.pnlStep1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlStep1.Location = new System.Drawing.Point(0, 35);
            this.pnlStep1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlStep1.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlStep1.Name = "pnlStep1";
            this.pnlStep1.Size = new System.Drawing.Size(600, 465);
            this.pnlStep1.TabIndex = 0;
            this.pnlStep1.Text = null;
            this.pnlStep1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(320, 350);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(230, 45);
            this.btnCancel.Symbol = 61453;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSendCode
            // 
            this.btnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSendCode.Location = new System.Drawing.Point(50, 350);
            this.btnSendCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(250, 45);
            this.btnSendCode.Symbol = 61664;
            this.btnSendCode.TabIndex = 1;
            this.btnSendCode.Text = "Gửi mã khôi phục";
            this.btnSendCode.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(50, 250);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmail.ShowText = false;
            this.txtEmail.Size = new System.Drawing.Size(500, 40);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Watermark = "yourname@example.com";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(50, 215);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(500, 25);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "Địa chỉ Email:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiLabel1.Location = new System.Drawing.Point(50, 110);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(500, 80);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "Nhập địa chỉ email đã đăng ký của bạn.\r\nChúng tôi sẽ gửi mã khôi phục đến email đ" +
    "ó.\r\n\r\nMã có hiệu lực trong 30 phút.";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblTitle1
            // 
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTitle1.Location = new System.Drawing.Point(50, 40);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(500, 40);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "🔐 Quên mật khẩu?";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStep2
            // 
            this.pnlStep2.Controls.Add(this.chkShowPassword);
            this.pnlStep2.Controls.Add(this.lblResendCode);
            this.pnlStep2.Controls.Add(this.btnBack);
            this.pnlStep2.Controls.Add(this.btnResetPassword);
            this.pnlStep2.Controls.Add(this.txtConfirmPassword);
            this.pnlStep2.Controls.Add(this.uiLabel7);
            this.pnlStep2.Controls.Add(this.txtNewPassword);
            this.pnlStep2.Controls.Add(this.uiLabel6);
            this.pnlStep2.Controls.Add(this.txtToken);
            this.pnlStep2.Controls.Add(this.uiLabel5);
            this.pnlStep2.Controls.Add(this.lblEmailSent);
            this.pnlStep2.Controls.Add(this.lblTitle2);
            this.pnlStep2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlStep2.Location = new System.Drawing.Point(0, 35);
            this.pnlStep2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlStep2.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlStep2.Name = "pnlStep2";
            this.pnlStep2.Size = new System.Drawing.Size(600, 465);
            this.pnlStep2.TabIndex = 1;
            this.pnlStep2.Text = null;
            this.pnlStep2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlStep2.Visible = false;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkShowPassword.Location = new System.Drawing.Point(50, 345);
            this.chkShowPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(200, 25);
            this.chkShowPassword.TabIndex = 3;
            this.chkShowPassword.Text = "Hiển thị mật khẩu";
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // lblResendCode
            // 
            this.lblResendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblResendCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblResendCode.Location = new System.Drawing.Point(260, 345);
            this.lblResendCode.Name = "lblResendCode";
            this.lblResendCode.Size = new System.Drawing.Size(290, 25);
            this.lblResendCode.TabIndex = 11;
            this.lblResendCode.Text = "📧 Gửi lại mã khôi phục";
            this.lblResendCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResendCode.Click += new System.EventHandler(this.lblResendCode_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(320, 390);
            this.btnBack.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(230, 45);
            this.btnBack.Symbol = 61700;
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay lại";
            this.btnBack.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnResetPassword.Location = new System.Drawing.Point(50, 390);
            this.btnResetPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(250, 45);
            this.btnResetPassword.Symbol = 61533;
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(50, 295);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.ShowText = false;
            this.txtConfirmPassword.Size = new System.Drawing.Size(500, 40);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtConfirmPassword.Watermark = "Nhập lại mật khẩu mới";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(50, 265);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(500, 25);
            this.uiLabel7.TabIndex = 8;
            this.uiLabel7.Text = "Xác nhận mật khẩu:";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNewPassword.Location = new System.Drawing.Point(50, 215);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.ShowText = false;
            this.txtNewPassword.Size = new System.Drawing.Size(500, 40);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNewPassword.Watermark = "Nhập mật khẩu mới (tối thiểu 6 ký tự)";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(50, 185);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(500, 25);
            this.uiLabel6.TabIndex = 6;
            this.uiLabel6.Text = "Mật khẩu mới:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtToken
            // 
            this.txtToken.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtToken.Location = new System.Drawing.Point(50, 135);
            this.txtToken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtToken.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtToken.Name = "txtToken";
            this.txtToken.Padding = new System.Windows.Forms.Padding(5);
            this.txtToken.ShowText = false;
            this.txtToken.Size = new System.Drawing.Size(500, 40);
            this.txtToken.TabIndex = 0;
            this.txtToken.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtToken.Watermark = "A1B2-C3D4-E5F6";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(50, 105);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(500, 25);
            this.uiLabel5.TabIndex = 4;
            this.uiLabel5.Text = "Mã khôi phục (từ email):";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmailSent
            // 
            this.lblEmailSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmailSent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblEmailSent.Location = new System.Drawing.Point(50, 70);
            this.lblEmailSent.Name = "lblEmailSent";
            this.lblEmailSent.Size = new System.Drawing.Size(500, 25);
            this.lblEmailSent.TabIndex = 1;
            this.lblEmailSent.Text = "✅ Mã khôi phục đã được gửi đến email của bạn";
            this.lblEmailSent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle2
            // 
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTitle2.Location = new System.Drawing.Point(50, 20);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(500, 40);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "🔑 Đặt lại mật khẩu";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.pnlStep2);
            this.Controls.Add(this.pnlStep1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên mật khẩu";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 600, 500);
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.pnlStep1.ResumeLayout(false);
            this.pnlStep2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pnlStep1;
        private Sunny.UI.UILabel lblTitle1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UISymbolButton btnSendCode;
        private Sunny.UI.UISymbolButton btnCancel;
        private Sunny.UI.UIPanel pnlStep2;
        private Sunny.UI.UILabel lblTitle2;
        private Sunny.UI.UILabel lblEmailSent;
        private Sunny.UI.UITextBox txtToken;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtNewPassword;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox txtConfirmPassword;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UISymbolButton btnResetPassword;
        private Sunny.UI.UISymbolButton btnBack;
        private Sunny.UI.UILabel lblResendCode;
        private Sunny.UI.UICheckBox chkShowPassword;
    }
}

