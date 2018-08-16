namespace ITRSTool_Metro_UI
{
    partial class ErrorView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorView));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tilErrorViewCancel = new MetroFramework.Controls.MetroTile();
            this.tilErrorViewAccept = new MetroFramework.Controls.MetroTile();
            this.grdErrorView = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdErrorView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.tilErrorViewCancel);
            this.metroPanel1.Controls.Add(this.tilErrorViewAccept);
            this.metroPanel1.Controls.Add(this.grdErrorView);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 54);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(754, 360);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 325);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Visible = false;
            // 
            // tilErrorViewCancel
            // 
            this.tilErrorViewCancel.ActiveControl = null;
            this.tilErrorViewCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tilErrorViewCancel.Location = new System.Drawing.Point(681, 325);
            this.tilErrorViewCancel.Name = "tilErrorViewCancel";
            this.tilErrorViewCancel.Size = new System.Drawing.Size(32, 32);
            this.tilErrorViewCancel.Style = MetroFramework.MetroColorStyle.White;
            this.tilErrorViewCancel.TabIndex = 1;
            this.tilErrorViewCancel.TileImage = global::ITRSTool_Metro_UI.Properties.Resources.Error;
            this.tilErrorViewCancel.UseSelectable = true;
            this.tilErrorViewCancel.UseTileImage = true;
            this.tilErrorViewCancel.Click += new System.EventHandler(this.tilErrorViewCancel_Click);
            // 
            // tilErrorViewAccept
            // 
            this.tilErrorViewAccept.ActiveControl = null;
            this.tilErrorViewAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.tilErrorViewAccept.Location = new System.Drawing.Point(719, 325);
            this.tilErrorViewAccept.Name = "tilErrorViewAccept";
            this.tilErrorViewAccept.Size = new System.Drawing.Size(32, 32);
            this.tilErrorViewAccept.Style = MetroFramework.MetroColorStyle.White;
            this.tilErrorViewAccept.TabIndex = 1;
            this.tilErrorViewAccept.TileImage = global::ITRSTool_Metro_UI.Properties.Resources.Valid;
            this.tilErrorViewAccept.UseSelectable = true;
            this.tilErrorViewAccept.UseTileImage = true;
            this.tilErrorViewAccept.Click += new System.EventHandler(this.tilErrorViewAccept_Click);
            // 
            // grdErrorView
            // 
            this.grdErrorView.AllowUserToAddRows = false;
            this.grdErrorView.AllowUserToDeleteRows = false;
            this.grdErrorView.AllowUserToResizeColumns = false;
            this.grdErrorView.AllowUserToResizeRows = false;
            this.grdErrorView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdErrorView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdErrorView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdErrorView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdErrorView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdErrorView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdErrorView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdErrorView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdErrorView.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdErrorView.EnableHeadersVisualStyles = false;
            this.grdErrorView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdErrorView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdErrorView.Location = new System.Drawing.Point(3, 3);
            this.grdErrorView.Name = "grdErrorView";
            this.grdErrorView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdErrorView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdErrorView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdErrorView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdErrorView.Size = new System.Drawing.Size(748, 301);
            this.grdErrorView.TabIndex = 2;
            // 
            // ErrorView
            // 
            this.AcceptButton = this.tilErrorViewAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.tilErrorViewCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorView";
            this.Resizable = false;
            this.Text = "Просмотр";
            this.Load += new System.EventHandler(this.ErrorView_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdErrorView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid grdErrorView;
        private MetroFramework.Controls.MetroTile tilErrorViewCancel;
        private MetroFramework.Controls.MetroTile tilErrorViewAccept;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}