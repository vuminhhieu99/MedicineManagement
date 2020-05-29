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

namespace MedicineManagement.Views.NhaCungCap
{
    public partial class FormEditSupplier : Form
    {
        public FormEditSupplier()
        {
            InitializeComponent();
        }
        ControllerSupplier ctr = new ControllerSupplier();
        Supplier ncc = new Supplier();
        // Shadow
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // code xu ly sua thong tin
            ncc.ID_Supplier =int.Parse(textBoxMaNCC.Text);
            ncc.Name = textBoxTenNCC.Text;
            ncc.Address = textBoxDiaChi.Text;
            ncc.Phone = textBoxSDT.Text;
            ncc.Email = textBoxEmail.Text;

            ctr.Update(ncc);
            // dong formz
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Chắc chắn muốn huỷ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                Close();
        }

        private void FormEditSupplier_Load(object sender, EventArgs e)
        {
            textBoxMaNCC.Text = UcNhaCungCap.maNCC;
            textBoxTenNCC.Text = UcNhaCungCap.tenNCC;
            textBoxDiaChi.Text = UcNhaCungCap.diaChi;
            textBoxSDT.Text = UcNhaCungCap.sdt;
            textBoxEmail.Text = UcNhaCungCap.email;
        }
    }
}
