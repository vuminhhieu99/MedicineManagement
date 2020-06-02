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
        int Total;
        public UcTonkho()
        {
            InitializeComponent();
            bunifuCircleProgressbar1.animated = true;
            Total = 0;
        }

        private void UcTonkho_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = ctrl.WarnInventory(300000);
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
                }
            }
        }

        private void textBox_LimitInventory_TextChanged(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                if (textBox_LimitInventory.Text != "")
                {
                    bunifuCustomDataGrid1.DataSource = ctrl.WarnInventory(Convert.ToInt32(textBox_LimitInventory.Text));
                }
            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int row = e.RowIndex;
            //if (row < 0)
            //{
            //    return;
            //}
            //tb_MaHang.Text = dtgv_MatHang.Rows[row].Cells["txtTotalInventory"].Value.ToString();
            //MaHang = tb_MaHang.Text;

            //if (MaHang != null && MaHang != "")
            //{
            //    ctrl.dsCU.Clear();
            //    ctrl.dsLH.Clear();
            //    dtgv_LoHang.DataSource = ctrl.LoadLoHang(MaHang);
            //    dtgv_CungUng.DataSource = ctrl.LoadCungUng(MaHang);
            //}
            //else
            //{
            //    addMH = true;
            //}

            //tb_TenHang.Text = dtgv_MatHang.Rows[row].Cells["txtTenHang"].Value.ToString();
            //tb_DV.Text = dtgv_MatHang.Rows[row].Cells["txtDvTinh"].Value.ToString();
            //tb_DonGia.Text = dtgv_MatHang.Rows[row].Cells["txtDonGia"].Value.ToString();
            //cb_MaLoai.Text = dtgv_MatHang.Rows[row].Cells["txtMaLoai"].Value.ToString();

            //tb_MaHang_LH.Text = MaHang;
        }
    }
}
