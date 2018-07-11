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
                MetroFramework.MetroMessageBox.Show(this, "Необходимо ввести имя пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
                return;
            }

            //Проверяем на заполнение поле логина. Если пусто, выводим сообщение, ставим фокус в поле.
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо ввести пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }

            // Проверяем на валидность без подключения к СУБД технического пользователя.
            // Необходимо на случай миграции СУБД на другие IP адреса и т.п.
            // Если пользователь валиден, открываем окно настроек.

            if (txtLogin.Text == "enginer" & txtPass.Text == "MyPass0101")
            {
                Hide();
                AppConfig appconfig = new AppConfig();
                appconfig.ShowDialog();
                this.Close();
            }
            // Коннектимся к СУБД, используя класс.

            try
            {
                if (System.IO.File.Exists("options.ini"))
                {

                    string[] param = Crypto.en_ex().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    string serv = param[0].ToString();
                    string port = param[1].ToString();
                    string bases = param[2].ToString();
                    string user = param[3].ToString();
                    string password = param[4].ToString();
                    
                    DB.Connector = "server=" + serv + ";user=" + user + ";database=" + bases + ";port=" + port + ";password=" + password + "; Character Set = utf8" + "; convert zero datetime = True" + "; SslMode=none;";
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Отсутствует файл настроек. Вход в программу невозможен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool CheckConnect = DB.DBConnectionStatus(DB.Connector);
                if (CheckConnect != false)
                {

                    // Проверяем соответствие на сочетание логина/пароля в СУБД. Если 0 - пользователь ввел не верные данные, если 1 - пользователь существует
                    string SqlUserTest = "SELECT COUNT(*) FROM tbl_login where Login = '" + txtLogin.Text + "' and Password = '" + encrypt_pass.GetHashString(txtPass.Text) + "'";
                    int prov = Convert.ToInt32(DB.Sql_Reader(SqlUserTest));


                    if (prov == 1)
                    {
                        if (chkRemember.Checked == true)
                        {
                            //Создаём или перезаписываем существующий файл
                            string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
                            path += "\\Local\\Temp\\last_login.tmp";
                            FileIO.saveAsOwnTextFormat(path, txtLogin.Text);
                        }
                        // Пользователь существует - получаем группу доступа
                        string SqlUserGroup = "SELECT ref_group.GroupName from tbl_login INNER join ref_group on ref_group.id=tbl_login.`Group` where login = '" + txtLogin.Text + "'  LIMIT 1";
                        string group = DB.Sql_Reader(SqlUserGroup);
                        // Открываем основную форму. Передаем ей значение имя пользователя и группы.
                        Hide();
                        MainForm mainform = new MainForm(string.Format(txtLogin.Text), string.Format(group));
                        mainform.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Пользователь заблокирован или запись отсутствует. Проверьте введенные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Нет соединения с СУБД. Проверьте настройки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Данные в файле настроек повреждены. Необходимо пересоздать файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            { 
            // Получаем системную папку пользователя.
            string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            // Открываем файл с "Запомнить меня" логином
            StreamReader sr = new StreamReader("" + path + "\\Local\\Temp\\last_login.tmp", Encoding.Default);
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
