using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineManagement.Views.QuanLyThuoc
{
    public partial class FormAddMedicine : Form
    {
        public FormAddMedicine()
        {
            InitializeComponent();
        }

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
            // code xu ly them moi thuoc
            // ...

            // thong bao thanh cong
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // dong form
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
