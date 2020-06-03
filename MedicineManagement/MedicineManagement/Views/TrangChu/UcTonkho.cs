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
            bunifuCircleProgressbar1.MaxValue = TotalInventory;
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

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                return;
            }
            int TotalInventory;try { TotalInventory = Convert.ToInt32( bunifuCustomDataGrid1.Rows[row].Cells["txtTotalInventory"].Value.ToString()); } catch { TotalInventory = 0; }

            bunifuCircleProgressbar1.Value = TotalInventory;
        }

        private void button_ExportExcel_Click(object sender, EventArgs e)
        {
            //  khởi tạo excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // khởi tạo WorkBook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // khởi tạo WorkSheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            app.Visible = true;

            // đinh dạng côt

            worksheet.Range["A1"].ColumnWidth = 4;
            worksheet.Range["B1"].ColumnWidth = 30;
            worksheet.Range["C1"].ColumnWidth = 30;
            worksheet.Range["D1"].ColumnWidth = 10;
            worksheet.Range["E1"].ColumnWidth = 10;
            worksheet.Range["F1"].ColumnWidth = 16;            
           
            // đinh dạng  FONT
            worksheet.Range["A1", "M1"].Font.Size = 18;
            worksheet.Range["A1", "M1"].MergeCells = true;
            worksheet.Range["A1", "M5"].Font.Bold = true;
            // ĐỔ dữ liệu vào Sheet:
            worksheet.Cells[1, 1] = "BÁO CÁO TỒN KHO";
            worksheet.Cells[3, 4] = "Ngày: " + DateTime.Now.ToShortDateString() + "";
           

            worksheet.Cells[8, 1] = "STT";
            worksheet.Cells[8, 2] = "Tên thuốc";
            worksheet.Cells[8, 3] = "Nhóm thuốc";
            worksheet.Cells[8, 4] = "Tồn kho";
            worksheet.Cells[8, 5] = "Đơn vị";
            worksheet.Cells[8, 6] = "giá";
            

            for (int i = 0; i < bunifuCustomDataGrid1.RowCount - 1; i++)
            {
                worksheet.Cells[i + 9, 1] = i + 1;
                for (int j = 0; j < 5; ++j)
                {

                    worksheet.Cells[i + 9, j + 2] = bunifuCustomDataGrid1.Rows[i].Cells[j].Value;
                }
            }
            int index = bunifuCustomDataGrid1.RowCount + 9;
            worksheet.Cells[index + 1, 3] = "Tổng tồn kho: " + label_TotalInventory.Text;
            worksheet.Cells[index, 3] = "Tổng tiền: " + label_TotalMoney.Text;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
