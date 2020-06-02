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

namespace MedicineManagement.Views.NhapHang
{
    public partial class UcNhapHang : UserControl
    {
        public UcNhapHang()
        {
            InitializeComponent();
        }

        private void UcNhapHang_VisibleChanged(object sender, EventArgs e)
        {
            label_UserName.Text = ControllerBase.userInfo.UserName.ToUpper();
            label_UserAddress.Text = ControllerBase.userInfo.UserAddress;
        }
    }
}
