using MedicineManagement.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicineManagement.Models;

namespace MedicineManagement.Views.PhieuNhap
{
    public partial class FormEditInputCoupon : Form
    {
        ControllerInputCoupon ctr = new ControllerInputCoupon();
        Inputcoupon pn = new Inputcoupon();
        public FormEditInputCoupon()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            pn.ID_InputCoupon = int.Parse(textBoxMaPN.Text);
            pn.ID_Supplier = int.Parse(textBoxMaNCC.Text);
            pn.CreateDate = dateTimePicker1.Value.Date;
            pn.TotalMoney = decimal.Parse(textBoxTongTien.Text);
            ctr.Update(pn);
            Close();
        }

        private void FormEditInputCoupon_Load(object sender, EventArgs e)
        {
            textBoxMaPN.Text = UcPhieuNhap.mapn;
            textBoxMaNCC.Text = UcPhieuNhap.mancc;
            textBoxTongTien.Text = UcPhieuNhap.tongtien;
            dateTimePicker1.Value = UcPhieuNhap.ngaylap;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
