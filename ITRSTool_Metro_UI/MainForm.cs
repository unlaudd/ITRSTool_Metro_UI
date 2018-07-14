using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

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
            panelOff();
            panPrihod.Location = new Point(20, 87);
            panPrihod.Show();
            panPrihod.Size = new Size(1064, 440);
            cmbPrihodSpareParts.Focus();
            ToolTip ToolTipPrihod = new ToolTip();
            ToolTipPrihod.SetToolTip(tilPrihodAddInGrid, "Добавить в таблицу");
            ToolTipPrihod.SetToolTip(tilPrihodCancelInGrid, "Удалить выделенные данные из таблицы");
            ToolTipPrihod.SetToolTip(tilPrihodAddInBase, "Сохранить все данные из таблицы");
            ToolTipPrihod.SetToolTip(tilPrihodCancel, "Закрыть форму без сохранения");
            datPrihodDelivery.Format = DateTimePickerFormat.Custom;
            datPrihodDelivery.CustomFormat = "yyyy-MM-dd";
            try
            {
                string SPartsSql = "select SPartName from ref_spart_pdt_etc";
                DataTable SPartsDataTable = new DataTable();
                SPartsDataTable = DB.sql_select_dataset(SPartsSql);
                cmbPrihodSpareParts.DataSource = SPartsDataTable;
                cmbPrihodSpareParts.DisplayMember = "SPartName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void panelOff()
        {
            panPrihod.Visible = false;
            panChangePass.Visible = false;
        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelOff();
            panChangePass.Location = new Point(20, 87);
            panChangePass.Show();
            panChangePass.Size = new Size(300, 130);
            txtChangePassFirst.Focus();
        }

        private void tilChangePassCancel_Click(object sender, EventArgs e)
        {
            txtChangePassFirst.Text = "";
            txtChangePassFirstConfirm.Text = "";
            panelOff();
        }

        private void tilChangePassAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtChangePassFirst.Text == txtChangePassFirstConfirm.Text)
                {
                    string ChangePassSql = "update tbl_login set Password = '" + encrypt_pass.GetHashString(txtChangePassFirst.Text) + "' Where tbl_login.Login ='" + lblLoginName.Text + "'";
                    DB.sql_update(ChangePassSql);
                    MetroFramework.MetroMessageBox.Show(this, "Пароль успешно изменен", "Смена пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtChangePassFirst.Text = "";
                    txtChangePassFirstConfirm.Text = "";
                    panelOff();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Введенные пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tilPrihodCancelInGrid_Click(object sender, EventArgs e)
        {
            if (gridPrihod.CurrentRow != null)
            {
                gridPrihod.Rows.Remove(gridPrihod.CurrentRow);
            }
        }
        public void addGridParam(string[] N, DataGridView Grid)
        {
            while (N.Length > Grid.ColumnCount)
            {
                Grid.Columns.Add("", "");
            }
           Grid.Rows.Add(N);
       }


        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }
            }
            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }

        private void tilPrihodAddInGrid_Click(object sender, EventArgs e)
        {
            // Загружаем данные с таблицы в DataTable
            DataTable dtCheckTable = new DataTable();
            dtCheckTable = GetDataTableFromDGV(gridPrihod);
            try
            {
                // Устанавливаем переменной формат даты
                string DateDelivery = datPrihodDelivery.Value.ToString("yyyy-MM-dd");

                // Проверяем на совпадение введенные данные с табличкой
                for (int i = 0; i < dtCheckTable.Rows.Count; i++)
                {
                    if (dtCheckTable.Rows[i][0].ToString() == cmbPrihodSpareParts.Text && dtCheckTable.Rows[i][1].ToString() == txtPrihodSPartsInDelivery.Text && dtCheckTable.Rows[i][2].ToString() == datPrihodDelivery.Text && dtCheckTable.Rows[i][3].ToString() == txtPrihodNumDelivery.Text && dtCheckTable.Rows[i][4].ToString() == txtPrihodAmountDelivery.Text && dtCheckTable.Rows[i][5].ToString() == txtPrihodCostDelivery.Text)
                    {

                        MetroFramework.MetroMessageBox.Show(this, "Запись уже существует в таблице. Проверьте ввод данных", "Внимание", MessageBoxButtons.OK);
                        return;
                    }

                }
                // Делаем проверку на пустые поля
                if (txtPrihodAmountDelivery.Text != "" && txtPrihodCostDelivery.Text != "" && txtPrihodNumDelivery.Text != "" && txtPrihodSPartsInDelivery.Text != "")
                {
                    // Проверяем поле стоимость на правильность ввода. Значение не отрицательное, double
                    if (Regex.IsMatch(txtPrihodCostDelivery.Text.ToString(), @"\A[0-9]{1,10}(?:[.,][0-9]{1,2})?\z"))
                    {
                        // Проверяем поле количество на правильность ввода. Первая цифра не может быть 0.
                        if (Regex.IsMatch(txtPrihodAmountDelivery.Text.ToString(), @"\A[1-9]{1}(?:[0-9]{1,10})?\z"))
                        {
                            // Запрос в СУБД на поиск совпадений по накладным
                            string SkladCheckSql = "select count(*) from tbl_prihod where tbl_prihod.`СonsNumber`= '" + txtPrihodNumDelivery.Text + "' and tbl_prihod.ConsDate = '" + datPrihodDelivery.Text + "' and sklad = (select SkladNum from tbl_sklad WHERE EngLogin = (select id from tbl_login where Login = '" + lblLoginName.Text + "') and NameAction = 1)";
                            int SkladCheck = Convert.ToInt32(DB.Sql_Reader(SkladCheckSql));
                            // Если данные найдены,то
                            if (SkladCheck == 1)
                            {
                                // Выдаем сообщение о найденных данных. В зависимости от действий....
                                if (MetroFramework.MetroMessageBox.Show(this, "Обнаружена одна или более запчастей по накладной. Вывести информацию?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                                {
                                    // Если выбрано да, то открываем форму и показываем данные, по которым найдено совпадение, передавая при этом строку SQL.
                                    string ErrorViewSql = "SELECT ref_spart_pdt_etc.SPartName AS 'Наименования запчасти по СУБД', NameInCons AS 'Наименование запчасти по накладной',Amount As 'Количество', UnitCost As 'Стоимость',tbl_prihod.`СonsNumber` AS 'Номер накладной', ConsDate As 'Дата накладной',   ref_sklad.NumSklad As 'Склад' from tbl_prihod inner join ref_spart_pdt_etc on ref_spart_pdt_etc.id = tbl_prihod.SparePart inner join ref_sklad on ref_sklad.id = tbl_prihod.Sklad where tbl_prihod.`СonsNumber` = '" + txtPrihodNumDelivery.Text + "' and ConsDate = '" + datPrihodDelivery.Text + "'";
                                    ErrorView ErrorForm = new ErrorView(string.Format(ErrorViewSql));
                                    ErrorForm.ShowDialog();
                                    // В зависимости от нажатых кнопок на форме делаем действия
                                    if (ErrorForm.DialogResult == DialogResult.OK)
                                    {
                                        // При нажатии на кнопку ок, добавляем данные в табличку и очищаем все поля ввода.
                                        string[] strokaEshe = { cmbPrihodSpareParts.Text, txtPrihodSPartsInDelivery.Text, DateDelivery, txtPrihodNumDelivery.Text, txtPrihodAmountDelivery.Text, txtPrihodCostDelivery.Text };
                                        addGridParam(strokaEshe, gridPrihod);
                                        txtPrihodAmountDelivery.Text = "";
                                        txtPrihodCostDelivery.Text = "";
                                        if (chkBoxPrihodMulti.Checked)
                                        {
                                            txtPrihodNumDelivery.Text = "";
                                            txtPrihodSPartsInDelivery.Text = "";
                                        }
                                        else
                                        {
                                            txtPrihodNumDelivery.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        // При нажатии на отмену, очищаем все поля ввода и выходим из выполнения.
                                        if (chkBoxPrihodMulti.Checked)
                                        {
                                        txtPrihodAmountDelivery.Text = "";
                                        txtPrihodCostDelivery.Text = "";
                                        txtPrihodSPartsInDelivery.Text = "";
                                        return;
                                        }
                                        else
                                        {
                                            txtPrihodNumDelivery.Text = "";
                                        }
                                    }
                                }
                                else
                                {
                                    // Если при выборе просмотра совпадений на складе выбрано cancel, то добавляем данные в табличку и чистим поля ввода.
                                    string[] strokaEshe = { cmbPrihodSpareParts.Text, txtPrihodSPartsInDelivery.Text, DateDelivery, txtPrihodNumDelivery.Text, txtPrihodAmountDelivery.Text, txtPrihodCostDelivery.Text };
                                    addGridParam(strokaEshe, gridPrihod);
                                    if (chkBoxPrihodMulti.Checked)
                                    {
                                    txtPrihodAmountDelivery.Text = "";
                                    txtPrihodCostDelivery.Text = "";
                                    txtPrihodSPartsInDelivery.Text = "";
                                    }
                                    else
                                    {
                                        txtPrihodNumDelivery.Text = "";
                                    }
                                }
                            }

                            else
                            {
                                // Если не обнаружено совпадений по накладной, то добавляем данные в табличку и чистим поля ввода.
                                string[] strokaEshe = { cmbPrihodSpareParts.Text, txtPrihodSPartsInDelivery.Text, DateDelivery, txtPrihodNumDelivery.Text, txtPrihodAmountDelivery.Text, txtPrihodCostDelivery.Text };
                                addGridParam(strokaEshe, gridPrihod);
                                if (chkBoxPrihodMulti.Checked)
                                {
                                txtPrihodAmountDelivery.Text = "";
                                txtPrihodCostDelivery.Text = "";
                                txtPrihodSPartsInDelivery.Text = "";
                                }
                                else
                                {
                                    txtPrihodNumDelivery.Text = "";
                                }
                            }
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Не верно заполено поле Количество. Данные не добавлены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPrihodAmountDelivery.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Не верно заполено поле Стоимость. Данные не добавлены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPrihodCostDelivery.Focus();
                        return;
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Не заполнено одно или несколько обязательных полей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tilPrihodCancel_Click(object sender, EventArgs e)
        {
            // Описывааем действия на нажитие кнопки закрытия формы
            if (MetroFramework.MetroMessageBox.Show(this, "При закрытии формы все несохраненные данные удалены. Продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                gridPrihod.Rows.Clear();
                txtPrihodAmountDelivery.Text = "";
                txtPrihodCostDelivery.Text = "";
                txtPrihodNumDelivery.Text = "";
                txtPrihodSPartsInDelivery.Text = "";
                panelOff();
            }
            else
            {
              return;
            }
        }

        private void txtPrihodAmountDelivery_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }

        }

        private void txtPrihodCostDelivery_Click(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void tilPrihodAddInBase_Click(object sender, EventArgs e)
        {
            // Считываем построчно данные из таблички и заносим в СУБД
            DataTable dtAddToBase = new DataTable();
            dtAddToBase = GetDataTableFromDGV(gridPrihod);
            try
            {
                if (gridPrihod.Rows.Count != 0)
                {
                    for (int i = 0; i < dtAddToBase.Rows.Count; i++)
                    {
                        string AddToBaseSql = "insert into tbl_prihod (SparePart, NameInCons, ConsDate, tbl_prihod.`СonsNumber`,  Amount, UnitCost, Sklad,Archive,SkladRemainder) VALUES ((select id from ref_spart_pdt_etc where SPartName = '" + dtAddToBase.Rows[i][0] + "'), '" + dtAddToBase.Rows[i][1] + "','" + dtAddToBase.Rows[i][2] + "','" + dtAddToBase.Rows[i][3] + "','" + dtAddToBase.Rows[i][4] + "', '" + dtAddToBase.Rows[i][5] + "',(select SkladNum from tbl_sklad WHERE EngLogin = (select id from tbl_login where Login = '" + lblLoginName.Text + "') and NameAction = 1),0, '" + dtAddToBase.Rows[i][4] + "')";
                        DB.sql_insert(AddToBaseSql);
                        MetroFramework.MetroMessageBox.Show(this, "Данные добавлены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridPrihod.Rows.Clear();
                        txtPrihodAmountDelivery.Text = "";
                        txtPrihodCostDelivery.Text = "";
                        txtPrihodNumDelivery.Text = "";
                        txtPrihodSPartsInDelivery.Text = "";

                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Табличка пуста, нечего добавлять!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
