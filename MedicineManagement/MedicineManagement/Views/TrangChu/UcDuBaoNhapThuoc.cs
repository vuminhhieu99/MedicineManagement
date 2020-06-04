using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using MedicineManagement.Controllers;

namespace MedicineManagement.Views.TrangChu
{
    public partial class UcDuBaoNhapThuoc : UserControl
    {
        ControllerMedicine ctrl = new ControllerMedicine();
        public UcDuBaoNhapThuoc()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Url = "https://ncov.moh.gov.vn/";
            chromeDriver.Navigate();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://vncdc.gov.vn/vi/danh-muc-benh-truyen-nhiem/1093/benh-sot-ret";
            chromeDriver.Navigate();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://benhvien108.vn/benh-tay-chan-mieng-o-tre-em-cach-phong-va-dieu-tri.htm";
            chromeDriver.Navigate();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://www.benhvien108.vn/benh-viem-nao-do-virus-herpes-simplex-mot-benh-nguy-hiem-can-duoc-quan-tam.htm";
            chromeDriver.Navigate();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://benhvien108.vn/y-hoc-thuong-thuc/trieu-chung-cua-benh-thuy-dau-va-cach-phong-ngua.htm";
            chromeDriver.Navigate();
        }

        private void UcDuBaoNhapThuoc_Load(object sender, EventArgs e)
        {
           
            bunifuCustomDataGrid1.DataSource = ctrl.WarnDisease();
        }

        private void button_ExportExcel_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)bunifuCustomDataGrid1.DataSource;
            ControllerExport export = new ControllerExport();
            export.ExportDuBaoNhapThuoc(table, $"DỰ BÁO NHẬP THUỐC THÁNG {DateTime.Now.Month+1}");
        }
    }
}
