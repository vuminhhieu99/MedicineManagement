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

namespace MedicineManagement.Views.DonThuoc
{
    public partial class UcDonThuoc : UserControl
    {
        ControllerPrescription ctrl = new ControllerPrescription();

        public UcDonThuoc()
        {
            InitializeComponent();
        }

        private void UcDonThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = ctrl.Load();
            btn_Save.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Save.Visible = false;
            if (e.RowIndex >= 0)
            {
                // Lay ID cua ban ghi duoc chon --> chuan bi cho Xem, Sua, Xoa
                int id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

                // Xu ly cac truong hop Xem(detail), Sua(edit), Xoa(delete)
                if (e.ColumnIndex == dataGridView1.Columns["detail"].Index)
                {
                    // Code xu ly lay du lieu tu ban ghi chuyen sang FormDetailMedicine
                    // ...

                    
                }
                else if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
                {
                    btn_Save.Visible = true;

                    // Code xu ly lay du lieu tu ban ghi chuyen sang FormEditMedicine
                    // ...

                    
                }
                else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index)
                {
                    DialogResult dlr = MessageBox.Show("Chắc chắn xoá ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        // Code xu ly xoa don thuoc
                        //...
                        MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
