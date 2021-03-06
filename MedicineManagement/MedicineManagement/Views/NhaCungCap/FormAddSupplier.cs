﻿using System;
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
    public partial class FormAddSupplier : Form
    {
        public FormAddSupplier()
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
            // code xu ly them moi nha cung cap
            ncc.Name = textBoxTenNCC.Text;
            ncc.Address = textBoxDiaChi.Text;
            ncc.Phone = textBoxSDT.Text;
            ncc.Email = textBoxEmail.Text;
            ctr.Insert(ncc);

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
