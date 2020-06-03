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
            //  khởi tạo excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // khởi tạo WorkBook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // khởi tạo WorkSheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            app.Visible = true;

            // đinh dạng côt

            worksheet.Range["A1"].ColumnWidth = 4;
            worksheet.Range["B1"].ColumnWidth = 30;
            worksheet.Range["C1"].ColumnWidth = 30;
            worksheet.Range["D1"].ColumnWidth = 10;
            worksheet.Range["E1"].ColumnWidth = 10;
            worksheet.Range["F1"].ColumnWidth = 16;

            // đinh dạng  FONT
            worksheet.Range["A1", "M1"].Font.Size = 18;
            worksheet.Range["A1", "M1"].MergeCells = true;
            worksheet.Range["A1", "M5"].Font.Bold = true;
            // ĐỔ dữ liệu vào Sheet:
            worksheet.Cells[1, 1] = "BÁO CÁO NHẬP THUỐC";
            worksheet.Cells[3, 4] = "Ngày: " + DateTime.Now.ToShortDateString() + "";


            worksheet.Cells[8, 1] = "STT";
            worksheet.Cells[8, 2] = "Tên thuốc";
            worksheet.Cells[8, 3] = "Nhóm thuốc";
            worksheet.Cells[8, 4] = "Tồn kho";
            worksheet.Cells[8, 5] = "Đơn vị";
            worksheet.Cells[8, 6] = "giá";


            for (int i = 0; i < bunifuCustomDataGrid1.RowCount - 1; i++)
            {
                worksheet.Cells[i + 9, 1] = i + 1;
                for (int j = 0; j < 5; ++j)
                {

                    worksheet.Cells[i + 9, j + 2] = bunifuCustomDataGrid1.Rows[i].Cells[j].Value;
                }
            }
            
        }
    }
}
