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
using MedicineManagement.Models;

namespace MedicineManagement.Views.NhaCungCap
{
    public partial class UcNhaCungCap : UserControl
    {
        ControllerSupplier ctr = new ControllerSupplier();
        public static string maNCC, tenNCC, diaChi, sdt, email;

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
            // Code chinh
            dataGridView1.DataSource = ctr.Load();
            label_CountRecord.Text = (dataGridView1.Rows.Count - 1).ToString() + "/" + (dataGridView1.Rows.Count - 1).ToString();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            // Code xu ly reload
            dataGridView1.DataSource = ctr.Load();
            label_CountRecord.Text = (dataGridView1.Rows.Count - 1).ToString() + "/" + (dataGridView1.Rows.Count - 1).ToString();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            // Code xu ly xuat file
            // ...
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form form = new NhaCungCap.FormAddSupplier();
            form.ShowDialog();

            dataGridView1.DataSource = ctr.Load();
        }
        int index;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                // Lay ID cua ban ghi duoc chon --> chuan bi cho Xem, Sua, Xoa
                int id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

                // Xu ly cac truong hop Xem(detail), Sua(edit), Xoa(delete)
                if (e.ColumnIndex == dataGridView1.Columns["detail"].Index)
                {
                    // Code xu ly lay du lieu tu ban ghi chuyen sang FormDetailSupplier
                    maNCC = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    tenNCC = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    diaChi = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    sdt = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    email = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    // Hien thi FormDetailSupplier
                    FormDetailSupplier form = new NhaCungCap.FormDetailSupplier();
                    form.ShowDialog();
                    dataGridView1.DataSource = ctr.Load();

                }
                else if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
                {
                    // Code xu ly lay du lieu tu ban ghi chuyen sang FormEditSupplier
                    maNCC = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    tenNCC = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    diaChi = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    sdt = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    email = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    // Hien thi FormEditSupplier
                    Form form = new NhaCungCap.FormEditSupplier();
                    form.ShowDialog();
                    dataGridView1.DataSource = ctr.Load();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index)
                {
                    DialogResult dlr = MessageBox.Show("Chắc chắn xoá ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        // Code xu ly xoa nha cung cap
                        maNCC = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        ctr.Delete(maNCC);
                        dataGridView1.DataSource = ctr.Load();
                    }
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctr.Load();
            string recordOld = (dataGridView1.Rows.Count - 1).ToString();
            dataGridView1.DataSource =  ctr.Search(textBox_Search.Text);
            string recordNew = (dataGridView1.Rows.Count - 1).ToString();
            label_CountRecord.Text = recordNew + "/" + recordOld;
        }
    }
}
