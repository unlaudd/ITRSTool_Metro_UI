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
            ToolTipPrihod.SetToolTip(tilPrihodEditGrid, "Редактировать выделенную ячейку");
            ToolTipPrihod.SetToolTip(tilPrihodClearElem, "Очистить поля ввода в форме");

            datPrihodDelivery.Format = DateTimePickerFormat.Custom;
            datPrihodDelivery.CustomFormat = "yyyy-MM-dd";
            try
            {
                string SPartsSql = "select SPartName from ref_spart_pdt_etc ORDER BY SPartName";
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
            panSPartsPrihod.Visible = false;
            panSkladTrans.Visible = false;
            panRepair.Visible = false;
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
                    if (RegexDouble(txtPrihodCostDelivery.Text.ToString()) == true)
                    {
                        // Проверяем поле количество на правильность ввода. Первая цифра не может быть 0.
                        if (RegexDigital(txtPrihodAmountDelivery.Text.ToString()) == true)
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
                                        multiCheck();
                                    }
                                    else
                                    {
                                        // При нажатии на отмену, очищаем все поля ввода и выходим из выполнения.

                                        multiCheck();
                                    }
                                }
                                else
                                {
                                    // Если при выборе просмотра совпадений на складе выбрано cancel, то добавляем данные в табличку и чистим поля ввода.
                                    string[] strokaEshe = { cmbPrihodSpareParts.Text, txtPrihodSPartsInDelivery.Text, DateDelivery, txtPrihodNumDelivery.Text, txtPrihodAmountDelivery.Text, txtPrihodCostDelivery.Text };
                                    addGridParam(strokaEshe, gridPrihod);
                                    multiCheck();
                                }
                            }

                            else
                            {
                                // Если не обнаружено совпадений по накладной, то добавляем данные в табличку и чистим поля ввода.
                                string[] strokaEshe = { cmbPrihodSpareParts.Text, txtPrihodSPartsInDelivery.Text, DateDelivery, txtPrihodNumDelivery.Text, txtPrihodAmountDelivery.Text, txtPrihodCostDelivery.Text };
                                addGridParam(strokaEshe, gridPrihod);
                                multiCheck();
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


        private void IntCheckClick(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }


        private void DoubleCheck_Click(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void NumInc(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 73 && number != 84 && number != 45)
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

        // Функция проверки значения int на совпадение
        // первая цифра не может быть нулем
        public static bool RegexDigital(string StringToRegex)
        {

            if (Regex.IsMatch(StringToRegex, @"\A[1-9]{1}(?:[0-9]{1,10})?\z"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Функция проверки значения double на совпадение
        // первая цифра не может быть нулем
        public static bool RegexDouble(string StringToRegex)
        {
            if (Regex.IsMatch(StringToRegex, @"\A[1-9]{1,10}(?:[.,][0-9]{1,2})?\z"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Функия для проверки значения по формату (IT-(1-9)) на совпадение.
        // Т.е. IT-13333 - верное значение, IT-0111 - не верное значение.
        // Номер инцидента не может начинаться с нуля, после записи IT-
        public static bool RegexIncNum (string StringToRegex)
        {
            if (Regex.IsMatch(StringToRegex, @"\A[IT,-]{3}[1-9]{1}(?:[0-9]{1,10})?\z"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Процедура очистки полей
        public void multiCheck()
        {

            if (chkBoxPrihodMulti.Checked)
            {
                txtPrihodAmountDelivery.Text = "";
                txtPrihodCostDelivery.Text = "";
                txtPrihodSPartsInDelivery.Text = "";
            }
            else
            {
                txtPrihodNumDelivery.Text = "";
                txtPrihodAmountDelivery.Text = "";
                txtPrihodCostDelivery.Text = "";
                txtPrihodSPartsInDelivery.Text = "";
            }
        }

        // Заполняем поля для редактирования и удаляем загруженную ячейку
        private void tilPrihodEditGrid_Click(object sender, EventArgs e)
        {
            if (gridPrihod.CurrentRow != null)
            {
                cmbPrihodSpareParts.Text = gridPrihod.CurrentRow.Cells[0].Value.ToString();
                txtPrihodSPartsInDelivery.Text = gridPrihod.CurrentRow.Cells[1].Value.ToString();
                datPrihodDelivery.Value = Convert.ToDateTime(gridPrihod.CurrentRow.Cells[2].Value.ToString());
                txtPrihodNumDelivery.Text = gridPrihod.CurrentRow.Cells[3].Value.ToString();
                txtPrihodAmountDelivery.Text = gridPrihod.CurrentRow.Cells[4].Value.ToString();
                txtPrihodCostDelivery.Text = gridPrihod.CurrentRow.Cells[5].Value.ToString();
                gridPrihod.Rows.Remove(gridPrihod.CurrentRow);
            }
        }

        // Очищаем поля ввода
        private void tilPrihodClearElem_Click(object sender, EventArgs e)
        {
            multiCheck();
        }

        private void расходкаДляПайкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelOff();
            panSPartsPrihod.Location = new Point(20, 87);
            panSPartsPrihod.Size = new Size(1061, 441);
            panSPartsPrihod.Visible = true;
            string SPartsPrihodSql = "select SPartName from ref_spart_cable ORDER BY SPartName";
            DataTable SPartsPrihod = new DataTable();
            SPartsPrihod = DB.sql_select_dataset(SPartsPrihodSql);
            cmbSPartPrihod.DataSource = SPartsPrihod;
            cmbSPartPrihod.DisplayMember = "SPartName";
            cmbSPartPrihod.Focus();
        }

        private void tilSPartPrihodDeleteFromGrid_Click(object sender, EventArgs e)
        {
            if (gridSPartPrihod.CurrentRow != null)
            {
                gridSPartPrihod.Rows.Remove(gridSPartPrihod.CurrentRow);
            }
        }

        private void tilSPartPrihodAddToGrid_Click(object sender, EventArgs e)
        {
            DataTable dtCheckTable = new DataTable();
            dtCheckTable = GetDataTableFromDGV(gridSPartPrihod);
            try
            {
                // Проверяем на совпадение введенные данные с табличкой
                for (int i = 0; i < dtCheckTable.Rows.Count; i++)
                {
                    if (dtCheckTable.Rows[i][0].ToString() == cmbSPartPrihod.Text && dtCheckTable.Rows[i][1].ToString() == txtSPartPrihod.Text)
                    {

                        MetroFramework.MetroMessageBox.Show(this, "Запись уже существует в таблице. Проверьте ввод данных", "Внимание", MessageBoxButtons.OK);
                        return;
                    }

                }
                if (txtSPartPrihod.Text != "")
                {
                    if (RegexDigital(txtSPartPrihod.Text) == true)
                    {
                        string[] strokaEshe = { cmbSPartPrihod.Text, txtSPartPrihod.Text };
                        addGridParam(strokaEshe, gridSPartPrihod);
                        txtSPartPrihod.Text = "";
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Не верно заполнено поле количество. Данные не добавлены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Не заполнены необходимые поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSPartPrihod.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tilSPartPrihodCancel_Click(object sender, EventArgs e)
        {
            // Описывааем действия на нажитие кнопки закрытия формы
            if (MetroFramework.MetroMessageBox.Show(this, "При закрытии формы все несохраненные данные удалены. Продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                gridSPartPrihod.Rows.Clear();
                txtSPartPrihod.Text = "";
                panelOff();
            }
            else
            {
                return;
            }
        }

        private void tilSPartPrihodAddToBase_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridSPartPrihod.Rows.Count != 0)
                {
                    DataTable dt = new DataTable();
                    dt = GetDataTableFromDGV(gridSPartPrihod);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string CheckBeforInsertSQL = "SELECT count(*) FROM `tbl_spart_sklad` where SPartName = (select id from ref_spart_cable where SPartName = '"+cmbSPartPrihod.Text+"') and Sklad = (select SkladNum from tbl_sklad WHERE EngLogin = (select id from tbl_login where Login = '"+lblLoginName.Text+"') and NameAction = 3)";
                        int CheckBeforInsert = Convert.ToInt32(DB.Sql_Reader(CheckBeforInsertSQL));
                        if (CheckBeforInsert == 0)
                        {
                            string SPartInsertSql = "insert into `tbl_spart_sklad`(SPartName, Amount, Sklad) Values((select id from ref_spart_cable where SPartName = '" + dt.Rows[i][0] + "'),'" + dt.Rows[i][1] + "',(select SkladNum from tbl_sklad WHERE EngLogin = (select id from tbl_login where Login = '" + lblLoginName.Text + "') and NameAction = 3))";
                            DB.sql_insert(SPartInsertSql);
                        }
                        else
                        {
                            string SPartUpdateSql = "update `tbl_spart_sklad` SET Amount = Amount + " + dt.Rows[i][1] + " where SPartName = (select id from ref_spart_cable where SPartName = '" + dt.Rows[i][0] + "') and Sklad = (select SkladNum from tbl_sklad WHERE EngLogin = (select id from tbl_login where Login = '" + lblLoginName.Text + "') and NameAction = 3)";
                            DB.sql_update(SPartUpdateSql);
                        }
                    }
                    gridSPartPrihod.Rows.Clear();
                    txtSPartPrihod.Text = "";
                    MetroFramework.MetroMessageBox.Show(this, "Данные добавлены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void пересылкаПоСкладамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelOff();
            panSkladTrans.Location = new Point(20, 87);
            panSkladTrans.Size = new Size(1064, 442);
            panSkladTrans.Visible = true;

            string SPartsPrihodSql = "select SPartName from ref_spart_cable ORDER BY SPartName";
            DataTable SPartsPrihod = new DataTable();
            SPartsPrihod = DB.sql_select_dataset(SPartsPrihodSql);
            cmbSPartPrihod.DataSource = SPartsPrihod;
            cmbSPartPrihod.DisplayMember = "SPartName";
            cmbSPartPrihod.Focus();
        }

        private void rbSkladTransPDTSelection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void тСДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelOff();
            panRepair.Location = new Point(20, 87);
            panRepair.Size = new Size(1064, 438);
            panRepair.Visible = true;

            string RepairSPartsSQL = "select SPartName from ref_spart_pdt_etc order by SPartName";
            DataTable RepairSParts = new DataTable();
            RepairSParts = DB.sql_select_dataset(RepairSPartsSQL);
            cmbRepairSParts.DataSource = RepairSParts;
            cmbRepairSParts.DisplayMember = "SPartName";
            cmbRepairSParts.SelectedIndex = -1;

            string RepairSCSQL = "select NumSc from ref_sc order by NumSc";
            DataTable RepairSC = new DataTable();
            RepairSC = DB.sql_select_dataset(RepairSCSQL);
            cmbRepairSC.DataSource = RepairSC;
            cmbRepairSC.DisplayMember = "NumSc";
            cmbRepairSC.SelectedIndex = -1;

            string RepairEquipSQL = "select EQName from ref_equipment order by EQName";
            DataTable RepairEquip = new DataTable();
            RepairEquip = DB.sql_select_dataset(RepairEquipSQL);
            cmbRepairEquipment.DataSource = RepairEquip;
            cmbRepairEquipment.DisplayMember = "EQName";
            cmbRepairEquipment.SelectedIndex = -1;

        }

        private void tilRepairAddGrid_Click(object sender, EventArgs e)
        {
            if (cmbRepairSParts.Text == "")
            {
                return;
            }
            try
            {
                string[] strokaEshe = { cmbRepairSParts.Text };
                addGridParam(strokaEshe, gridRepair);


                DataTable dtCheckTable = new DataTable();
                dtCheckTable = GetDataTableFromDGV(gridRepair);
                string DataInTableNotIn = "";

                for (int i = 0; i < dtCheckTable.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        DataInTableNotIn = DataInTableNotIn + "'" + dtCheckTable.Rows[i][0].ToString() + "'";
                    }
                    else
                    {
                        DataInTableNotIn = DataInTableNotIn + ", '" + dtCheckTable.Rows[i][0].ToString() + "'";
                    }
                }
                cmbRepairSParts.DataSource = null;
                string RepairSPartsSQL = "select SPartName from ref_spart_pdt_etc where SPartName not in (" + DataInTableNotIn + ") order by SPartName";
                
                DataTable RepairSParts = new DataTable();
                RepairSParts = DB.sql_select_dataset(RepairSPartsSQL);
                cmbRepairSParts.DataSource = RepairSParts;
                cmbRepairSParts.DisplayMember = "SPartName";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tilRepairDeleteGrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridRepair.CurrentRow != null)
                {
                    gridRepair.Rows.Remove(gridRepair.CurrentRow);

                    DataTable dtCheckTable = new DataTable();
                    dtCheckTable = GetDataTableFromDGV(gridRepair);
                    string DataInTableNotIn = "";
                    if (dtCheckTable.Rows.Count == 0)
                    {

                        cmbRepairSParts.DataSource = null;
                        string RepairSPartsSQLnull = "select SPartName from ref_spart_pdt_etc order by SPartName";

                        DataTable RepairSPartsnull = new DataTable();
                        RepairSPartsnull = DB.sql_select_dataset(RepairSPartsSQLnull);
                        cmbRepairSParts.DataSource = RepairSPartsnull;
                        cmbRepairSParts.DisplayMember = "SPartName";
                        return;
                    }
                    for (int i = 0; i < dtCheckTable.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            DataInTableNotIn = DataInTableNotIn + "'" + dtCheckTable.Rows[i][0].ToString() + "'";
                        }
                        else
                        {
                            DataInTableNotIn = DataInTableNotIn + ", '" + dtCheckTable.Rows[i][0].ToString() + "'";
                        }
                    }
                    cmbRepairSParts.DataSource = null;
                    string RepairSPartsSQL = "select SPartName from ref_spart_pdt_etc where SPartName not in (" + DataInTableNotIn + ") order by SPartName";
                    DataTable RepairSParts = new DataTable();
                    RepairSParts = DB.sql_select_dataset(RepairSPartsSQL);
                    cmbRepairSParts.DataSource = RepairSParts;
                    cmbRepairSParts.DisplayMember = "SPartName";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tilRepairSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Для даты работ используем текущюю дату
                string DateWork = DateTime.Now.ToString("yyyy-MM-dd");

                // Команда SQL для сохранения данных по ремонту с возвратом ID только что сохраненной записи.
                string RepairMainSql = "insert into tbl_repair_main (sc, NumIncident,Equipment,InvNum,DescFailure,PerfWork,Discrep,DateWork,Fname, Archive,ClaimedFailureConfirmed,UsedAdditionalSParts) Values ((select id from ref_sc where NumSc = '" + cmbRepairSC.Text + "'), '" + txtRepairIncNumber.Text + "',(select id from ref_equipment where EQName = '" + cmbRepairEquipment.Text + "'),'" + txtRepairInvNumber.Text + "','" + txtRepairFailureName.Text + "','" + txtRepairPerfWork.Text + "','" + txtRepairDevInOperation.Text + "', '" + DateWork + "', (select id from tbl_login where Login = '" + lblLoginName.Text + "'), false," + chkRepairFailureConfirmed.Checked.ToString() + "," + chkRepairUsedAddSParts.Checked.ToString() + "); SELECT LAST_INSERT_ID(); SELECT LAST_INSERT_ID()";
                // Проверяем заполение полей
                if (cmbRepairSC.Text != "" && cmbRepairEquipment.Text != "" && txtRepairFailureName.Text != "" && txtRepairIncNumber.Text != "" && txtRepairInvNumber.Text != "" && txtRepairPerfWork.Text != "")
                {
                    // Проверяем на правильность введения номера инцидента (формат IT-(1-9) (После IT значение не может быть 0))
                    if (RegexIncNum(txtRepairIncNumber.Text) == true)
                    {
                        // Проверяем на правильность введение инвентарного номера (цифры, первая цифра не может быть 0)
                        if (RegexDigital(txtRepairInvNumber.Text) == true)
                        {
                            // Проверяем на наличие существующего в СУБД номера инцидента. Возврат 0 - нет, 1 - совпадение есть.
                            string RepairIncCheckSql = "select count(*) from tbl_repair_main where NumIncident = '"+txtRepairIncNumber.Text+"'";
                            int RepairIncCheck = Convert.ToInt32(DB.Sql_Reader(RepairIncCheckSql));
                            if (RepairIncCheck != 0)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "В СУБД уже имеется указанный инцидент! Данные не добавлены!", txtRepairIncNumber.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            
                            // Если грид не пустой, то вносим данные по запчастям
                            if (gridRepair.Rows.Count != 0)
                            {
                                DataTable dt = new DataTable();
                                dt = GetDataTableFromDGV(gridRepair);

                                // Проверяем склад на наличие указанных запчестей в гриде.
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    string RepairCountTestSql = "select count(*) from tbl_prihod where SparePart = (select id from ref_spart_pdt_etc where SPartName = '" + dt.Rows[i][0] + "') and Sklad =(select SkladNum from tbl_sklad where EngLogin = (select id from tbl_login where Login = '" + lblLoginName.Text + "') and NameAction = '2') and Archive =0 and SkladRemainder>=1";
                                    int RepairCountTest = Convert.ToInt32(DB.Sql_Reader(RepairCountTestSql));
                                    if (RepairCountTest == 0)
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "На складе не хватает запчастей для закрытия ремонта. Данные не добавлены!", dt.Rows[i][0].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                
                                // Вносим запчасти
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                {

                                    // Получаем id и кол-во запчастей на складе по минимальной дате (самой старой), складу, действию ремонт (цифра 2), признаку архивности и ограничиваем вывод 1й записью (Limit 1)
                                    string RepairSPartSql = "SELECT id, SkladRemainder from tbl_prihod where ConsDate = (SELECT MIN(ConsDate) from tbl_prihod where SparePart = (select id from ref_spart_pdt_etc where SPartName = '" + dt.Rows[i][0] + "') AND Archive = 0 AND Sklad = (select SkladNum from tbl_sklad where EngLogin = (select id from tbl_login where Login = '" + lblLoginName.Text + "') and NameAction = '2')) AND Archive = 0 limit 1";
                                    // Создаем экземпляр таблички, заливаем в него данные
                                    DataTable RepairSPart = new DataTable();
                                    RepairSPart = DB.sql_select_dataset(RepairSPartSql);

                                    // Создаем строку вставки в табличку данных по использованным запчастям. SpareParts - забираем из таблички выше. 1 - Запчасть одного типа в ремонте всегда используется только одна, выполнение запроса по сохранению данных ремонта и получению сохраненного ID
                                    string RepairSpartToBaseSql = "insert into tbl_repair_main__spart (SpareParts,Amount,RepairNum) Values (" + RepairSPart.Rows[0][0].ToString() + ",1," + DB.sql_insert_back(RepairMainSql) + ")";
                                    // Сохраняем строку выше
                                    DB.sql_insert(RepairSpartToBaseSql);

                                    //Проверяем количество запчастей на складе по указанной выше табличке.
                                    // Если кол-во больше 1 - то обновляем значение на -1 
                                    if (Convert.ToInt32(RepairSPart.Rows[0][1]) > 1)
                                    {
                                        string RepairSPartInSkladSql = "update tbl_prihod set SkladRemainder = SkladRemainder - 1 WHERE id = " + RepairSPart.Rows[0][0] + "";
                                        DB.sql_update(RepairSPartInSkladSql);
                                    }
                                    // Если кол-во равно 1 - то обновляем значение на -1, Устанавливаем признак архивности, что бы данная запись больше не использовалась в поиске.
                                    if (Convert.ToInt32(RepairSPart.Rows[0][1]) == 1)
                                    {
                                        string RepairSPartInSkladSql = "update tbl_prihod set SkladRemainder = SkladRemainder - 1, Archive = 1 WHERE id = " + RepairSPart.Rows[0][0] + "";
                                        DB.sql_update(RepairSPartInSkladSql);
                                    }
                                }

                                // Сохраняем номер инцидента, дату, тип работ (ремонт) в табличку отправки, для дальнейшего ввода накладной на отправку.
                                string RepairRecInSendSql = "insert into tbl_sending (NumIncident,DateOfRecord,TypeAction) Values ('"+txtRepairIncNumber.Text+"', '"+DateWork+"',  2)";
                                DB.sql_insert(RepairRecInSendSql);

                                // Очищаем все поля, заново переподключаем список с запчастями.
                                cmbRepairSParts.DataSource = null;
                                string RepairSPartsSQLnull = "select SPartName from ref_spart_pdt_etc order by SPartName";

                                DataTable RepairSPartsnull = new DataTable();
                                RepairSPartsnull = DB.sql_select_dataset(RepairSPartsSQLnull);
                                cmbRepairSParts.DataSource = RepairSPartsnull;
                                cmbRepairSParts.DisplayMember = "SPartName";

                                gridRepair.Rows.Clear();
                                cmbRepairSC.SelectedIndex = -1;
                                cmbRepairEquipment.SelectedIndex = -1;
                                cmbRepairSParts.SelectedIndex = -1;
                                txtRepairDevInOperation.Text = "";
                                txtRepairFailureName.Text = "";
                                txtRepairIncNumber.Text = "";
                                txtRepairInvNumber.Text = "";
                                txtRepairPerfWork.Text = "";
                                chkRepairFailureConfirmed.Checked = false;
                                chkRepairUsedAddSParts.Checked = false;

                            }
                            else
                            // Действие на вариант без использования запчастей.
                            {
                                // Сохраняем номер инцидента, дату, тип работ (ремонт) в табличку отправки, для дальнейшего ввода накладной на отправку.
                                DB.sql_insert(RepairMainSql);

                                string RepairRecInSendSql = "insert into tbl_sending (NumIncident,DateOfRecord,TypeAction) Values ('" + txtRepairIncNumber.Text + "', '" + DateWork + "',  2)";
                                DB.sql_insert(RepairRecInSendSql);

                                // Очищаем все поля, заново переподключаем список с запчастями.
                                cmbRepairSParts.DataSource = null;
                                string RepairSPartsSQLnull = "select SPartName from ref_spart_pdt_etc order by SPartName";

                                DataTable RepairSPartsnull = new DataTable();
                                RepairSPartsnull = DB.sql_select_dataset(RepairSPartsSQLnull);
                                cmbRepairSParts.DataSource = RepairSPartsnull;
                                cmbRepairSParts.DisplayMember = "SPartName";
                                gridRepair.Rows.Clear();
                                cmbRepairSC.SelectedIndex = -1;
                                cmbRepairEquipment.SelectedIndex = -1;
                                
                                cmbRepairSParts.SelectedIndex = -1;
                                txtRepairDevInOperation.Text = "";
                                txtRepairFailureName.Text = "";
                                txtRepairIncNumber.Text = "";
                                txtRepairInvNumber.Text = "";
                                txtRepairPerfWork.Text = "";
                                chkRepairFailureConfirmed.Checked = false;
                                chkRepairUsedAddSParts.Checked = false;
                            }


                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "При вводе инвентарного номера допущена ошибка", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtRepairInvNumber.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "При вводе инцидента допущена ошибка", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRepairIncNumber.Focus();
                        return;

                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Не заполнено одно или несколько обязательных полей", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRepairIncNumber.Focus();
                    return;
                }
            }
              
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
}

        private void tilRepairCancel_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "При закрытии формы все несохраненные данные удалены. Продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                gridRepair.Rows.Clear();
                cmbRepairSC.DataSource = null;
                cmbRepairEquipment.DataSource = null;
                cmbRepairSParts.DataSource = null;
                txtRepairDevInOperation.Text = "";
                txtRepairFailureName.Text = "";
                txtRepairIncNumber.Text = "";
                txtRepairInvNumber.Text = "";
                txtRepairPerfWork.Text = "";
                chkRepairFailureConfirmed.Checked = false;
                chkRepairUsedAddSParts.Checked = false;
                panelOff();
            }
            else
            {
                return;
            }
        }

        
    }
}
