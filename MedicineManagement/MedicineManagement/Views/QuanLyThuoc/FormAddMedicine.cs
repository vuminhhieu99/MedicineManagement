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
    public partial class FormAddMedicine : Form
    {
        ControllerMedicine ctrl = new ControllerMedicine();

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
            // code xu ly them thuoc moi
            Medicine mdc = new Medicine();

            //mdc.ID_Medicine = Convert.ToInt32(textBox_MedicineID.Text);
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

            ctrl.Insert(mdc);

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

        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void FormAddMedicine_VisibleChanged(object sender, EventArgs e)
        {
            textBox_MedicineID.Text = UcQuanLyThuoc.medicineID;
        }
    }
}
