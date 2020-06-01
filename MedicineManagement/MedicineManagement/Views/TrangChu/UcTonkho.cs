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

namespace MedicineManagement.Views.TrangChu
{
    public partial class UcTonkho : UserControl
    {
        ControllerMedicine ctrl = new ControllerMedicine();
        public UcTonkho()
        {
            InitializeComponent();
        }

        private void UcTonkho_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = ctrl.WarnInventory();
        }
    }
}
