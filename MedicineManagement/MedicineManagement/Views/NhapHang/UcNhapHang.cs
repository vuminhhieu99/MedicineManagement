﻿using System;
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
using MedicineManagement.Views.PhieuNhap;

namespace MedicineManagement.Views.NhapHang
{
    public partial class UcNhapHang : UserControl
    {
        public UcNhapHang()
        {
            InitializeComponent();
        }
        ControllerInputCouponLine ctrdpn = new ControllerInputCouponLine();
        ControllerMedicine ctrt = new ControllerMedicine();
        ControllerInputCoupon ctrpn = new ControllerInputCoupon();
        Inputcoupon pn = new Inputcoupon();

        Inputcouponline dpn = new Inputcouponline();

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctrt.Load();
            string recordOld = (dataGridView1.Rows.Count - 1).ToString();
            dataGridView1.DataSource = ctrt.Search(textBoxSearch.Text);
            string recordNew = (dataGridView1.Rows.Count - 1).ToString();
            label_CountRecord.Text = recordNew + "/" + recordOld;
        }

        private void UcNhapHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctrt.Load();
            //dataGridView2.DataSource = ctrdpn.Load();

            label_CountRecord.Text = (dataGridView1.Rows.Count - 1).ToString() + "/" + (dataGridView1.Rows.Count - 1).ToString();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctrt.Load();
            label_CountRecord.Text = (dataGridView1.Rows.Count - 1).ToString() + "/" + (dataGridView1.Rows.Count - 1).ToString();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            FormAddInputCoupon form = new FormAddInputCoupon();
            form.ShowDialog();
            //lấy mã phiếu nhập mới nhập vào
            try
            {
                DataTable datatb = new DataTable();
                datatb = ctrpn.Load();
                int index = datatb.Rows.Count - 1;
                textBoxMaPN.Text = datatb.Rows[index][0].ToString();

                textBoxTongTienSo.Text = FormAddInputCoupon.tongtien;
                textBoxMaNCC.Text = FormAddInputCoupon.maNCC;
                dateTimePicker1.Value = (DateTime)FormAddInputCoupon.ngaylap;
            }
            catch (Exception)
            {

            }
        }
        int index;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            index = e.RowIndex;
            int SumMoney = 0;
            int length = dataGridView2.Rows.Count;
            try
            {
                if (e.ColumnIndex == dataGridView1.Columns["add"].Index)
                {
                    dpn.ID_Medicine = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                    dpn.Name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    dpn.Price = int.Parse(dataGridView1.Rows[index].Cells[3].Value.ToString());
                    dpn.ID_InputCoupon = int.Parse(textBoxMaPN.Text);
                    ctrdpn.Insert(dpn);

                    dataGridView2.DataSource = ctrdpn.Load(textBoxMaPN.Text);
                    //gán lại độ dài sau khi thêm
                    length = dataGridView2.Rows.Count;
                    for (int i = 0; i < length - 1; i++)
                    {
                        SumMoney += int.Parse(dataGridView2.Rows[i].Cells["intoMoney"].Value.ToString());
                    }

                    textBoxTongTienSo.Text = SumMoney.ToString();
                    textBoxTongTienChu.Text = ConvertFromNumToText.Convert(textBoxTongTienSo.Text);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm Phiếu mới trước khi thêm thuốc!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int SumMoney = 0;
            int length = dataGridView2.Rows.Count;
            try
            {


                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    dpn.ID_InputCoupon = int.Parse(textBoxMaPN.Text);
                    dpn.ID_InputCouponLine = int.Parse(dataGridView2.Rows[i].Cells["maDPN"].Value.ToString());
                    dpn.ID_Medicine = int.Parse(dataGridView2.Rows[i].Cells["maThuoc"].Value.ToString());
                    dpn.Name = dataGridView2.Rows[i].Cells["tenThuoc"].Value.ToString();
                    dpn.UnitInput = dataGridView2.Rows[i].Cells["donViNhap"].Value.ToString();
                    dpn.Amount = int.Parse(dataGridView2.Rows[i].Cells["soLuong"].Value.ToString());
                    dpn.Price = decimal.Parse(dataGridView2.Rows[i].Cells["donGia"].Value.ToString());
                    dpn.ExpiryDate = (DateTime)dataGridView2.Rows[i].Cells["hanSD"].Value;
                    dpn.NumUnitOutput = int.Parse(dataGridView2.Rows[i].Cells["NumUnitOutput"].Value.ToString());
                    ctrdpn.Update(dpn);
                }
                dataGridView2.DataSource = ctrdpn.Load(textBoxMaPN.Text);
                //gán lại độ dài sau khi load xong
                length = dataGridView2.Rows.Count;
                for (int i = 0; i < length - 1; i++)
                {
                    SumMoney += int.Parse(dataGridView2.Rows[i].Cells["intoMoney"].Value.ToString());
                }

                textBoxTongTienSo.Text = SumMoney.ToString();
                textBoxTongTienChu.Text = ConvertFromNumToText.Convert(textBoxTongTienSo.Text);

                pn.ID_InputCoupon = int.Parse(textBoxMaPN.Text);
                pn.ID_Supplier = int.Parse(textBoxMaNCC.Text);
                pn.CreateDate = dateTimePicker1.Value.Date;
                pn.TotalMoney = decimal.Parse(textBoxTongTienSo.Text);
                ctrpn.Update(pn);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa Thất Bại! Kiểm tra lại điền đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            int length = dataGridView2.Rows.Count;
            DialogResult dlr = MessageBox.Show("Bạn có Chắc Chắn Xóa ?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            try
            {
                if (dlr == DialogResult.Yes)
                {
                    for (int i = 0; i < length - 1; i++)
                    {
                        ctrdpn.DeleteOnInputCoupon(textBoxMaPN.Text);
                    }
                }
                dataGridView2.DataSource = ctrdpn.Load(textBoxMaPN.Text);

                int SumMoney = 0;
                //gán lại độ dài sau khi load xong
                length = dataGridView2.Rows.Count;
                for (int i = 0; i < length - 1; i++)
                {
                    SumMoney += int.Parse(dataGridView2.Rows[i].Cells["intoMoney"].Value.ToString());
                }

                textBoxTongTienSo.Text = SumMoney.ToString();
                textBoxTongTienChu.Text = ConvertFromNumToText.Convert(textBoxTongTienSo.Text);

                MessageBox.Show("Xoá Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xoá Thất Bại!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int length = dataGridView2.Rows.Count - 1;
            DialogResult dlr = MessageBox.Show("Bạn có Chắc Chắn Xóa ?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            try
            {
                foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
                {
                    if (item.Index < length && dlr == DialogResult.Yes)
                    {
                        ctrdpn.Delete(dataGridView2.Rows[item.Index].Cells["maDPN"].Value.ToString());
                    }
                }
                dataGridView2.DataSource = ctrdpn.Load(textBoxMaPN.Text);

                int SumMoney = 0;
                //gán lại độ dài sau khi load xong
                length = dataGridView2.Rows.Count - 1;
                for (int i = 0; i < length; i++)
                {
                    SumMoney += int.Parse(dataGridView2.Rows[i].Cells["intoMoney"].Value.ToString());
                }

                textBoxTongTienSo.Text = SumMoney.ToString();
                textBoxTongTienChu.Text = ConvertFromNumToText.Convert(textBoxTongTienSo.Text);

                MessageBox.Show("Xoá Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá Thất Bại!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private void UcNhapHang_VisibleChanged(object sender, EventArgs e)
        {
            label_UserName.Text = ControllerBase.userInfo.UserName.ToUpper();
            label_UserAddress.Text = ControllerBase.userInfo.UserAddress;
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            ControllerExport export = new ControllerExport();


            DataTable table = ctrdpn.Load(textBoxMaPN.Text);

            pn.ID_InputCoupon = Convert.ToInt32(textBoxMaPN.Text);
            pn.CreateDate = dateTimePicker1.Value;
            pn.ID_Supplier = Convert.ToInt32(textBoxMaNCC.Text);
            pn.TotalMoney = Convert.ToInt32(textBoxTongTienSo.Text);

            export.ExportInputCoupon(pn, table, "PHIEU NHAP");

        }
    }
}
