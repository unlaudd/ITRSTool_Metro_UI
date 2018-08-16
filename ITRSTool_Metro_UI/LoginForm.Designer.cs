namespace ITRSTool_Metro_UI
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.lblResetPass = new MetroFramework.Controls.MetroLabel();
            this.lblRegistration = new MetroFramework.Controls.MetroLabel();
            this.chkRemember = new MetroFramework.Controls.MetroCheckBox();
            this.txtLogin = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(270, 141);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Вход";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(128, 143);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblResetPass
            // 
            this.lblResetPass.AutoSize = true;
            this.lblResetPass.Location = new System.Drawing.Point(235, 179);
            this.lblResetPass.Name = "lblResetPass";
            this.lblResetPass.Size = new System.Drawing.Size(110, 19);
            this.lblResetPass.TabIndex = 8;
            this.lblResetPass.Text = "Забыли пароль?";
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Location = new System.Drawing.Point(9, 179);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(86, 19);
            this.lblRegistration.TabIndex = 9;
            this.lblRegistration.Text = "Регистрация";
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Location = new System.Drawing.Point(128, 122);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(115, 15);
            this.chkRemember.TabIndex = 12;
            this.chkRemember.Text = "Запомнить меня";
            this.chkRemember.UseSelectable = true;
            // 
            // txtLogin
            // 
            // 
            // 
            // 
            this.txtLogin.CustomButton.Image = null;
            this.txtLogin.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtLogin.CustomButton.Name = "";
            this.txtLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLogin.CustomButton.TabIndex = 1;
            this.txtLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogin.CustomButton.UseSelectable = true;
            this.txtLogin.CustomButton.Visible = false;
            this.txtLogin.DisplayIcon = true;
            this.txtLogin.Icon = ((System.Drawing.Image)(resources.GetObject("txtLogin.Icon")));
            this.txtLogin.Lines = new string[0];
            this.txtLogin.Location = new System.Drawing.Point(128, 63);
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.PromptText = "Введите имя пользователя";
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.ShortcutsEnabled = true;
            this.txtLogin.Size = new System.Drawing.Size(216, 23);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.UseSelectable = true;
            this.txtLogin.WaterMark = "Введите имя пользователя";
            this.txtLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ITRSTool_Metro_UI.Properties.Resources.administrator;
            this.pictureBox1.Location = new System.Drawing.Point(9, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.DisplayIcon = true;
            this.txtPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtPass.Icon")));
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(128, 92);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.PromptText = "Введите пароль";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(217, 23);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSelectable = true;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.WaterMark = "Введите пароль";
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(367, 207);
            this.ControlBox = false;
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.lblResetPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "Вход в систему";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroLabel lblResetPass;
        private MetroFramework.Controls.MetroLabel lblRegistration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtLogin;
        private MetroFramework.Controls.MetroCheckBox chkRemember;
    }
}

