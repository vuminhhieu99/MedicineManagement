using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicineManagement.Controllers;
using MedicineManagement.Models;

namespace MedicineManagement.Views.CaiDat
{
    public partial class UcCaiDat : UserControl
    {
        ControllerUserInfo ctrl = new ControllerUserInfo();

        public UcCaiDat()
        {
            InitializeComponent();
        }

        // Delegate
        public Delegate userFunctionPointer;
        //

        private void UcCaiDat_VisibleChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            EnableType(false);
            textBox_UserName.Text = ControllerBase.userInfo.UserName;
            textBox_UserAddress.Text = ControllerBase.userInfo.UserAddress;
            textBox_UserEmail.Text = ControllerBase.userInfo.UserEmail;
            textBox_UserPhone.Text = ControllerBase.userInfo.UserPhone;
            textBox_CreateDate.Text = $"{ControllerBase.userInfo.CreateDate.Day}/{ControllerBase.userInfo.CreateDate.Month}/{ControllerBase.userInfo.CreateDate.Year}";
        }

        public void EnableType(bool logic)
        {
            if (logic == true)
            {
                textBox_UserName.ReadOnly = false;
                textBox_UserAddress.ReadOnly = false;
                textBox_UserEmail.ReadOnly = false;
                textBox_UserPhone.ReadOnly = false;
                btn_Update.Visible = false;
                btn_Save.Visible = true;
                btn_Cancel.Visible = true;
            }
            else
            {
                textBox_UserName.ReadOnly = true;
                textBox_UserAddress.ReadOnly = true;
                textBox_UserEmail.ReadOnly = true;
                textBox_UserPhone.ReadOnly = true;
                btn_Update.Visible = true;
                btn_Save.Visible = false;
                btn_Cancel.Visible = false;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            EnableType(true);
            textBox_CreateDate.Text = $"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ControllerBase.userInfo.UserName = textBox_UserName.Text;
            ControllerBase.userInfo.UserAddress = textBox_UserAddress.Text;
            ControllerBase.userInfo.UserEmail = textBox_UserEmail.Text;
            ControllerBase.userInfo.UserPhone = textBox_UserPhone.Text;
            ControllerBase.userInfo.CreateDate = DateTime.Now;

            ctrl.Update(ControllerBase.userInfo);
            EnableType(false);

            //delegate
            userFunctionPointer.DynamicInvoke();
            //

            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Chắc chắn muốn huỷ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                EnableType(false);
                textBox_UserName.Text = ControllerBase.userInfo.UserName;
                textBox_UserAddress.Text = ControllerBase.userInfo.UserAddress;
                textBox_UserEmail.Text = ControllerBase.userInfo.UserEmail;
                textBox_UserPhone.Text = ControllerBase.userInfo.UserPhone;
                textBox_CreateDate.Text = $"{ControllerBase.userInfo.CreateDate.Day}/{ControllerBase.userInfo.CreateDate.Month}/{ControllerBase.userInfo.CreateDate.Year}";
            }
        }
    }
}
