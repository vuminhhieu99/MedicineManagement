using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineManagement.Views.NhaCungCap
{
    public partial class UcNhaCungCap : UserControl
    {
        public UcNhaCungCap()
        {
            InitializeComponent();
        }

        private void UcNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Load du lieu tu database vao datagridview
        public void LoadData()
        {
            // Vidu: them data de test thu
            for (int i = 0; i < 30; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = "name";
                row.Cells[2].Value = "address";
                row.Cells[3].Value = "phonenumber";
                row.Cells[4].Value = "email";
                dataGridView1.Rows.Add(row);
            }

            // Code chinh
            // .....
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            // Code xu ly reload
            // ...
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            // Code xu ly xuat file
            // ...
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form form = new NhaCungCap.FormAddSupplier();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lay ID cua ban ghi duoc chon --> chuan bi cho Xem, Sua, Xoa
                int id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

                // Xu ly cac truong hop Xem(detail), Sua(edit), Xoa(delete)
                if (e.ColumnIndex == dataGridView1.Columns["detail"].Index)
                {
                    // Code xu ly lay du lieu tu ban ghi chuyen sang FormDetailSupplier
                    // ...

                    // Hien thi FormDetailSupplier
                    Form form = new NhaCungCap.FormDetailSupplier();
                    form.Show();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
                {
                    // Code xu ly lay du lieu tu ban ghi chuyen sang FormEditSupplier
                    // ...

                    // Hien thi FormEditSupplier
                    Form form = new NhaCungCap.FormEditSupplier();
                    form.Show();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index)
                {
                    DialogResult dlr = MessageBox.Show("Chắc chắn xoá ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        // Code xu ly xoa nha cung cap
                        //...
                        MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
