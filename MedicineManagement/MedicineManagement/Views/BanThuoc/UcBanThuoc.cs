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

namespace MedicineManagement.Views.BanThuoc
{
    public partial class UcBanThuoc : UserControl
    {
        ControllerMedicine ctrlMDC = new ControllerMedicine();
        ControllerPrescription ctrlP = new ControllerPrescription();
        ControllerPrescriptionLine ctrlPL = new ControllerPrescriptionLine();
        Prescription psc = new Prescription();
        Prescriptionline pscl = new Prescriptionline();
        ControllerExport ex = new ControllerExport();


        private int totalRecord = 0;
        private int tempIntoMoney = 0;
        private int totalMoney = 0;

        public static string medicineID;
        public static string medicineName;
        public static string medicineGroup;
        public static string unit;
        public static string uses;
        public static string price;
        public static string inventory;
        public static string note;
        public static string mostUsedMonth;
        public static int amount;

        public UcBanThuoc()
        {
            InitializeComponent();
        }

        private void UcBanThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
            RenewPersciption();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = ctrlMDC.Load();
            totalRecord = dataGridView1.Rows.Count - 1;
            label_CountRecord.Text = totalRecord.ToString() + "/" + totalRecord.ToString() + " bản ghi";
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            RenewPersciption();
            textBox_ID.Text = GetCurrentIdentify().ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lay ID cua ban ghi duoc chon --> chuan bi cho Xem, Tem
                string strID = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                int id = -1;
                if (!strID.Equals(""))
                    id = Convert.ToInt32(strID);

                // Xu ly cac truong hop Xem(detail), Them(add)
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
                        Form form = new BanThuoc.FormDetailMedicine();
                        form.ShowDialog();
                        LoadData();
                    }
                }

                else if (e.ColumnIndex == dataGridView1.Columns["add"].Index)
                {
                    if (id != -1)
                    {
                        // Them thuoc vao don thuoc
                        medicineID = dataGridView1.SelectedCells[0].OwningRow.Cells["_id"].Value.ToString();
                        medicineName = dataGridView1.SelectedCells[0].OwningRow.Cells["_name"].Value.ToString();
                        price = dataGridView1.SelectedCells[0].OwningRow.Cells["_price"].Value.ToString();
                        amount = 1;

                        // Create a new row first as it will include the columns you've created at design-time.

                        int rowId = dataGridView2.Rows.Add();

                        // Grab the new row!
                        DataGridViewRow row = dataGridView2.Rows[rowId];

                        // Add the data
                        row.Cells["_stt"].Value = getSTT();
                        row.Cells["_mathuoc"].Value = medicineID;
                        row.Cells["_tenthuoc"].Value = medicineName;
                        row.Cells["_dongia"].Value = price;
                        row.Cells["_soluong"].Value = amount;
                        row.Cells["_bhyt"].Value = (Convert.ToInt32(price) * Convert.ToInt32(amount) * 0.5);
                        row.Cells["_thanhtien"].Value = (Convert.ToInt32(price) * Convert.ToInt32(amount) - Convert.ToInt32(row.Cells["_bhyt"].Value));

                        // cap nhat tong tien
                        totalMoney = totalMoney + Convert.ToInt32(row.Cells["_thanhtien"].Value);
                        textBox_TotalMoney_ByNum.Text = totalMoney.ToString();
                        textBox_TotalMoney_ByText.Text = ConvertFromNumToText.Convert(totalMoney.ToString());

                    }
                }
            }
        }

        public void putSTT()
        {
            int count = dataGridView2.Rows.Count;
            for (int i = 1; i < count; i++)
            {
                dataGridView2.Rows[i - 1].Cells["_stt"].Value = i.ToString();
            }
        }

        public int getSTT()
        {
            return dataGridView2.Rows.Count - 1;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lay ID cua ban ghi duoc chon --> chuan bi cho Xem, Sua, Xoa
                string strID = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

                // Xu ly cac truong hop Xem(detail), Sua(edit), Xoa(delete)
                if (e.ColumnIndex == dataGridView2.Columns["_soluong"].Index)
                {
                    tempIntoMoney = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["_thanhtien"].Value);
                }
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int price = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["_dongia"].Value);
            int amount = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["_soluong"].Value);
            int bhyt = price * amount / 2; // BHYT 50%

            // cap nhat bhyt
            dataGridView2.Rows[e.RowIndex].Cells["_bhyt"].Value = bhyt;
            // cap nhat thanh tien
            dataGridView2.Rows[e.RowIndex].Cells["_thanhtien"].Value = price * amount - bhyt;

            // cap nhat tong tien don thuoc
            textBox_TotalMoney_ByNum.Text = (Convert.ToInt32(textBox_TotalMoney_ByNum.Text) + Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["_thanhtien"].Value) - tempIntoMoney).ToString();
            textBox_TotalMoney_ByText.Text = ConvertFromNumToText.Convert(textBox_TotalMoney_ByNum.Text);
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
            textBox_Search.ResetText();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctrlMDC.Search(textBox_Search.Text);
            label_CountRecord.Text = CountRecord().ToString() + "/" + totalRecord.ToString() + " bản ghi";
        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            int nullID = dataGridView2.Rows.Count - 1;
            for (int i = 0; i < nullID; i++)
            {
                dataGridView2.Rows[i].Selected = true;
            }
        }

        private void btn_DeleteFromList_Click(object sender, EventArgs e)
        {
            int count = dataGridView2.Rows.Count - 1;
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                if (item.Index < count)
                {
                    tempIntoMoney = Convert.ToInt32(item.Cells["_thanhtien"].Value);
                    dataGridView2.Rows.RemoveAt(item.Index);
                    totalMoney = Convert.ToInt32(textBox_TotalMoney_ByNum.Text) - tempIntoMoney;

                    if (totalMoney != 0)
                    {
                        textBox_TotalMoney_ByNum.Text = totalMoney.ToString();
                        textBox_TotalMoney_ByText.Text = ConvertFromNumToText.Convert(textBox_TotalMoney_ByNum.Text);
                    }
                    else
                    {
                        textBox_TotalMoney_ByNum.ResetText();
                        textBox_TotalMoney_ByText.ResetText();
                    }
                }
            }

            putSTT();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            DataTable table = ctrlPL.Load(textBox_ID.Text);
            
            psc.ID_Prescription = Convert.ToInt32(textBox_ID.Text);
            psc.Doctor = textBox_Doctor.Text;
            psc.CreateDate = dateTimePicker_CreateDate.Value;
            psc.MedicalRecord = Convert.ToInt32(textBox_MedicalRecord.Text);
            psc.TotalMoney = Convert.ToInt32(textBox_TotalMoney_ByNum.Text);

            ex.ExportPrescription(psc, table, "ĐƠN THUỐC");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
          
            // them don thuoc
            psc.Doctor = textBox_Doctor.Text;
            psc.CreateDate = dateTimePicker_CreateDate.Value;
            psc.MedicalRecord = Convert.ToInt32(textBox_MedicalRecord.Text);
            if (textBox_TotalMoney_ByNum.Text != "")
                psc.TotalMoney = Convert.ToInt32(textBox_TotalMoney_ByNum.Text);

            ctrlP.Insert(psc);
            pscl.ID_Prescription = Convert.ToInt32(textBox_ID.Text);

            // them dong don thuoc
            int numRows = dataGridView2.Rows.Count;
            for (int i = 1; i < numRows; i++)
            {
                
                pscl.ID_Medicine = Convert.ToInt32(dataGridView2.Rows[i - 1].Cells["_mathuoc"].Value);
                pscl.Amount = Convert.ToInt32(dataGridView2.Rows[i - 1].Cells["_soluong"].Value);
                pscl.HealthInsurance = Convert.ToInt32(dataGridView2.Rows[i - 1].Cells["_bhyt"].Value);

                ctrlPL.Insert(pscl);
            }

            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Chắc chắn muốn huỷ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                RenewPersciption();
                textBox_ID.Text = GetCurrentIdentify().ToString();
            }
        }

        public int CountRecord()
        {
            return dataGridView1.Rows.Count - 1;
        }

        private void UcBanThuoc_VisibleChanged(object sender, EventArgs e)
        {
            LoadData();
            RenewPersciption();
            textBox_ID.Text = GetCurrentIdentify().ToString();
        }

        public void RenewPersciption()
        {
            label_UserName.Text = ControllerBase.userInfo.UserName.ToUpper();
            label_UserAddress.Text = ControllerBase.userInfo.UserAddress;
            textBox_ID.ResetText();
            textBox_Doctor.ResetText();
            textBox_TotalMoney_ByNum.ResetText();
            textBox_TotalMoney_ByText.ResetText();
            dateTimePicker_CreateDate.Value = DateTime.Now;
            textBox_MedicalRecord.ResetText();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
        }


        private void textBox_MedicelRecord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public int GetCurrentIdentify()
        {
            string query = "SELECT IDENT_CURRENT('PRESCRIPTION')";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
