﻿using MedicineManagement.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineManagement
{
    delegate int ShowUserInfo(int m);

    public partial class FormMain : Form
    {
        ControllerUserInfo ctrlUser = new ControllerUserInfo();

        public FormMain()
        {
            InitializeComponent();

            formFunctionPointer += new functioncall(ShowUserInfoInLayout);
            ucCaiDat1.userFunctionPointer = formFunctionPointer;
        }

        // Delegate
        public delegate void functioncall();
        private event functioncall formFunctionPointer;
        //

        public void ShowUserInfoInLayout()
        {
            labelUserName.Text = ControllerBase.userInfo.UserName;
            labelUserAddress.Text = ControllerBase.userInfo.UserAddress;
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


        // Events
        private void Form1_Load(object sender, EventArgs e)
        {
            getUserInfo();
            timer1.Start();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeDateTime.Text = DateTime.Now.ToLongTimeString() + "   ●   " + DateTime.Now.ToShortDateString();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton btn = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            ChangeTitle(btn.Text.TrimStart());
            InVisibleAllUserControl();
            if (btn == btn_TrangChu)
            {
                ucTrangChu1.Visible = true;
            }
            else if (btn == btn_BanThuoc)
            {
                ucBanThuoc1.Visible = true;
            }
            else if (btn == btn_QuanLyThuoc)
            {
                ucQuanLyThuoc1.Visible = true;
            }
            else if (btn == btn_NhapHang)
            {
                ucNhapHang1.Visible = true;
            }
            else if (btn == btn_PhieuNhap)
            {
                ucPhieuNhap1.Visible = true;
            }
            else if (btn == btn_DonThuoc)
            {
                ucDonThuoc1.Visible = true;
            }
            else if (btn == btn_NhaCungCap)
            {
                ucNhaCungCap1.Visible = true;
            }
            else if (btn == btn_CaiDat)
            {
                ucCaiDat1.Visible = true;
            }
            else
            {
                ucThongTin1.Visible = true;
            }
        }

        // Methods
        public void ChangeTitle(string title)
        {
            labelTask.Text = title;
        }

        public void InVisibleAllUserControl()
        {
            ucTrangChu1.Visible = false;
        
              ucBanThuoc1.Visible = false;
            ucQuanLyThuoc1.Visible = false;
            ucNhapHang1.Visible = false;
            ucPhieuNhap1.Visible = false;
            ucDonThuoc1.Visible = false;
            ucNhaCungCap1.Visible = false;
            ucCaiDat1.Visible = false;
            ucThongTin1.Visible = false;
        }

        public void getUserInfo()
        {
            dataGridViewUser.DataSource = ctrlUser.Load();
        
            ControllerBase.userInfo.UserName = dataGridViewUser.Rows[0].Cells["UserName"].Value.ToString();
            ControllerBase.userInfo.UserAddress = dataGridViewUser.Rows[0].Cells["UserAddress"].Value.ToString();
            ControllerBase.userInfo.UserEmail = dataGridViewUser.Rows[0].Cells["UserEmail"].Value.ToString();
            ControllerBase.userInfo.UserPhone = dataGridViewUser.Rows[0].Cells["UserPhone"].Value.ToString();
            ControllerBase.userInfo.CreateDate = (DateTime)dataGridViewUser.Rows[0].Cells["CreateDate"].Value;
            DateTime createDate = (DateTime)dataGridViewUser.Rows[0].Cells["CreateDate"].Value;

            ShowUserInfoInLayout();
        }

        private void ucTrangChu1_Load(object sender, EventArgs e)
        {

        }
    }
}
