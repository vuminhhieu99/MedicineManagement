using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicineManagement.Controllers;

namespace MedicineManagement.Views.TrangChu
{
    public partial class UcTonkho : UserControl
    {
        ControllerMedicine ctrl = new ControllerMedicine();
        int TotalInventory;
        decimal TotalMoney;
        public UcTonkho()
        {
            InitializeComponent();
            bunifuCircleProgressbar1.animated = true;
            TotalInventory = 0;
            TotalMoney = 0;
        }
        private void UpdatePrecentProgressbar()
        {
            TotalInventory = 0;
            TotalMoney = 0;
            foreach (DataGridViewRow item in bunifuCustomDataGrid1.Rows)
            {
                int v = 0; try { v = Convert.ToInt32(item.Cells["txtTotalInventory"].Value); } catch { v = 0; }
                TotalInventory = TotalInventory + v;
                decimal m = 0; try { m = Convert.ToDecimal(item.Cells["txtPrice"].Value); } catch { m = 0; }
                TotalMoney += m;
            }
            if (TotalInventory == 0) { TotalInventory = 1; }            
            label_TotalInventory.Text = TotalInventory.ToString();
            label_TotalMoney.Text = TotalMoney.ToString();
        }

        private void UcTonkho_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = ctrl.WarnInventory(300000);
            UpdatePrecentProgressbar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if(bunifuCheckbox1.Checked == true)
            {
                if (textBox_LimitInventory.Text != "")
                {
                    bunifuCustomDataGrid1.DataSource = ctrl.WarnInventory(Convert.ToInt32(textBox_LimitInventory.Text));
                    UpdatePrecentProgressbar();
                }
            }
            else
            {
                bunifuCustomDataGrid1.DataSource = ctrl.WarnInventory(300000);
                UpdatePrecentProgressbar();
            }
        }

        private void textBox_LimitInventory_TextChanged(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                if (textBox_LimitInventory.Text != "")
                {
                    bunifuCustomDataGrid1.DataSource = ctrl.WarnInventory(Convert.ToInt32(textBox_LimitInventory.Text));
                    UpdatePrecentProgressbar();
                }
            }
        }

        

        private void button_ExportExcel_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)bunifuCustomDataGrid1.DataSource;
            ControllerExport export = new ControllerExport();
            export.ExportTonKho(table, "THỐNG KÊ TỒN KHO", label_TotalInventory.Text, label_TotalMoney.Text);
        }

        private void UcTonkho_VisibleChanged(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = ctrl.WarnInventory(300000);
            UpdatePrecentProgressbar();
        }

        private void bunifuCustomDataGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                return;
            }
            int TotalInventory; try { TotalInventory = Convert.ToInt32(bunifuCustomDataGrid1.Rows[row].Cells["txtTotalInventory"].Value.ToString()); } catch { TotalInventory = 0; }
            
            string ID_Medicine;
            try
            {
                ID_Medicine = bunifuCustomDataGrid1.Rows[row].Cells["txtID_Medicine"].Value.ToString();
                ControllerPrescriptionLine ctrl = new ControllerPrescriptionLine();
                int sellInMonth = ctrl.SellInMonth(ID_Medicine);
                bunifuCircleProgressbar1.MaxValue = sellInMonth + TotalInventory;
                bunifuCircleProgressbar1.Value = sellInMonth;
            }
            catch(Exception ex) { bunifuCircleProgressbar1.MaxValue = TotalInventory; }
            
            

           
        }
    }
}
