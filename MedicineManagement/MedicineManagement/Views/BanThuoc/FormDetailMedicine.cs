using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineManagement.Views.BanThuoc
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
            textBox_MedicineID.Text = UcBanThuoc.medicineID;
            textBox_MedicineName.Text = UcBanThuoc.medicineName;
            textBox_MedicineGroup.Text = UcBanThuoc.medicineGroup;
            textBox_Unit.Text = UcBanThuoc.unit;
            textBox_Price.Text = UcBanThuoc.price;
            textBox_Inventory.Text = UcBanThuoc.inventory;
            textBox_Uses.Text = UcBanThuoc.uses;
            textBox_Note.Text = UcBanThuoc.note;
            textBox_MostUsed.Text = UcBanThuoc.mostUsedMonth;
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
