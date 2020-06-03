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

namespace MedicineManagement.Views.PhieuNhap
{
    public partial class UcPhieuNhap : UserControl
    {
        public UcPhieuNhap()
        {
            InitializeComponent();
        }
        public static string mapn, mancc, tongtien;
        public static DateTime ngaylap;
        ControllerInputCoupon ctr1 = new ControllerInputCoupon();
        ControllerInputCouponLine ctr2 = new ControllerInputCouponLine();
        Inputcouponline dpn = new Inputcouponline();
        Inputcoupon pn = new Inputcoupon();

        private void UcPhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctr1.Load();
            label_CountRecord.Text = (dataGridView1.Rows.Count - 1).ToString() + "/" + (dataGridView1.Rows.Count - 1).ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int index;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            index = e.RowIndex;
            if (e.ColumnIndex == dataGridView1.Columns["detail"].Index)
            {

                mapn = dataGridView1.Rows[index].Cells[0].Value.ToString();
                mancc = dataGridView1.Rows[index].Cells[1].Value.ToString();
                ngaylap = (DateTime)dataGridView1.Rows[index].Cells[2].Value;
                tongtien = dataGridView1.Rows[index].Cells[3].Value.ToString();

                FormDetailInputCoupon form = new FormDetailInputCoupon();
                form.ShowDialog();

                dataGridView1.DataSource = ctr1.Load();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
            {

                mapn = dataGridView1.Rows[index].Cells[0].Value.ToString();
                mancc = dataGridView1.Rows[index].Cells[1].Value.ToString();
                ngaylap = (DateTime)dataGridView1.Rows[index].Cells[2].Value;
                tongtien = dataGridView1.Rows[index].Cells[3].Value.ToString();

                FormEditInputCoupon form = new FormEditInputCoupon();
                form.ShowDialog();

                dataGridView1.DataSource = ctr1.Load();

            }
            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index)
            {
                DialogResult dlr = MessageBox.Show("Bạn Chắc chắn xóa ?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    ctr1.Delete(dataGridView1.Rows[index].Cells[0].Value.ToString());
                    dataGridView1.DataSource = ctr1.Load();
                }

            }

        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctr1.Load();
            label_CountRecord.Text = dataGridView1.Rows.Count.ToString() + "/" + dataGridView1.Rows.Count.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                int index = e.RowIndex;
                string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                dataGridView2.DataSource = ctr2.Load(id);

                textBoxMaPN.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                textBoxMaNCC.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                DateTime date = (DateTime)dataGridView1.Rows[index].Cells[2].Value;
                dateTimePicker1.Value = date;
                textBoxTongTienSo.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                textBoxTongTienChu.Text = ConvertFromNumToText.Convert(textBoxTongTienSo.Text);
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
                    ctr2.Update(dpn);
                }
                dataGridView2.DataSource = ctr2.Load(textBoxMaPN.Text);

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
                ctr1.Update(pn);

                dataGridView1.DataSource = ctr1.Load();

                MessageBox.Show("Sửa Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Sửa Thất Bại!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void label_CountRecord_Click(object sender, EventArgs e)
        {

        }

        private void UcPhieuNhap_VisibleChanged(object sender, EventArgs e)
        {
            label_UserName.Text = ControllerBase.userInfo.UserName.ToUpper();
            label_UserAddress.Text = ControllerBase.userInfo.UserAddress;
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            ControllerExport export = new ControllerExport();


            DataTable table = ctr2.Load(textBoxMaPN.Text);

            pn.ID_InputCoupon = Convert.ToInt32(textBoxMaPN.Text);
            pn.CreateDate = dateTimePicker1.Value;
            pn.ID_Supplier = Convert.ToInt32(textBoxMaNCC.Text);
            pn.TotalMoney = Convert.ToInt32(textBoxTongTienSo.Text);

            export.ExportInputCoupon(pn, table, "PHIEU NHAP");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctr1.Load();
            string recordOld = (dataGridView1.Rows.Count - 1).ToString();
            dataGridView1.DataSource = ctr1.Search(textBoxSearch.Text);
            string recordNew = (dataGridView1.Rows.Count - 1).ToString();
            label_CountRecord.Text = recordNew + "/" + recordOld;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            FormAddInputCoupon form = new FormAddInputCoupon();
            form.ShowDialog();

            dataGridView1.DataSource = ctr1.Load();
        }
    }
}
