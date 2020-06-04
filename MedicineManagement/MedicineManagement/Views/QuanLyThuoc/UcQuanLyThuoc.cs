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
using System.Data.SqlClient;

namespace MedicineManagement.Views.QuanLyThuoc
{
    public partial class UcQuanLyThuoc : UserControl
    {
        static ControllerMedicine ctrl = new ControllerMedicine();
        public static Medicine medicine = new Medicine();
        private int totalRecord = 0;

        public static string medicineID;
        public static string medicineName;
        public static string medicineGroup;
        public static string unit;
        public static string uses;
        public static string price;
        public static string inventory;
        public static string note;
        public static string mostUsedMonth;

        public UcQuanLyThuoc()
        {
            InitializeComponent();
        }

        private void UcQuanLyThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = ctrl.Load();
            totalRecord = dataGridView1.Rows.Count - 1;
            label_CountRecord.Text = totalRecord.ToString() + "/" + totalRecord.ToString() + " bản ghi";
        }

        public int CountRecord()
        {
            return dataGridView1.Rows.Count - 1;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctrl.Search(textBox_Search.Text);
            label_CountRecord.Text = CountRecord().ToString() + "/" + totalRecord.ToString() + " bản ghi";
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            Form form = new QuanLyThuoc.FormFilterMedicine();
            form.ShowDialog();

            // thay doi vi tri
            ChangeFormDisplay();

            // hien thi noi dung loc
            if (medicine.ID_Medicine != -1)
                label1.Text = "Mã thuốc:  " + medicine.ID_Medicine;
            label2.Text = "Tên thuốc       :  " + medicine.Name;
            label3.Text = "Nhóm thuốc:  " + medicine.MedicineGroup;
            label4.Text = "Đơn vị tính   :  " + medicine.Unit;
            if (medicine.Search_MinPrice != 0 && medicine.Search_MaxPrice != 0)
                label5.Text = "Giá tiền    :  " + medicine.Search_MinPrice + "-" + medicine.Search_MaxPrice;
            if (medicine.Search_MinTotalInventory != 0 && medicine.Search_MaxTotalInventory != 0)
                label6.Text = "Số lượng còn:  " + medicine.Search_MinTotalInventory + "-" + medicine.Search_MaxTotalInventory;
            label7.Text = "Tháng dùng nhiều:  " + medicine.MostUsedMonth;

            // do du lieu vao datagridview
            dataGridView1.DataSource = ctrl.SearchAdvance(medicine);
            label_CountRecord.Text = CountRecord().ToString() + "/" + totalRecord.ToString() + " bản ghi";
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            UndoChangeFormDisplay();

            LoadData();
            textBox_Search.ResetText();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            // Export
            // ............
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UndoChangeFormDisplay();

            medicineID = GetCurrentIdentify().ToString();

            Form form = new QuanLyThuoc.FormAddMedicine();
            form.ShowDialog();

            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UndoChangeFormDisplay();

            if (e.RowIndex >= 0)
            {
                // Lay ID cua ban ghi duoc chon --> chuan bi cho Xem, Sua, Xoa
                string strID = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                int id = -1;
                if (!strID.Equals(""))
                    id = Convert.ToInt32(strID);

                // Xu ly cac truong hop Xem(detail), Sua(edit), Xoa(delete)
                if (e.ColumnIndex == dataGridView1.Columns["detail"].Index)
                {
                    if (id != -1)
                    {
                        // Code xu ly lay du lieu tu ban ghi chuyen sang FormDetailMedicine
                        medicineID = dataGridView1.SelectedCells[0].OwningRow.Cells["_id"].Value.ToString();
                        medicineName = dataGridView1.SelectedCells[0].OwningRow.Cells["_name"].Value.ToString();
                        medicineGroup = dataGridView1.SelectedCells[0].OwningRow.Cells["_group"].Value.ToString();
                        uses = dataGridView1.SelectedCells[0].OwningRow.Cells["_uses"].Value.ToString();
                        unit = dataGridView1.SelectedCells[0].OwningRow.Cells["_unit"].Value.ToString();
                        price = dataGridView1.SelectedCells[0].OwningRow.Cells["_price"].Value.ToString();
                        inventory = dataGridView1.SelectedCells[0].OwningRow.Cells["_inventory"].Value.ToString();
                        note = dataGridView1.SelectedCells[0].OwningRow.Cells["_note"].Value.ToString();
                        mostUsedMonth = dataGridView1.SelectedCells[0].OwningRow.Cells["_mostUsed"].Value.ToString();

                        // Hien thi FormDetailMedicine
                        Form form = new QuanLyThuoc.FormDetailMedicine();
                        form.ShowDialog();
                        LoadData();
                    }
                }
                else if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
                {
                    if (id != -1)
                    {
                        // Code xu ly lay du lieu tu ban ghi chuyen sang FormEditMedicine
                        medicineID = dataGridView1.SelectedCells[0].OwningRow.Cells["_id"].Value.ToString();
                        medicineName = dataGridView1.SelectedCells[0].OwningRow.Cells["_name"].Value.ToString();
                        medicineGroup = dataGridView1.SelectedCells[0].OwningRow.Cells["_group"].Value.ToString();
                        uses = dataGridView1.SelectedCells[0].OwningRow.Cells["_uses"].Value.ToString();
                        unit = dataGridView1.SelectedCells[0].OwningRow.Cells["_unit"].Value.ToString();
                        price = dataGridView1.SelectedCells[0].OwningRow.Cells["_price"].Value.ToString();
                        inventory = dataGridView1.SelectedCells[0].OwningRow.Cells["_inventory"].Value.ToString();
                        note = dataGridView1.SelectedCells[0].OwningRow.Cells["_note"].Value.ToString();
                        mostUsedMonth = dataGridView1.SelectedCells[0].OwningRow.Cells["_mostUsed"].Value.ToString();

                        // Hien thi FormEditMedicine
                        Form form = new QuanLyThuoc.FormEditMedicine();
                        form.ShowDialog();
                        LoadData();
                    }
                }
                else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index)
                {
                    if (id != -1)
                    {
                        DialogResult dlr = MessageBox.Show("Chắc chắn xoá ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.Yes)
                        {
                            // Code xu ly xoa thuoc
                            ctrl.Delete(strID);
                            MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                }
            }
        }

        public void ChangeFormDisplay()
        {
            dataGridView1.Size = new System.Drawing.Size(1272, 668);
            textBox_TableName.Location = new System.Drawing.Point(18, 108);
            dataGridView1.Location = new System.Drawing.Point(18, 140);
            tableLayoutPanel1.Visible = true;
        }

        public void UndoChangeFormDisplay()
        {
            // thay doi vi tri
            dataGridView1.Size = new System.Drawing.Size(1272, 668);
            textBox_TableName.Location = new System.Drawing.Point(18, 71);
            dataGridView1.Location = new System.Drawing.Point(18, 105);
            tableLayoutPanel1.Visible = false;

            // hien thi noi dung loc
            label1.Text = "Mã thuốc:  ";
            label2.Text = "Tên thuốc       :  ";
            label3.Text = "Nhóm thuốc:  ";
            label4.Text = "Đơn vị tính   :  ";
            label5.Text = "Giá tiền    :  ";
            label6.Text = "Số lượng còn:  ";
            label7.Text = "Tháng dùng nhiều:  ";
        }

        private void UcQuanLyThuoc_VisibleChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public int GetCurrentIdentify()
        {
            string query = "SELECT IDENT_CURRENT('MEDICINE')";
            string cn = "Data Source=DESKTOP-9DHLIM0;Initial Catalog=QuanLyThuoc;Integrated Security=True";
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(cn))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);

                connection.Close();
            }

            dataGridView3.DataSource = table;

            return Convert.ToInt32(dataGridView3.Rows[0].Cells[0].Value) + 1;
        }
    }
}
