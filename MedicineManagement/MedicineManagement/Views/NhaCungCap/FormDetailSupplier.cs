using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineManagement.Views.NhaCungCap
{
    public partial class FormDetailSupplier : Form
    {
        public FormDetailSupplier()
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

        // Event
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form form = new NhaCungCap.FormEditSupplier();
            form.ShowDialog();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_title_Paint(object sender, PaintEventArgs e)
        {

        }

        UcNhaCungCap ncc = new UcNhaCungCap();
        
        private void FormDetailSupplier_Load(object sender, EventArgs e)
        {
            
            textBoxMaNCC.Text = UcNhaCungCap.maNCC;
            textBoxTenNCC.Text = UcNhaCungCap.tenNCC;
            textBoxDiaChi.Text = UcNhaCungCap.diaChi;
            textBoxSDT.Text = UcNhaCungCap.sdt;
            textBoxEmail.Text = UcNhaCungCap.email;
        }

        private void textBoxMaNCC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
