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

namespace MedicineManagement.Views.DonThuoc
{
    public partial class UcDonThuoc : UserControl
    {
        ControllerPrescription ctrlP = new ControllerPrescription();
        ControllerPrescriptionLine ctrlPL = new ControllerPrescriptionLine();
        Prescription psc = new Prescription();
        Prescriptionline pscl = new Prescriptionline();
        ControllerExport ex = new ControllerExport();

        private int totalRecord = 0;
        private int tempIntoMoney = 0;

        public UcDonThuoc()
        {
            InitializeComponent();
        }

        private void UcDonThuoc_Load(object sender, EventArgs e)
        {
            LoadDataPrescription();
        }

        public void LoadDataPrescription()
        {
            label_UserName.Text = ControllerBase.userInfo.UserName.ToUpper();
            label_UserAddress.Text = ControllerBase.userInfo.UserAddress;
            textBox_Search.ResetText();
            dataGridView1.DataSource = ctrlP.Load();
            totalRecord = dataGridView1.Rows.Count - 1;
            label_CountRecord.Text = totalRecord.ToString() + "/" + totalRecord.ToString() + " bản ghi";
            btn_Save.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Save.Visible = false;
            if (e.RowIndex >= 0)
            {
                // Lay ID cua ban ghi duoc chon --> chuan bi cho Xem, Sua, Xoa
                string strID = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

                // Xu ly cac truong hop Xem(detail), Sua(edit), Xoa(delete)
                if (e.ColumnIndex == dataGridView1.Columns["detail"].Index)
                {
                    RenewPersciption();
                    SetVisibleVirtualColumns(false);
                    SetEnableEditPrescription(false);
                    dataGridView2.DataSource = ctrlPL.Load(strID);
                    dataGridView2.Columns["Mã đơn thuốc"].Visible = false;
                    dataGridView2.Columns["Mã thuốc"].Visible = false;

                    int numRows = dataGridView2.Rows.Count;
                    for (int i = 1; i < numRows; i++)
                    {
                        dataGridView2.Rows[i - 1].Cells["_stt"].Value = i;
                    }

                    btn_Save.Visible = false;

                    textBox_ID.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["_id"].Value.ToString();
                    textBox_Doctor.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["_doctor"].Value.ToString();
                    dateTimePicker_CreateDate.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["_createDate"].Value.ToString();
                    textBox_MedicalRecord.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["_medicalRecord"].Value.ToString();
                    textBox_TotalMoney_ByNum.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["_totalMoney"].Value.ToString();
                    if (textBox_TotalMoney_ByNum.Text != "")
                        textBox_TotalMoney_ByText.Text = ConvertFromNumToText.Convert(textBox_TotalMoney_ByNum.Text);
                }
                else if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
                {
                    RenewPersciption();
                    SetVisibleVirtualColumns(false);
                    SetEnableEditPrescription(true);
                    dataGridView2.DataSource = ctrlPL.Load(strID);
                    dataGridView2.Columns["Mã đơn thuốc"].Visible = false;
                    dataGridView2.Columns["Mã thuốc"].Visible = false;

                    int numRows = dataGridView2.Rows.Count;
                    for (int i = 1; i < numRows; i++)
                    {
                        dataGridView2.Rows[i - 1].Cells["_stt"].Value = i;
                    }

                    btn_Save.Visible = true;

                    textBox_ID.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["_id"].Value.ToString();
                    textBox_Doctor.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["_doctor"].Value.ToString();
                    dateTimePicker_CreateDate.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["_createDate"].Value.ToString();
                    textBox_MedicalRecord.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["_medicalRecord"].Value.ToString();
                    textBox_TotalMoney_ByNum.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["_totalMoney"].Value.ToString();
                    if (textBox_TotalMoney_ByNum.Text != "")
                        textBox_TotalMoney_ByText.Text = ConvertFromNumToText.Convert(textBox_TotalMoney_ByNum.Text);

                    // cho phep sua so luong thuoc
                    dataGridView2.Columns["Số lượng"].ReadOnly = false; 

                }
                else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index)
                {
                    DialogResult dlr = MessageBox.Show("Chắc chắn xoá ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        // Code xu ly xoa don thuoc
                        ctrlP.Delete(strID);
                        MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataPrescription();
                    }
                }
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lay ID cua ban ghi duoc chon --> chuan bi cho Xem, Sua, Xoa
                string strID = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

                // Xu ly cac truong hop Xem(detail), Sua(edit), Xoa(delete)
                if (e.ColumnIndex == dataGridView2.Columns[11].Index)
                {
                    tempIntoMoney = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[13].Value);
                }
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int price = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[10].Value);
            int amount = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[11].Value);
            //int bhyt = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[12].Value);

            int bhyt = price * amount / 2; // BHYT 50%

            // cap nhat bhyt
            dataGridView2.Rows[e.RowIndex].Cells[12].Value = bhyt;
            // cap nhat thanh tien
            dataGridView2.Rows[e.RowIndex].Cells[13].Value = price * amount - bhyt;
            // cap nhat trang thai row (1:can cap nhat | #1:khong can cap nhat)
            dataGridView2.Rows[e.RowIndex].Cells["_status"].Value = 1;

            // cap nhat tong tien don thuoc
            textBox_TotalMoney_ByNum.Text = (Convert.ToInt32(textBox_TotalMoney_ByNum.Text) + Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[13].Value) - tempIntoMoney).ToString();
            textBox_TotalMoney_ByText.Text = ConvertFromNumToText.Convert(textBox_TotalMoney_ByNum.Text);
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadDataPrescription();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctrlP.Search(textBox_Search.Text);
            label_CountRecord.Text = CountRecord().ToString() + "/" + totalRecord.ToString() + " bản ghi";
        }

        private void btn_Renew_Click(object sender, EventArgs e)
        {
            RenewPersciption();
            SetEnableEditPrescription(false);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            dataGridView2.Columns["Số lượng"].ReadOnly = true; // khong cho phep sua nua

            string strTotalMoney = textBox_TotalMoney_ByNum.Text;

            //Prescription psc = new Prescription();
            //Prescriptionline pscl = new Prescriptionline();
          
            int numRows = dataGridView2.Rows.Count;

            // update dong don thhuoc
            for (int i = 1; i < numRows; i++)
            {
                if (Convert.ToInt32(dataGridView2.Rows[i - 1].Cells["_status"].Value) == 1)
                {
                    pscl.ID_Prescription = Convert.ToInt32(dataGridView2.Rows[i - 1].Cells["Mã đơn thuốc"].Value); ;
                    pscl.ID_Medicine = Convert.ToInt32(dataGridView2.Rows[i - 1].Cells["Mã thuốc"].Value); ;
                    pscl.Amount = Convert.ToInt32(dataGridView2.Rows[i - 1].Cells["Số lượng"].Value);
                    pscl.HealthInsurance = Convert.ToInt32(dataGridView2.Rows[i - 1].Cells["BHYT"].Value);

                    ctrlPL.Update(pscl);
                }
            }

            // update don thuoc
            psc.ID_Prescription = Convert.ToInt32(textBox_ID.Text);
            psc.Doctor = textBox_Doctor.Text;
            psc.MedicalRecord = Convert.ToInt32(textBox_MedicalRecord.Text);
            psc.CreateDate = dateTimePicker_CreateDate.Value;
            psc.TotalMoney = Convert.ToInt32(textBox_TotalMoney_ByNum.Text);

            ctrlP.Update(psc);

            // thong bao thanh cong
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Load lai thong tin don thuoc sau khi chinh sua

            // reload DS don thuoc
            LoadDataPrescription();
            // reload DS thuoc trong don thuoc
            RenewPersciption();
            SetVisibleVirtualColumns(false);
            SetEnableEditPrescription(false);
            dataGridView2.DataSource = ctrlPL.Load(psc.ID_Prescription.ToString());
            dataGridView2.Columns["Mã đơn thuốc"].Visible = false;
            dataGridView2.Columns["Mã thuốc"].Visible = false;

            int num = dataGridView2.Rows.Count;
            for (int j = 1; j < num; j++)
            {
                dataGridView2.Rows[j - 1].Cells["_stt"].Value = j;
            }
            // reload thong tin don thuoc
            textBox_ID.Text = psc.ID_Prescription.ToString();
            textBox_Doctor.Text = psc.Doctor;
            dateTimePicker_CreateDate.Value = psc.CreateDate;
            textBox_MedicalRecord.Text = psc.MedicalRecord.ToString();
            textBox_TotalMoney_ByNum.Text = strTotalMoney;
            if (textBox_TotalMoney_ByNum.Text != "")
                textBox_TotalMoney_ByText.Text = ConvertFromNumToText.Convert(strTotalMoney);


            btn_Save.Visible = false;
        }

        private void UcDonThuoc_VisibleChanged(object sender, EventArgs e)
        {
            LoadDataPrescription();
            SetVisibleVirtualColumns(true);
            RenewPersciption();
            SetEnableEditPrescription(false);
        }

        public int CountRecord()
        {
            return dataGridView1.Rows.Count - 1;
        }

        private void textBox_MedicalRecord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public void RenewPersciption()
        {
            textBox_ID.ResetText();
            textBox_Doctor.ResetText();
            textBox_TotalMoney_ByNum.ResetText();
            textBox_TotalMoney_ByText.ResetText();
            dateTimePicker_CreateDate.Value = DateTime.Now;
            textBox_MedicalRecord.ResetText();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            SetVisibleVirtualColumns(true);
            dataGridView2.ReadOnly = true;
        }

        public void SetVisibleVirtualColumns(bool logic)
        {
            if (logic == true)
            {
                dataGridView2.Columns["_tenthuoc"].Visible = true;
                dataGridView2.Columns["_dongia"].Visible = true;
                dataGridView2.Columns["_soluong"].Visible = true;
                dataGridView2.Columns["_BHYT"].Visible = true;
                dataGridView2.Columns["_thanhtien"].Visible = true;
            }
            else
            {
                dataGridView2.Columns["_tenthuoc"].Visible = false;
                dataGridView2.Columns["_dongia"].Visible = false;
                dataGridView2.Columns["_soluong"].Visible = false;
                dataGridView2.Columns["_BHYT"].Visible = false;
                dataGridView2.Columns["_thanhtien"].Visible = false;
            }
        }

        public void SetEnableEditPrescription(bool logic)
        {
            if (logic == true)
            {
                textBox_Doctor.ReadOnly = false;
                dateTimePicker_CreateDate.Enabled = true;
                textBox_MedicalRecord.ReadOnly = false;
                dataGridView2.ReadOnly = false;
            }
            else
            {
                textBox_Doctor.ReadOnly = true;
                dateTimePicker_CreateDate.Enabled = false;
                textBox_MedicalRecord.ReadOnly = true;
                dataGridView2.ReadOnly = true;
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            DataTable table = ctrlPL.Load(textBox_ID.Text);

            psc.ID_Prescription = Convert.ToInt32(textBox_ID.Text);
            psc.Doctor = textBox_Doctor.Text;
            psc.CreateDate = dateTimePicker_CreateDate.Value;
            psc.MedicalRecord = Convert.ToInt32(textBox_MedicalRecord.Text);
            psc.TotalMoney = Convert.ToInt32(textBox_TotalMoney_ByNum.Text);

            ex.ExportPrescription2(psc, table, "ĐƠN THUỐC");
        }
    }
}
