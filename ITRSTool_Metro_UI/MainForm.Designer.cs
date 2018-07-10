namespace ITRSTool_Metro_UI
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ремонтыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паяльныеРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бухУчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.админкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLoginName = new MetroFramework.Controls.MetroLabel();
            this.lblGroup = new MetroFramework.Controls.MetroLabel();
            this.panPrihod = new MetroFramework.Controls.MetroPanel();
            this.запчастиДляТСДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходкаДляПайкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пересылкаПоСкладамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тСДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интерфейсныеКабелиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интерфейсныеКабелиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.запчастиДляТСДToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ввводНомераНакладнойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridPrihod = new MetroFramework.Controls.MetroGrid();
            this.clmNameInBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameInInvoce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateInvoce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumInvoce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrihodSPartsInDelivery = new MetroFramework.Controls.MetroTextBox();
            this.cmbPrihodSpareParts = new MetroFramework.Controls.MetroComboBox();
            this.lblPrihodSpareParts = new MetroFramework.Controls.MetroLabel();
            this.datPrihodDelivery = new MetroFramework.Controls.MetroDateTime();
            this.lblPrihodSPartsInDelivery = new MetroFramework.Controls.MetroLabel();
            this.lblPrihodDelivery = new MetroFramework.Controls.MetroLabel();
            this.lblPrihodNumDelivery = new MetroFramework.Controls.MetroLabel();
            this.txtPrihodNumDelivery = new MetroFramework.Controls.MetroTextBox();
            this.lblPrihodAnountDelivery = new MetroFramework.Controls.MetroLabel();
            this.txtPrihodAnountDelivery = new MetroFramework.Controls.MetroTextBox();
            this.txtPrihodCostDelivery = new MetroFramework.Controls.MetroTextBox();
            this.lblPrihodCostDelivery = new MetroFramework.Controls.MetroLabel();
            this.tilPrihodAddInBase = new MetroFramework.Controls.MetroTile();
            this.tilPrihodAddInGrid = new MetroFramework.Controls.MetroTile();
            this.tilPrihodCancelInGrid = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panPrihod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrihod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.приходToolStripMenuItem,
            this.ремонтыToolStripMenuItem,
            this.паяльныеРаботыToolStripMenuItem,
            this.отправкаToolStripMenuItem,
            this.бухУчетToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.админкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // приходToolStripMenuItem
            // 
            this.приходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запчастиДляТСДToolStripMenuItem,
            this.расходкаДляПайкиToolStripMenuItem,
            this.пересылкаПоСкладамToolStripMenuItem});
            this.приходToolStripMenuItem.Name = "приходToolStripMenuItem";
            this.приходToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.приходToolStripMenuItem.Text = "Приход";
            // 
            // ремонтыToolStripMenuItem
            // 
            this.ремонтыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тСДToolStripMenuItem});
            this.ремонтыToolStripMenuItem.Name = "ремонтыToolStripMenuItem";
            this.ремонтыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ремонтыToolStripMenuItem.Text = "Ремонты";
            // 
            // паяльныеРаботыToolStripMenuItem
            // 
            this.паяльныеРаботыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.интерфейсныеКабелиToolStripMenuItem});
            this.паяльныеРаботыToolStripMenuItem.Name = "паяльныеРаботыToolStripMenuItem";
            this.паяльныеРаботыToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.паяльныеРаботыToolStripMenuItem.Text = "Паяльные работы";
            // 
            // бухУчетToolStripMenuItem
            // 
            this.бухУчетToolStripMenuItem.Name = "бухУчетToolStripMenuItem";
            this.бухУчетToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.бухУчетToolStripMenuItem.Text = "Бух. учет";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // админкаToolStripMenuItem
            // 
            this.админкаToolStripMenuItem.Name = "админкаToolStripMenuItem";
            this.админкаToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.админкаToolStripMenuItem.Text = "Админка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(232, 32);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(83, 19);
            this.lblLoginName.TabIndex = 2;
            this.lblLoginName.Text = "Login_Name";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(432, 32);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(78, 19);
            this.lblGroup.TabIndex = 4;
            this.lblGroup.Text = "User_Group";
            // 
            // panPrihod
            // 
            this.panPrihod.Controls.Add(this.tilPrihodAddInGrid);
            this.panPrihod.Controls.Add(this.tilPrihodCancelInGrid);
            this.panPrihod.Controls.Add(this.tilPrihodAddInBase);
            this.panPrihod.Controls.Add(this.lblPrihodCostDelivery);
            this.panPrihod.Controls.Add(this.txtPrihodCostDelivery);
            this.panPrihod.Controls.Add(this.txtPrihodAnountDelivery);
            this.panPrihod.Controls.Add(this.lblPrihodAnountDelivery);
            this.panPrihod.Controls.Add(this.txtPrihodNumDelivery);
            this.panPrihod.Controls.Add(this.lblPrihodNumDelivery);
            this.panPrihod.Controls.Add(this.lblPrihodDelivery);
            this.panPrihod.Controls.Add(this.lblPrihodSPartsInDelivery);
            this.panPrihod.Controls.Add(this.datPrihodDelivery);
            this.panPrihod.Controls.Add(this.lblPrihodSpareParts);
            this.panPrihod.Controls.Add(this.cmbPrihodSpareParts);
            this.panPrihod.Controls.Add(this.txtPrihodSPartsInDelivery);
            this.panPrihod.Controls.Add(this.gridPrihod);
            this.panPrihod.HorizontalScrollbarBarColor = true;
            this.panPrihod.HorizontalScrollbarHighlightOnWheel = false;
            this.panPrihod.HorizontalScrollbarSize = 10;
            this.panPrihod.Location = new System.Drawing.Point(20, 87);
            this.panPrihod.Name = "panPrihod";
            this.panPrihod.Size = new System.Drawing.Size(1064, 440);
            this.panPrihod.TabIndex = 7;
            this.panPrihod.VerticalScrollbarBarColor = true;
            this.panPrihod.VerticalScrollbarHighlightOnWheel = false;
            this.panPrihod.VerticalScrollbarSize = 10;
            // 
            // запчастиДляТСДToolStripMenuItem
            // 
            this.запчастиДляТСДToolStripMenuItem.Name = "запчастиДляТСДToolStripMenuItem";
            this.запчастиДляТСДToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.запчастиДляТСДToolStripMenuItem.Text = "Запчасти для ТСД";
            this.запчастиДляТСДToolStripMenuItem.Click += new System.EventHandler(this.запчастиДляТСДToolStripMenuItem_Click);
            // 
            // расходкаДляПайкиToolStripMenuItem
            // 
            this.расходкаДляПайкиToolStripMenuItem.Name = "расходкаДляПайкиToolStripMenuItem";
            this.расходкаДляПайкиToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.расходкаДляПайкиToolStripMenuItem.Text = "Расходка для пайки";
            // 
            // пересылкаПоСкладамToolStripMenuItem
            // 
            this.пересылкаПоСкладамToolStripMenuItem.Name = "пересылкаПоСкладамToolStripMenuItem";
            this.пересылкаПоСкладамToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.пересылкаПоСкладамToolStripMenuItem.Text = "Пересылка по складам";
            // 
            // тСДToolStripMenuItem
            // 
            this.тСДToolStripMenuItem.Name = "тСДToolStripMenuItem";
            this.тСДToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.тСДToolStripMenuItem.Text = "ТСД";
            // 
            // интерфейсныеКабелиToolStripMenuItem
            // 
            this.интерфейсныеКабелиToolStripMenuItem.Name = "интерфейсныеКабелиToolStripMenuItem";
            this.интерфейсныеКабелиToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.интерфейсныеКабелиToolStripMenuItem.Text = "Интерфейсные кабели";
            // 
            // отправкаToolStripMenuItem
            // 
            this.отправкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.интерфейсныеКабелиToolStripMenuItem1,
            this.запчастиДляТСДToolStripMenuItem1,
            this.ввводНомераНакладнойToolStripMenuItem});
            this.отправкаToolStripMenuItem.Name = "отправкаToolStripMenuItem";
            this.отправкаToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.отправкаToolStripMenuItem.Text = "Отправка";
            // 
            // интерфейсныеКабелиToolStripMenuItem1
            // 
            this.интерфейсныеКабелиToolStripMenuItem1.Name = "интерфейсныеКабелиToolStripMenuItem1";
            this.интерфейсныеКабелиToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.интерфейсныеКабелиToolStripMenuItem1.Text = "Интерфейсные кабели";
            // 
            // запчастиДляТСДToolStripMenuItem1
            // 
            this.запчастиДляТСДToolStripMenuItem1.Name = "запчастиДляТСДToolStripMenuItem1";
            this.запчастиДляТСДToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.запчастиДляТСДToolStripMenuItem1.Text = "Запчасти для ТСД";
            // 
            // ввводНомераНакладнойToolStripMenuItem
            // 
            this.ввводНомераНакладнойToolStripMenuItem.Name = "ввводНомераНакладнойToolStripMenuItem";
            this.ввводНомераНакладнойToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ввводНомераНакладнойToolStripMenuItem.Text = "Вввод номера накладной";
            // 
            // gridPrihod
            // 
            this.gridPrihod.AllowUserToResizeRows = false;
            this.gridPrihod.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPrihod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPrihod.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPrihod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPrihod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridPrihod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrihod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNameInBase,
            this.clmNameInInvoce,
            this.clmDateInvoce,
            this.clmNumInvoce,
            this.clmAmount,
            this.clmCost});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPrihod.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridPrihod.EnableHeadersVisualStyles = false;
            this.gridPrihod.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPrihod.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPrihod.Location = new System.Drawing.Point(233, 3);
            this.gridPrihod.Name = "gridPrihod";
            this.gridPrihod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPrihod.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridPrihod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPrihod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPrihod.Size = new System.Drawing.Size(819, 368);
            this.gridPrihod.TabIndex = 2;
            // 
            // clmNameInBase
            // 
            this.clmNameInBase.HeaderText = "Запчасть по СУБД";
            this.clmNameInBase.Name = "clmNameInBase";
            // 
            // clmNameInInvoce
            // 
            this.clmNameInInvoce.HeaderText = "Запчасть по накладной";
            this.clmNameInInvoce.Name = "clmNameInInvoce";
            // 
            // clmDateInvoce
            // 
            this.clmDateInvoce.HeaderText = "Дата накладной";
            this.clmDateInvoce.Name = "clmDateInvoce";
            // 
            // clmNumInvoce
            // 
            this.clmNumInvoce.HeaderText = "Номер накладной";
            this.clmNumInvoce.Name = "clmNumInvoce";
            // 
            // clmAmount
            // 
            this.clmAmount.HeaderText = "Количество";
            this.clmAmount.Name = "clmAmount";
            // 
            // clmCost
            // 
            this.clmCost.HeaderText = "Стоимость";
            this.clmCost.Name = "clmCost";
            // 
            // txtPrihodSPartsInDelivery
            // 
            // 
            // 
            // 
            this.txtPrihodSPartsInDelivery.CustomButton.Image = null;
            this.txtPrihodSPartsInDelivery.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtPrihodSPartsInDelivery.CustomButton.Name = "";
            this.txtPrihodSPartsInDelivery.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrihodSPartsInDelivery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrihodSPartsInDelivery.CustomButton.TabIndex = 1;
            this.txtPrihodSPartsInDelivery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrihodSPartsInDelivery.CustomButton.UseSelectable = true;
            this.txtPrihodSPartsInDelivery.CustomButton.Visible = false;
            this.txtPrihodSPartsInDelivery.Lines = new string[0];
            this.txtPrihodSPartsInDelivery.Location = new System.Drawing.Point(3, 79);
            this.txtPrihodSPartsInDelivery.MaxLength = 32767;
            this.txtPrihodSPartsInDelivery.Name = "txtPrihodSPartsInDelivery";
            this.txtPrihodSPartsInDelivery.PasswordChar = '\0';
            this.txtPrihodSPartsInDelivery.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrihodSPartsInDelivery.SelectedText = "";
            this.txtPrihodSPartsInDelivery.SelectionLength = 0;
            this.txtPrihodSPartsInDelivery.SelectionStart = 0;
            this.txtPrihodSPartsInDelivery.ShortcutsEnabled = true;
            this.txtPrihodSPartsInDelivery.Size = new System.Drawing.Size(224, 23);
            this.txtPrihodSPartsInDelivery.TabIndex = 3;
            this.txtPrihodSPartsInDelivery.UseSelectable = true;
            this.txtPrihodSPartsInDelivery.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrihodSPartsInDelivery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbPrihodSpareParts
            // 
            this.cmbPrihodSpareParts.FormattingEnabled = true;
            this.cmbPrihodSpareParts.ItemHeight = 23;
            this.cmbPrihodSpareParts.Location = new System.Drawing.Point(3, 25);
            this.cmbPrihodSpareParts.Name = "cmbPrihodSpareParts";
            this.cmbPrihodSpareParts.Size = new System.Drawing.Size(224, 29);
            this.cmbPrihodSpareParts.TabIndex = 4;
            this.cmbPrihodSpareParts.UseSelectable = true;
            // 
            // lblPrihodSpareParts
            // 
            this.lblPrihodSpareParts.AutoSize = true;
            this.lblPrihodSpareParts.Location = new System.Drawing.Point(3, 3);
            this.lblPrihodSpareParts.Name = "lblPrihodSpareParts";
            this.lblPrihodSpareParts.Size = new System.Drawing.Size(125, 19);
            this.lblPrihodSpareParts.TabIndex = 5;
            this.lblPrihodSpareParts.Text = "Выберите запчасть";
            // 
            // datPrihodDelivery
            // 
            this.datPrihodDelivery.Location = new System.Drawing.Point(3, 127);
            this.datPrihodDelivery.MinimumSize = new System.Drawing.Size(0, 29);
            this.datPrihodDelivery.Name = "datPrihodDelivery";
            this.datPrihodDelivery.Size = new System.Drawing.Size(224, 29);
            this.datPrihodDelivery.TabIndex = 6;
            // 
            // lblPrihodSPartsInDelivery
            // 
            this.lblPrihodSPartsInDelivery.AutoSize = true;
            this.lblPrihodSPartsInDelivery.Location = new System.Drawing.Point(3, 57);
            this.lblPrihodSPartsInDelivery.Name = "lblPrihodSPartsInDelivery";
            this.lblPrihodSPartsInDelivery.Size = new System.Drawing.Size(153, 19);
            this.lblPrihodSPartsInDelivery.TabIndex = 7;
            this.lblPrihodSPartsInDelivery.Text = "Запчасть по накладной";
            // 
            // lblPrihodDelivery
            // 
            this.lblPrihodDelivery.AutoSize = true;
            this.lblPrihodDelivery.Location = new System.Drawing.Point(3, 105);
            this.lblPrihodDelivery.Name = "lblPrihodDelivery";
            this.lblPrihodDelivery.Size = new System.Drawing.Size(107, 19);
            this.lblPrihodDelivery.TabIndex = 8;
            this.lblPrihodDelivery.Text = "Дата накладной";
            // 
            // lblPrihodNumDelivery
            // 
            this.lblPrihodNumDelivery.AutoSize = true;
            this.lblPrihodNumDelivery.Location = new System.Drawing.Point(3, 159);
            this.lblPrihodNumDelivery.Name = "lblPrihodNumDelivery";
            this.lblPrihodNumDelivery.Size = new System.Drawing.Size(120, 19);
            this.lblPrihodNumDelivery.TabIndex = 9;
            this.lblPrihodNumDelivery.Text = "Номер накладной";
            // 
            // txtPrihodNumDelivery
            // 
            // 
            // 
            // 
            this.txtPrihodNumDelivery.CustomButton.Image = null;
            this.txtPrihodNumDelivery.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtPrihodNumDelivery.CustomButton.Name = "";
            this.txtPrihodNumDelivery.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrihodNumDelivery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrihodNumDelivery.CustomButton.TabIndex = 1;
            this.txtPrihodNumDelivery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrihodNumDelivery.CustomButton.UseSelectable = true;
            this.txtPrihodNumDelivery.CustomButton.Visible = false;
            this.txtPrihodNumDelivery.Lines = new string[0];
            this.txtPrihodNumDelivery.Location = new System.Drawing.Point(3, 181);
            this.txtPrihodNumDelivery.MaxLength = 32767;
            this.txtPrihodNumDelivery.Name = "txtPrihodNumDelivery";
            this.txtPrihodNumDelivery.PasswordChar = '\0';
            this.txtPrihodNumDelivery.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrihodNumDelivery.SelectedText = "";
            this.txtPrihodNumDelivery.SelectionLength = 0;
            this.txtPrihodNumDelivery.SelectionStart = 0;
            this.txtPrihodNumDelivery.ShortcutsEnabled = true;
            this.txtPrihodNumDelivery.Size = new System.Drawing.Size(224, 23);
            this.txtPrihodNumDelivery.TabIndex = 10;
            this.txtPrihodNumDelivery.UseSelectable = true;
            this.txtPrihodNumDelivery.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrihodNumDelivery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPrihodAnountDelivery
            // 
            this.lblPrihodAnountDelivery.AutoSize = true;
            this.lblPrihodAnountDelivery.Location = new System.Drawing.Point(3, 207);
            this.lblPrihodAnountDelivery.Name = "lblPrihodAnountDelivery";
            this.lblPrihodAnountDelivery.Size = new System.Drawing.Size(79, 19);
            this.lblPrihodAnountDelivery.TabIndex = 11;
            this.lblPrihodAnountDelivery.Text = "Количество";
            // 
            // txtPrihodAnountDelivery
            // 
            // 
            // 
            // 
            this.txtPrihodAnountDelivery.CustomButton.Image = null;
            this.txtPrihodAnountDelivery.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtPrihodAnountDelivery.CustomButton.Name = "";
            this.txtPrihodAnountDelivery.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrihodAnountDelivery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrihodAnountDelivery.CustomButton.TabIndex = 1;
            this.txtPrihodAnountDelivery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrihodAnountDelivery.CustomButton.UseSelectable = true;
            this.txtPrihodAnountDelivery.CustomButton.Visible = false;
            this.txtPrihodAnountDelivery.Lines = new string[0];
            this.txtPrihodAnountDelivery.Location = new System.Drawing.Point(3, 229);
            this.txtPrihodAnountDelivery.MaxLength = 32767;
            this.txtPrihodAnountDelivery.Name = "txtPrihodAnountDelivery";
            this.txtPrihodAnountDelivery.PasswordChar = '\0';
            this.txtPrihodAnountDelivery.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrihodAnountDelivery.SelectedText = "";
            this.txtPrihodAnountDelivery.SelectionLength = 0;
            this.txtPrihodAnountDelivery.SelectionStart = 0;
            this.txtPrihodAnountDelivery.ShortcutsEnabled = true;
            this.txtPrihodAnountDelivery.Size = new System.Drawing.Size(224, 23);
            this.txtPrihodAnountDelivery.TabIndex = 12;
            this.txtPrihodAnountDelivery.UseSelectable = true;
            this.txtPrihodAnountDelivery.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrihodAnountDelivery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrihodCostDelivery
            // 
            // 
            // 
            // 
            this.txtPrihodCostDelivery.CustomButton.Image = null;
            this.txtPrihodCostDelivery.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtPrihodCostDelivery.CustomButton.Name = "";
            this.txtPrihodCostDelivery.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrihodCostDelivery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrihodCostDelivery.CustomButton.TabIndex = 1;
            this.txtPrihodCostDelivery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrihodCostDelivery.CustomButton.UseSelectable = true;
            this.txtPrihodCostDelivery.CustomButton.Visible = false;
            this.txtPrihodCostDelivery.Lines = new string[0];
            this.txtPrihodCostDelivery.Location = new System.Drawing.Point(3, 277);
            this.txtPrihodCostDelivery.MaxLength = 32767;
            this.txtPrihodCostDelivery.Name = "txtPrihodCostDelivery";
            this.txtPrihodCostDelivery.PasswordChar = '\0';
            this.txtPrihodCostDelivery.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrihodCostDelivery.SelectedText = "";
            this.txtPrihodCostDelivery.SelectionLength = 0;
            this.txtPrihodCostDelivery.SelectionStart = 0;
            this.txtPrihodCostDelivery.ShortcutsEnabled = true;
            this.txtPrihodCostDelivery.Size = new System.Drawing.Size(224, 23);
            this.txtPrihodCostDelivery.TabIndex = 13;
            this.txtPrihodCostDelivery.UseSelectable = true;
            this.txtPrihodCostDelivery.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrihodCostDelivery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPrihodCostDelivery
            // 
            this.lblPrihodCostDelivery.AutoSize = true;
            this.lblPrihodCostDelivery.Location = new System.Drawing.Point(3, 255);
            this.lblPrihodCostDelivery.Name = "lblPrihodCostDelivery";
            this.lblPrihodCostDelivery.Size = new System.Drawing.Size(73, 19);
            this.lblPrihodCostDelivery.TabIndex = 14;
            this.lblPrihodCostDelivery.Text = "Стоимость";
            // 
            // tilPrihodAddInBase
            // 
            this.tilPrihodAddInBase.ActiveControl = null;
            this.tilPrihodAddInBase.BackColor = System.Drawing.Color.Black;
            this.tilPrihodAddInBase.Location = new System.Drawing.Point(1021, 386);
            this.tilPrihodAddInBase.Name = "tilPrihodAddInBase";
            this.tilPrihodAddInBase.Size = new System.Drawing.Size(31, 31);
            this.tilPrihodAddInBase.Style = MetroFramework.MetroColorStyle.White;
            this.tilPrihodAddInBase.TabIndex = 15;
            this.tilPrihodAddInBase.Text = "metroTile1";
            this.tilPrihodAddInBase.TileImage = global::ITRSTool_Metro_UI.Properties.Resources.Valid;
            this.tilPrihodAddInBase.UseSelectable = true;
            this.tilPrihodAddInBase.UseTileImage = true;
            // 
            // tilPrihodAddInGrid
            // 
            this.tilPrihodAddInGrid.ActiveControl = null;
            this.tilPrihodAddInGrid.Location = new System.Drawing.Point(190, 306);
            this.tilPrihodAddInGrid.Name = "tilPrihodAddInGrid";
            this.tilPrihodAddInGrid.Size = new System.Drawing.Size(37, 34);
            this.tilPrihodAddInGrid.Style = MetroFramework.MetroColorStyle.White;
            this.tilPrihodAddInGrid.TabIndex = 17;
            this.tilPrihodAddInGrid.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tilPrihodAddInGrid.TileImage = global::ITRSTool_Metro_UI.Properties.Resources.Add;
            this.tilPrihodAddInGrid.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilPrihodAddInGrid.UseSelectable = true;
            this.tilPrihodAddInGrid.UseTileImage = true;
            // 
            // tilPrihodCancelInGrid
            // 
            this.tilPrihodCancelInGrid.ActiveControl = null;
            this.tilPrihodCancelInGrid.Location = new System.Drawing.Point(956, 386);
            this.tilPrihodCancelInGrid.Name = "tilPrihodCancelInGrid";
            this.tilPrihodCancelInGrid.Size = new System.Drawing.Size(31, 31);
            this.tilPrihodCancelInGrid.Style = MetroFramework.MetroColorStyle.White;
            this.tilPrihodCancelInGrid.TabIndex = 16;
            this.tilPrihodCancelInGrid.TileImage = global::ITRSTool_Metro_UI.Properties.Resources.Error;
            this.tilPrihodCancelInGrid.UseSelectable = true;
            this.tilPrihodCancelInGrid.UseTileImage = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ITRSTool_Metro_UI.Properties.Resources.administrator_small;
            this.pictureBox2.Location = new System.Drawing.Point(210, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ITRSTool_Metro_UI.Properties.Resources.cloud;
            this.pictureBox1.Location = new System.Drawing.Point(411, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 540);
            this.Controls.Add(this.panPrihod);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Основная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panPrihod.ResumeLayout(false);
            this.panPrihod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrihod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ремонтыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паяльныеРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бухУчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem админкаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblLoginName;
        private MetroFramework.Controls.MetroLabel lblGroup;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel panPrihod;
        private System.Windows.Forms.ToolStripMenuItem запчастиДляТСДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расходкаДляПайкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пересылкаПоСкладамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тСДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интерфейсныеКабелиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интерфейсныеКабелиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem запчастиДляТСДToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ввводНомераНакладнойToolStripMenuItem;
        private MetroFramework.Controls.MetroTile tilPrihodAddInGrid;
        private MetroFramework.Controls.MetroTile tilPrihodCancelInGrid;
        private MetroFramework.Controls.MetroTile tilPrihodAddInBase;
        private MetroFramework.Controls.MetroLabel lblPrihodCostDelivery;
        private MetroFramework.Controls.MetroTextBox txtPrihodCostDelivery;
        private MetroFramework.Controls.MetroTextBox txtPrihodAnountDelivery;
        private MetroFramework.Controls.MetroLabel lblPrihodAnountDelivery;
        private MetroFramework.Controls.MetroTextBox txtPrihodNumDelivery;
        private MetroFramework.Controls.MetroLabel lblPrihodNumDelivery;
        private MetroFramework.Controls.MetroLabel lblPrihodDelivery;
        private MetroFramework.Controls.MetroLabel lblPrihodSPartsInDelivery;
        private MetroFramework.Controls.MetroDateTime datPrihodDelivery;
        private MetroFramework.Controls.MetroLabel lblPrihodSpareParts;
        private MetroFramework.Controls.MetroComboBox cmbPrihodSpareParts;
        private MetroFramework.Controls.MetroTextBox txtPrihodSPartsInDelivery;
        private MetroFramework.Controls.MetroGrid gridPrihod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameInBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameInInvoce;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateInvoce;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumInvoce;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCost;
    }
}