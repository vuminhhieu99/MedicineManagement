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

namespace MedicineManagement.Views.TrangChu
{
    public partial class UcTrangChu : UserControl
    {
        ControllerStatistics ctrl = new ControllerStatistics();
        
        public UcTrangChu()
        {
            InitializeComponent();
            button_ImportMedicine.Text = "Dự báo nhập thuốc tháng " + DateTime.Now.AddMonths(1).Month;
            
        }

        

        private void UcTrangChu_Load(object sender, EventArgs e)
        {
            Chart tevenueDay = ctrl.Tevenue(DateTime.Parse(DateTime.Now.ToShortDateString()), DateTime.Parse(DateTime.Now.ToShortDateString()), DateStatistics.NGAY);
            label_MedicalRecordCountToDay.Text = tevenueDay.Counting.ToString();
            long TotalMoneyToDay = 0;
            for (int i=0; i< tevenueDay.ColumnCount; i++)
            {
                TotalMoneyToDay += tevenueDay.ListColumn[i].value;
            }
            label_TotalMoneyToDay.Text = TotalMoneyToDay.ToString();

            Chart tevenueMonth = ctrl.Tevenue(DateTime.Parse(DateTime.Now.ToShortDateString()), DateTime.Parse(DateTime.Now.ToShortDateString()), DateStatistics.THANG);
            label_MedicalRecordCountToMonth.Text = tevenueMonth.Counting.ToString();
            long TotalMoneyToMonth = 0;
            for (int i = 0; i < tevenueMonth.ColumnCount; i++)
            {
                TotalMoneyToMonth += tevenueMonth.ListColumn[i].value;
            }
            label_TotalMoneyToMonth.Text = TotalMoneyToMonth.ToString();
            

            Chart tevenueYear = ctrl.Tevenue(DateTime.Parse(DateTime.Now.ToShortDateString()), DateTime.Parse(DateTime.Now.ToShortDateString()), DateStatistics.NAM);
            label_MedicalRecordCountToYear.Text = tevenueYear.Counting.ToString();
            long TotalMoneyToYear = 0;
            for (int i = 0; i < tevenueMonth.ColumnCount; i++)
            {
                TotalMoneyToYear += tevenueYear.ListColumn[i].value;
            }
            label_TotalMoneyToYear.Text = TotalMoneyToYear.ToString();

            Chart importMoneyDay = ctrl.ImportMoney(DateTime.Parse(DateTime.Now.ToShortDateString()), DateTime.Parse(DateTime.Now.ToShortDateString()), DateStatistics.NGAY);
            label_InputcouponCountToDay.Text = importMoneyDay.Counting.ToString();
            long ImportMonneyToDay = 0;
            for (int i = 0; i < importMoneyDay.ColumnCount; i++)
            {
                ImportMonneyToDay += importMoneyDay.ListColumn[i].value;
            }
            label_ImportMoneyToDay.Text = ImportMonneyToDay.ToString();

            Chart importMoneyMonth = ctrl.ImportMoney(DateTime.Parse(DateTime.Now.ToShortDateString()), DateTime.Parse(DateTime.Now.ToShortDateString()), DateStatistics.THANG);
            label_InputcouponCountToMonth .Text = importMoneyMonth.Counting.ToString();
            long ImportMonneyToMonth = 0;
            for (int i = 0; i < importMoneyMonth.ColumnCount; i++)
            {
                ImportMonneyToMonth += importMoneyMonth.ListColumn[i].value;
            }
            label_ImportMoneyToMonth.Text = ImportMonneyToMonth.ToString();


            Chart importMoneyYear = ctrl.ImportMoney(DateTime.Parse(DateTime.Now.ToShortDateString()), DateTime.Parse(DateTime.Now.ToShortDateString()), DateStatistics.NAM);
            label_InputcouponCountToYear.Text = importMoneyYear.Counting.ToString();
            long ImportMonneyToYear = 0;
            for (int i = 0; i < importMoneyYear.ColumnCount; i++)
            {
                ImportMonneyToYear += importMoneyYear.ListColumn[i].value;
            }
            label_ImportMoneyToYear.Text = ImportMonneyToYear.ToString();

        }

        

        private void button_ThongKeTonKho_Click(object sender, EventArgs e)
        {
            label_Title.Text = "Thống kê tồn kho";
            ucDuBaoNhapThuoc1.Visible = false;
            ucDoanhThuChart1.Visible = false;
            ucTonkho1.Visible = true;
            bunifuTransition1.ShowSync(Cart_TevenueToday);
        }

        private void button_DoanhThuChart_Click(object sender, EventArgs e)
        {
            label_Title.Text = "Biểu đồ doanh thu";
            ucTonkho1.Visible = false;
            ucDuBaoNhapThuoc1.Visible = false;
            ucDoanhThuChart1.Visible = true;
           
        }

        private void button_ImportMedicine_Click(object sender, EventArgs e)
        {
            label_Title.Text = button_ImportMedicine.Text;
            ucTonkho1.Visible = false;            
            ucDoanhThuChart1.Visible = false;
            ucDuBaoNhapThuoc1.Visible = true;

        }

        private void Cart_TevenueToday_MouseLeave(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(Cart_TevenueToday);
        }
    }
}
