using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
namespace ITRSTool_Metro_UI
{
    public partial class ErrorView : MetroFramework.Forms.MetroForm
    {
        public ErrorView(string ErrorString)
        {
            InitializeComponent();
            metroLabel1.Text = ErrorString;
            this.tilErrorViewAccept.DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void ErrorView_Load(object sender, EventArgs e)
        {
            
            ToolTip ToolTipPrihod = new ToolTip();
            ToolTipPrihod.SetToolTip(tilErrorViewAccept, "Подтвердить!");
            ToolTipPrihod.SetToolTip(tilErrorViewCancel, "Отменить");
            DataTable dt = new DataTable();
            dt = DB.sql_select_dataset(metroLabel1.Text);
            grdErrorView.DataSource = dt;
            
        }

        private void tilErrorViewAccept_Click(object sender, EventArgs e)
        {

        }

        private void tilErrorViewCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
