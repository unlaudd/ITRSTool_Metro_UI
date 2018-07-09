namespace ITRSTool_Metro_UI
{
    partial class AppConfig
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
            this.panBaseConnector = new MetroFramework.Controls.MetroPanel();
            this.tileCheckBaseConnect = new MetroFramework.Controls.MetroTile();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtUserPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.txtBaseName = new MetroFramework.Controls.MetroTextBox();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.txtServer = new MetroFramework.Controls.MetroTextBox();
            this.tileBaseConnector = new MetroFramework.Controls.MetroTile();
            this.tileRecoveryBase = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.tileBackupBase = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panBaseConnector.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBaseConnector
            // 
            this.panBaseConnector.Controls.Add(this.metroLabel1);
            this.panBaseConnector.Controls.Add(this.tileCheckBaseConnect);
            this.panBaseConnector.Controls.Add(this.btnClear);
            this.panBaseConnector.Controls.Add(this.btnSave);
            this.panBaseConnector.Controls.Add(this.txtUserPassword);
            this.panBaseConnector.Controls.Add(this.txtUserName);
            this.panBaseConnector.Controls.Add(this.txtBaseName);
            this.panBaseConnector.Controls.Add(this.txtPort);
            this.panBaseConnector.Controls.Add(this.txtServer);
            this.panBaseConnector.HorizontalScrollbarBarColor = true;
            this.panBaseConnector.HorizontalScrollbarHighlightOnWheel = false;
            this.panBaseConnector.HorizontalScrollbarSize = 10;
            this.panBaseConnector.Location = new System.Drawing.Point(188, 53);
            this.panBaseConnector.Name = "panBaseConnector";
            this.panBaseConnector.Size = new System.Drawing.Size(472, 257);
            this.panBaseConnector.TabIndex = 0;
            this.panBaseConnector.VerticalScrollbarBarColor = true;
            this.panBaseConnector.VerticalScrollbarHighlightOnWheel = false;
            this.panBaseConnector.VerticalScrollbarSize = 10;
            this.panBaseConnector.Visible = false;
            // 
            // tileCheckBaseConnect
            // 
            this.tileCheckBaseConnect.ActiveControl = null;
            this.tileCheckBaseConnect.Location = new System.Drawing.Point(16, 199);
            this.tileCheckBaseConnect.Name = "tileCheckBaseConnect";
            this.tileCheckBaseConnect.Size = new System.Drawing.Size(48, 48);
            this.tileCheckBaseConnect.TabIndex = 6;
            this.tileCheckBaseConnect.TileImage = global::ITRSTool_Metro_UI.Properties.Resources.checkconnect;
            this.tileCheckBaseConnect.UseSelectable = true;
            this.tileCheckBaseConnect.UseTileImage = true;
            this.tileCheckBaseConnect.Click += new System.EventHandler(this.tileCheckBaseConnect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(188, 199);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(269, 199);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUserPassword
            // 
            // 
            // 
            // 
            this.txtUserPassword.CustomButton.Image = null;
            this.txtUserPassword.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtUserPassword.CustomButton.Name = "";
            this.txtUserPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserPassword.CustomButton.TabIndex = 1;
            this.txtUserPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserPassword.CustomButton.UseSelectable = true;
            this.txtUserPassword.CustomButton.Visible = false;
            this.txtUserPassword.DisplayIcon = true;
            this.txtUserPassword.Icon = global::ITRSTool_Metro_UI.Properties.Resources.Register;
            this.txtUserPassword.IconRight = true;
            this.txtUserPassword.Lines = new string[0];
            this.txtUserPassword.Location = new System.Drawing.Point(16, 170);
            this.txtUserPassword.MaxLength = 32767;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '\0';
            this.txtUserPassword.PromptText = "Пароль";
            this.txtUserPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserPassword.SelectedText = "";
            this.txtUserPassword.SelectionLength = 0;
            this.txtUserPassword.SelectionStart = 0;
            this.txtUserPassword.ShortcutsEnabled = true;
            this.txtUserPassword.Size = new System.Drawing.Size(328, 23);
            this.txtUserPassword.TabIndex = 4;
            this.txtUserPassword.UseSelectable = true;
            this.txtUserPassword.WaterMark = "Пароль";
            this.txtUserPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.DisplayIcon = true;
            this.txtUserName.Icon = global::ITRSTool_Metro_UI.Properties.Resources.users;
            this.txtUserName.IconRight = true;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(16, 141);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PromptText = "Имя пользователя";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(328, 23);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMark = "Имя пользователя";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBaseName
            // 
            // 
            // 
            // 
            this.txtBaseName.CustomButton.Image = null;
            this.txtBaseName.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtBaseName.CustomButton.Name = "";
            this.txtBaseName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBaseName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBaseName.CustomButton.TabIndex = 1;
            this.txtBaseName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBaseName.CustomButton.UseSelectable = true;
            this.txtBaseName.CustomButton.Visible = false;
            this.txtBaseName.DisplayIcon = true;
            this.txtBaseName.Icon = global::ITRSTool_Metro_UI.Properties.Resources.settings;
            this.txtBaseName.IconRight = true;
            this.txtBaseName.Lines = new string[0];
            this.txtBaseName.Location = new System.Drawing.Point(16, 112);
            this.txtBaseName.MaxLength = 32767;
            this.txtBaseName.Name = "txtBaseName";
            this.txtBaseName.PasswordChar = '\0';
            this.txtBaseName.PromptText = "Название базы";
            this.txtBaseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBaseName.SelectedText = "";
            this.txtBaseName.SelectionLength = 0;
            this.txtBaseName.SelectionStart = 0;
            this.txtBaseName.ShortcutsEnabled = true;
            this.txtBaseName.Size = new System.Drawing.Size(328, 23);
            this.txtBaseName.TabIndex = 2;
            this.txtBaseName.UseSelectable = true;
            this.txtBaseName.WaterMark = "Название базы";
            this.txtBaseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBaseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPort
            // 
            // 
            // 
            // 
            this.txtPort.CustomButton.Image = null;
            this.txtPort.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtPort.CustomButton.Name = "";
            this.txtPort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPort.CustomButton.TabIndex = 1;
            this.txtPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPort.CustomButton.UseSelectable = true;
            this.txtPort.CustomButton.Visible = false;
            this.txtPort.DisplayIcon = true;
            this.txtPort.Icon = global::ITRSTool_Metro_UI.Properties.Resources.database;
            this.txtPort.IconRight = true;
            this.txtPort.Lines = new string[0];
            this.txtPort.Location = new System.Drawing.Point(16, 83);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.PromptText = "Порт СУБД";
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.ShortcutsEnabled = true;
            this.txtPort.Size = new System.Drawing.Size(328, 23);
            this.txtPort.TabIndex = 1;
            this.txtPort.UseSelectable = true;
            this.txtPort.WaterMark = "Порт СУБД";
            this.txtPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtServer
            // 
            // 
            // 
            // 
            this.txtServer.CustomButton.Image = null;
            this.txtServer.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtServer.CustomButton.Name = "";
            this.txtServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServer.CustomButton.TabIndex = 1;
            this.txtServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServer.CustomButton.UseSelectable = true;
            this.txtServer.CustomButton.Visible = false;
            this.txtServer.DisplayIcon = true;
            this.txtServer.Icon = global::ITRSTool_Metro_UI.Properties.Resources.database;
            this.txtServer.IconRight = true;
            this.txtServer.Lines = new string[0];
            this.txtServer.Location = new System.Drawing.Point(16, 54);
            this.txtServer.MaxLength = 32767;
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.PromptText = "Сервер СУБД";
            this.txtServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServer.SelectedText = "";
            this.txtServer.SelectionLength = 0;
            this.txtServer.SelectionStart = 0;
            this.txtServer.ShortcutsEnabled = true;
            this.txtServer.Size = new System.Drawing.Size(328, 23);
            this.txtServer.TabIndex = 0;
            this.txtServer.UseSelectable = true;
            this.txtServer.WaterMark = "Сервер СУБД";
            this.txtServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileBaseConnector
            // 
            this.tileBaseConnector.ActiveControl = null;
            this.tileBaseConnector.Location = new System.Drawing.Point(3, 3);
            this.tileBaseConnector.Name = "tileBaseConnector";
            this.tileBaseConnector.Size = new System.Drawing.Size(175, 35);
            this.tileBaseConnector.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileBaseConnector.TabIndex = 1;
            this.tileBaseConnector.Text = "Настройка подключения";
            this.tileBaseConnector.UseSelectable = true;
            this.tileBaseConnector.Click += new System.EventHandler(this.tileBaseConnector_Click);
            // 
            // tileRecoveryBase
            // 
            this.tileRecoveryBase.ActiveControl = null;
            this.tileRecoveryBase.Location = new System.Drawing.Point(3, 40);
            this.tileRecoveryBase.Name = "tileRecoveryBase";
            this.tileRecoveryBase.Size = new System.Drawing.Size(175, 35);
            this.tileRecoveryBase.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileRecoveryBase.TabIndex = 2;
            this.tileRecoveryBase.Text = "Восстановление СУБД";
            this.tileRecoveryBase.UseSelectable = true;
            this.tileRecoveryBase.Click += new System.EventHandler(this.tileRecoveryBase_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.tileBackupBase);
            this.metroPanel2.Controls.Add(this.tileRecoveryBase);
            this.metroPanel2.Controls.Add(this.tileBaseConnector);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(1, 50);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(181, 115);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // tileBackupBase
            // 
            this.tileBackupBase.ActiveControl = null;
            this.tileBackupBase.Location = new System.Drawing.Point(3, 77);
            this.tileBackupBase.Name = "tileBackupBase";
            this.tileBackupBase.Size = new System.Drawing.Size(175, 35);
            this.tileBackupBase.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileBackupBase.TabIndex = 2;
            this.tileBackupBase.Text = "Резервная копия СУБД";
            this.tileBackupBase.UseSelectable = true;
            this.tileBackupBase.Click += new System.EventHandler(this.tileBackupBase_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(16, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(453, 40);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "При наличии файла options.ini, поля ниже заполняются автоматически при загрузке ф" +
    "ормы";
            this.metroLabel1.WrapToLine = true;
            // 
            // AppConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 320);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.panBaseConnector);
            this.MaximizeBox = false;
            this.Name = "AppConfig";
            this.Resizable = false;
            this.Text = "Конфигурирование приложения";
            this.Load += new System.EventHandler(this.AppConfig_Load);
            this.panBaseConnector.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panBaseConnector;
        private MetroFramework.Controls.MetroTextBox txtServer;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtUserPassword;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroTextBox txtBaseName;
        private MetroFramework.Controls.MetroTile tileBaseConnector;
        private MetroFramework.Controls.MetroTile tileRecoveryBase;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile tileBackupBase;
        private MetroFramework.Controls.MetroTile tileCheckBaseConnect;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}