using MedicineManagement.Controllers;
using MedicineManagement.Models;
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
    public partial class FormEditMedicine : Form
    {
        ControllerMedicine ctrl = new ControllerMedicine();

        public FormEditMedicine()
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

        private void FormEditMedicine_Load(object sender, EventArgs e)
        {
            RefreshForm();
            DetailInfo();
        }

        private void RefreshForm()
        {
            textBox_MedicineID.ResetText();
            textBox_MedicineName.ResetText();
            comboBox_MedicineGroup.ResetText();
            comboBox_Unit.ResetText();
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
            comboBox_MedicineGroup.Text = UcQuanLyThuoc.medicineGroup;
            comboBox_Unit.Text = UcQuanLyThuoc.unit;
            textBox_Price.Text = UcQuanLyThuoc.price;
            textBox_Inventory.Text = UcQuanLyThuoc.inventory;
            textBox_Uses.Text = UcQuanLyThuoc.uses;
            textBox_Note.Text = UcQuanLyThuoc.note;
            textBox_MostUsed.Text = UcQuanLyThuoc.mostUsedMonth;
        }

        private void textBox_MedicineID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // code xu ly sua thong tin thuoc
            Medicine mdc = new Medicine();

            mdc.ID_Medicine = Convert.ToInt32(textBox_MedicineID.Text);
            mdc.Name = textBox_MedicineName.Text;
            mdc.Uses = textBox_Uses.Text;
            mdc.Price = Convert.ToInt32(textBox_Price.Text);
            mdc.TotalInventory = Convert.ToInt32(textBox_Inventory.Text);
            mdc.Note = textBox_Note.Text;
            mdc.MostUsedMonth = textBox_MostUsed.Text;

            mdc.MedicineGroup = UcQuanLyThuoc.medicineGroup;
            if (comboBox_MedicineGroup.SelectedIndex != -1)
            {
                mdc.MedicineGroup = comboBox_MedicineGroup.SelectedItem.ToString();
            }
            
            mdc.Unit = UcQuanLyThuoc.unit;
            if (comboBox_Unit.SelectedIndex != -1)
            {
                mdc.Unit = comboBox_Unit.SelectedItem.ToString();
            }

            ctrl.Update(mdc);

            // thong bao thanh cong
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
