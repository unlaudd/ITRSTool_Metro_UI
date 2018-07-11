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
            if(gridPrihod.CurrentRow != null)
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
            
            string SkladCheckSql = "select count(*) from tbl_prihod where tbl_prihod.`СonsNumber`= '"+ txtPrihodNumDelivery.Text+"' and tbl_prihod.ConsDate = '"+datPrihodDelivery.Text + "' and sklad = (select SkladNum from tbl_sklad WHERE EngLogin = (select id from tbl_login where Login = '"+lblLoginName.Text+"') and NameAction = 1 limit 1)";
            int SkladCheck = Convert.ToInt32(DB.Sql_Reader(SkladCheckSql));
            if (SkladCheck != 1)
            {
                if (txtPrihodAmountDelivery.Text != "" && txtPrihodCostDelivery.Text != "" && txtPrihodNumDelivery.Text != "" && txtPrihodSPartsInDelivery.Text != "")
                {

                    if (Regex.IsMatch(txtPrihodCostDelivery.Text.ToString(), @"\A[0-9]{1,10}(?:[.,][0-9]{1,2})?\z"))
                    {
                        if (Regex.IsMatch(txtPrihodAmountDelivery.Text.ToString(), @"^\d+$"))
                        {
                            DataTable dt = new DataTable();
                            dt = GetDataTableFromDGV(gridPrihod);
                            string DateDelivery = datPrihodDelivery.Value.ToString("yyyy-MM-dd");
                            string[] strokaEshe = { cmbPrihodSpareParts.Text, txtPrihodSPartsInDelivery.Text, DateDelivery, txtPrihodNumDelivery.Text, txtPrihodAmountDelivery.Text, txtPrihodCostDelivery.Text };
                            addGridParam(strokaEshe, gridPrihod);
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
            else
            {
                MessageBox.Show("На складе уже имеются записи по данной накладной");
            }
        }

        private void tilPrihodCancel_Click(object sender, EventArgs e)
        {
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

        }
    }
}
