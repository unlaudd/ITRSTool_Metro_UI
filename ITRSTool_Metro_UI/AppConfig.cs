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
    public partial class AppConfig : MetroFramework.Forms.MetroForm
    {
        public AppConfig()
        {
            InitializeComponent();
        }

        private void AppConfig_Load(object sender, EventArgs e)
        {
            try
            {
                // Проверяем наличие файла с настройками программы. Если файл найден - загружаем.
                if (System.IO.File.Exists("options.ini"))
                {
                    string[] param = Crypto.en_ex().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    txtServer.Text = param[0].ToString();
                    txtPort.Text = param[1].ToString();
                    txtBaseName.Text = param[2].ToString();
                    txtUserName.Text = param[3].ToString();
                    txtUserPassword.Text = param[4].ToString();
                }
                else
                {
                    
                }
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Данные в файле настроек повреждены. Необходимо пересоздать файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Кнопка очистки
            txtBaseName.Text = "";
            txtPort.Text = "";
            txtServer.Text = "";
            txtUserName.Text = "";
            txtUserPassword.Text = "";
        }

        private void tileCheckBaseConnect_Click(object sender, EventArgs e)
        {
            // Проверка соединения с базой.
            try
            {
                string CheckConnectString = "server=" + txtServer.Text + ";user=" + txtUserName.Text + ";database=" + txtBaseName.Text + ";port=" + txtPort.Text + ";password=" + txtUserPassword.Text + "; Character Set = utf8" + "; convert zero datetime = True" + "; SslMode=none;";
                bool CheckConnect = DB.DBConnectionStatus(CheckConnectString);
                if (CheckConnect != false)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Соединение установлено", "Проверка соединения", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Не удается установить соединение с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Перед записью в файл проверяем наличие соединения с СУБД. Если все ок - пишем. В противном случае выводим сообщение.
                string CheckConnectString = "server=" + txtServer.Text + ";user=" + txtUserName.Text + ";database=" + txtBaseName.Text + ";port=" + txtPort.Text + ";password=" + txtUserPassword.Text + "; Character Set = utf8" + "; convert zero datetime = True" + "; SslMode=none;";
                bool CheckConnect = DB.DBConnectionStatus(CheckConnectString);
                
                if (CheckConnect != false)
                {
                    string serv = txtServer.Text.ToString();
                    string port = txtPort.Text.ToString();
                    string bases = txtBaseName.Text.ToString();
                    string login = txtUserName.Text.ToString();
                    string pass = txtUserPassword.Text.ToString();
                    string objToSave = serv + ";" + port + ";" + bases + ";" + login + ";" + pass + ";";
                    // Сохраняем файл криптуя его.
                    Crypto.en_to(objToSave);
                    MetroFramework.MetroMessageBox.Show(this, "Данные сохранены", "Сохранение информации", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Не удается установить соединение с сервером.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tileBaseConnector_Click(object sender, EventArgs e)
        {
            panBaseConnector.Show();
        }

        private void tileRecoveryBase_Click(object sender, EventArgs e)
        {
            panBaseConnector.Hide();
        }

        private void tileBackupBase_Click(object sender, EventArgs e)
        {
            panBaseConnector.Hide();
        }
    }
}
