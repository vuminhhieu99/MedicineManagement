using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineManagement.Views.PhieuNhap
{
    public partial class FormDetailInputCoupon : Form
    {
        public FormDetailInputCoupon()
        {
            InitializeComponent();
        }

        private void FormDetailInputCoupon_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            textBoxMaPN.Text = UcPhieuNhap.mapn;
            textBoxMaNCC.Text = UcPhieuNhap.mancc;
            textBoxTongTien.Text = UcPhieuNhap.tongtien;
            dateTimePicker1.Value = UcPhieuNhap.ngaylap;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            FormEditInputCoupon form = new FormEditInputCoupon();
            form.ShowDialog();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
