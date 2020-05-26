﻿using System;
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
            form.Show();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
