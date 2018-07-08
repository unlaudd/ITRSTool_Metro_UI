using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //Проверяем на заполнение поле логина. Если пусто, выводим сообщение, ставим фокус в поле.
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("Необходимо ввести имя пользователя!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
                return;
            }

            //Проверяем на заполнение поле логина. Если пусто, выводим сообщение, ставим фокус в поле.
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Необходимо ввести пароль!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }

            // Проверяем на валидность без подключения к СУБД технического пользователя.
            // Необходимо на случай миграции СУБД на другие IP адреса и т.п.
            // Если пользователь валиден, открываем окно настроек.

            if (txtLogin.Text == "thechnic" & txtPass.Text == "Htubjy0101")
            {
                Hide();
                AppConfig appconfig = new AppConfig();
                appconfig.ShowDialog();
                this.Close();
            }
            // Открываем файл с настройками коннекта к СУБД




            
            // Если Запомнить меня валидно
            if (chkRemember.Checked == true)
            {
                try
                {
                    //Создаём или перезаписываем существующий файл
                    string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
                    path += "\\Local\\Temp\\last_login.tmp";
                    FileIO.saveAsOwnTextFormat(path, txtLogin.Text);

                }
                catch (Exception ex) //Хэндлим ошибки
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            Hide();
            MainForm mainform = new MainForm();
            mainform.ShowDialog();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            { 
            // Получаем системную папку пользователя.
            string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            // Открываем файл с "Запомнить меня" логином
            System.IO.StreamReader sr = new System.IO.StreamReader("" + path + "\\Local\\Temp\\last_login.tmp", Encoding.Default);
            string line = null;
            while ((line = sr.ReadLine()) != null)
            {
                txtLogin.Text = line;
            }
            sr.Close();
            }
            catch (Exception ex)
            {
                    txtLogin.Text = "";
            }
}
    }
}
