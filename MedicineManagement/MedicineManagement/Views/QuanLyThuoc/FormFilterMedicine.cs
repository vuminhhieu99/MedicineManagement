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
    public partial class FormFilterMedicine : Form
    {
        ControllerMedicine ctrl = new ControllerMedicine();
        public static Medicine mdc = new Medicine();

        public FormFilterMedicine()
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

        private void FormFilterMedicine_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            textBox_MedicineID.ResetText();
            textBox_MedicineName.ResetText();
            comboBox_MedicineGroup.ResetText();
            comboBox_Unit.ResetText();
            numericUpDown_PriceFrom.ResetText();
            numericUpDown_PriceTo.ResetText();
            numericUpDown_InventoryFrom.ResetText();
            numericUpDown_InventoryTo.ResetText();
            textBox_MostUsed.ResetText();
        }

        private void textBox_MedicineID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // code xu ly loc thong tin thuoc
            

            mdc.ID_Medicine = -1;
            if (textBox_MedicineID.Text != "")
            {
                mdc.ID_Medicine = Convert.ToInt32(textBox_MedicineID.Text);
            }

            mdc.Name = textBox_MedicineName.Text;
            mdc.Search_MinPrice = numericUpDown_PriceFrom.Value;
            mdc.Search_MaxPrice = numericUpDown_PriceTo.Value;
            mdc.Search_MinTotalInventory = numericUpDown_InventoryFrom.Value;
            mdc.Search_MaxTotalInventory = numericUpDown_InventoryTo.Value;

            // MostUsedMonth: start-end ???
            //mdc.MostUsedMonth = textBox_MostUsed.Text;


            // ?????
            //if (textBox_MostUsed.Text != "")
            //{
            //}

            mdc.MedicineGroup = "";
            if (comboBox_MedicineGroup.SelectedIndex != -1)
            {
                mdc.MedicineGroup = comboBox_MedicineGroup.SelectedItem.ToString();
            }

            mdc.Unit = "";
            if (comboBox_Unit.SelectedIndex != -1)
            {
                mdc.Unit = comboBox_Unit.SelectedItem.ToString();
            }

            // loc thuoc
            UcQuanLyThuoc.medicine = mdc;
            // dong form
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Chắc chắn muốn huỷ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                Close();
        }

        private void textBox_MostUsed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
