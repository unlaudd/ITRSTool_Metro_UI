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
        }

        private void ErrorView_Load(object sender, EventArgs e)
        {
            
            ToolTip ToolTipPrihod = new ToolTip();
            ToolTipPrihod.SetToolTip(tilErrorViewAccept, "Подтвердить!");
            ToolTipPrihod.SetToolTip(tilErrorViewCancel, "Отменить");

        }
    }
}
