using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MedicineManagement.Controllers;

namespace MedicineManagement.Views
{
    public partial class UcBanThuoc : UserControl
    {
        ControllerMedicine ctrl = new ControllerMedicine();

        public UcBanThuoc()
        {
            InitializeComponent();
        }

        private void UcBanThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = ctrl.Load();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lay ID cua ban ghi duoc chon
                int id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                // ...

                if (e.ColumnIndex == dataGridView1.Columns["add"].Index)
                {
                    // Code xu ly lay du lieu tu ban ghi chuyen sang ListVew don thuoc
                    // ...
                    MessageBox.Show("Thêm thuốc vào listview");

                }
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            // Code xu ly load lại DS thuoc
            // ...
            MessageBox.Show("Nạp lại danh sách thuốc");
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            // Code xu ly tao don thuoc moi
            // ...
            MessageBox.Show("Tạo đơn thuốc mới");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Code xu ly xoa thuoc khoi listview
            // ...
            MessageBox.Show("Xoá thuốc khoi listview");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            // Code xu ly reset lại listview
            // ...
            MessageBox.Show("Reset lại listview");
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            // Code xuat file Don thuoc
            // ...
            MessageBox.Show("Xuất file đơn thuốc");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // ... Code xu ly luu don thuoc
            // ...
            MessageBox.Show("Lưu đơn thuốc");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // Code xu ly huy don thuoc
            // ...
            MessageBox.Show("Huỷ đơn thuốc");
        }
    }
}
