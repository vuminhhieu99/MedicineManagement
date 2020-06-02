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
    public partial class FormDetailMedicine : Form
    {
        public FormDetailMedicine()
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form form = new QuanLyThuoc.FormEditMedicine();
            form.ShowDialog();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDetailMedicine_Load(object sender, EventArgs e)
        {
            RefreshForm();
            DetailInfo();
        }

        private void RefreshForm()
        {
            textBox_MedicineID.ResetText();
            textBox_MedicineName.ResetText();
            textBox_MedicineGroup.ResetText();
            textBox_Unit.ResetText();
            textBox_Price.ResetText();
            textBox_Inventory.ResetText();
            textBox_Uses.ResetText();
            textBox_Note.ResetText();
            textBox_MostUsed.ResetText();
        }

        private void DetailInfo()
        {
            textBox_MedicineID.Text = UcQuanLyThuoc.medicineID;
            textBox_MedicineName.Text = UcQuanLyThuoc.medicineName;
            textBox_MedicineGroup.Text = UcQuanLyThuoc.medicineGroup;
            textBox_Unit.Text = UcQuanLyThuoc.unit;
            textBox_Price.Text = UcQuanLyThuoc.price;
            textBox_Inventory.Text = UcQuanLyThuoc.inventory;
            textBox_Uses.Text = UcQuanLyThuoc.uses;
            textBox_Note.Text = UcQuanLyThuoc.note;
            textBox_MostUsed.Text = UcQuanLyThuoc.mostUsedMonth;
        }
    }
}
