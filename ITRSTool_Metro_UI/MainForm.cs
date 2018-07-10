using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITRSTool_Metro_UI
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm(string UserInfo, string GroupInfo)
        {
            InitializeComponent();
            // Выводим имя пользователя и группу на главной форме.
            lblLoginName.Text = UserInfo;
            lblGroup.Text = GroupInfo;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void запчастиДляТСДToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
