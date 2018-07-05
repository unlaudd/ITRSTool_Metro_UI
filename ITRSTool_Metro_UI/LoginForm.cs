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
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Действие - Закрытие приложения на кнопку Отмена
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Прячем форму логина
            Hide();
            // Передаем управление основной форме
            MainForm ss = new MainForm();
            ss.ShowDialog();
            // Закрываем форму логина
            this.Close();

        }
    }
}
