using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicineManagement.Controllers;
using MedicineManagement.Models;

namespace MedicineManagement.Views.PhieuNhap
{
    public partial class FormAddInputCoupon : Form
    {
        public FormAddInputCoupon()
        {
            InitializeComponent();
        }

        ControllerInputCoupon ctr1 = new ControllerInputCoupon();
        ControllerInputCouponLine ctr2 = new ControllerInputCouponLine();

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Inputcoupon pn = new Inputcoupon();
            pn.CreateDate = dateTimePicker1.Value;
            pn.ID_Supplier = int.Parse(textBoxMaNCC.Text);
            pn.TotalMoney = decimal.Parse(textBoxTongTien.Text);
            ctr1.Insert(pn);
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Chắc chắn muốn huỷ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                Close();
        }
    }
}
