﻿using MedicineManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineManagement.Controllers
{
    class ControllerExport
    {
        public void ExportPrescription(Prescription prescription, DataTable dt, string sheetName)
        {

            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tên hàng thuốc
            Microsoft.Office.Interop.Excel.Range head1 = oSheet.get_Range("B1", "G1");
            head1.MergeCells = true;
            head1.Value2 = "HỌC VIỆN KỸ THUẬT QUÂN SỰ";
            head1.Font.Bold = true;
            head1.Font.Name = "Times New Roman";
            head1.Font.Size = "10";
            head1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // Địa chỉ nhà thuốc
            Microsoft.Office.Interop.Excel.Range head2 = oSheet.get_Range("B2", "G2");
            head2.MergeCells = true;
            head2.Value2 = "236 Hoàng Quốc Việt - Bắc Từ Liêm - Hà Nội";
            head2.Font.Bold = true;
            head2.Font.Name = "Times New Roman";
            head2.Font.Size = "10";
            head2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // tiêu đề ĐƠN THUỐC
            Microsoft.Office.Interop.Excel.Range head3 = oSheet.get_Range("A4", "H4");
            head3.MergeCells = true;
            head3.Value2 = "ĐƠN THUỐC";
            head3.Font.Bold = true;
            head3.Font.Name = "Times New Roman";
            head3.Font.Size = "25";
            head3.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Mã đơn thuốc
            Microsoft.Office.Interop.Excel.Range head4 = oSheet.get_Range("B6", "G6");
            head4.MergeCells = true;
            head4.Value2 = $"Mã đơn thuốc   : {prescription.ID_Prescription}";
            head4.Font.Bold = true;
            head4.Font.Name = "Times New Roman";
            head4.Font.Size = "11";
            head4.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // Ngày tạo
            Microsoft.Office.Interop.Excel.Range head5 = oSheet.get_Range("B7", "G7");
            head5.MergeCells = true;
            head5.Value2 = $"Ngày tạo           : {prescription.CreateDate.Day}/{prescription.CreateDate.Month}/{prescription.CreateDate.Year}";
            head5.Font.Bold = true;
            head5.Font.Name = "Times New Roman";
            head5.Font.Size = "11";
            head5.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // Bác sĩ
            Microsoft.Office.Interop.Excel.Range head6 = oSheet.get_Range("B8", "G8");
            head6.MergeCells = true;
            head6.Value2 = $"Bác sĩ               : {prescription.Doctor}";
            head6.Font.Bold = true;
            head6.Font.Name = "Times New Roman";
            head6.Font.Size = "11";
            head6.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // Hồ sơ bệnh án
            Microsoft.Office.Interop.Excel.Range head7 = oSheet.get_Range("B9", "G9");
            head7.MergeCells = true;
            head7.Value2 = $"Hồ sơ bệnh án  : {prescription.MedicalRecord}";
            head7.Font.Bold = true;
            head7.Font.Name = "Times New Roman";
            head7.Font.Size = "11";
            head7.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // Hồ sơ bệnh án
            Microsoft.Office.Interop.Excel.Range head8 = oSheet.get_Range("B11", "G11");
            head8.MergeCells = true;
            head8.Value2 = "Danh sách thuốc";
            head8.Font.Bold = true;
            head8.Font.Name = "Times New Roman";
            head8.Font.Size = "11";
            head8.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range clnull1 = oSheet.get_Range("A12", "A12");
            Microsoft.Office.Interop.Excel.Range clnull2 = oSheet.get_Range("H12", "H12");
            clnull1.ColumnWidth = 5;
            clnull2.ColumnWidth = 5;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("B12", "B12");
            cl1.Value2 = "STT";
            cl1.ColumnWidth = 5;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("C12", "C12");
            cl2.Value2 = "Tên thuốc";
            cl2.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("D12", "D12");
            cl3.Value2 = "Đơn giá";
            cl3.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("E12", "E12");
            cl4.Value2 = "Số lượng";
            cl4.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("F12", "F12");
            cl5.Value2 = "BHYT";
            cl5.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("G12", "G12");
            cl6.Value2 = "Thành tiền";
            cl6.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("B12", "G12");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.Rows.Count; r++)
            {

                DataRow dr = dt.Rows[r];

                for (int c = 0; c < dt.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 13;

            int columnStart = 2;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột STT, MaNV

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo phần tổng tiền
            Microsoft.Office.Interop.Excel.Range range1 = oSheet.get_Range($"B{rowEnd + 1}", $"F{rowEnd + 1}");
            Microsoft.Office.Interop.Excel.Range range2 = oSheet.get_Range($"G{rowEnd + 1}", $"G{rowEnd + 1}");
            Microsoft.Office.Interop.Excel.Range range3 = oSheet.get_Range($"B{rowEnd + 2}", $"C{rowEnd + 2}");
            Microsoft.Office.Interop.Excel.Range range4 = oSheet.get_Range($"D{rowEnd + 2}", $"G{rowEnd + 2}");

            range1.MergeCells = true;
            range1.Font.Bold = true;
            range1.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            range1.Value2 = "Tổng tiền (viết bằng số):";

            range2.Font.Bold = true;
            range2.Value2 = prescription.TotalMoney;
            range2.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            range3.MergeCells = true;
            range3.Font.Bold = true;
            range3.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            range3.Value2 = "Tổng tiền (viết bằng chữ):";

            range4.MergeCells = true;
            range4.Font.Bold = true;
            range4.Value2 = ConvertFromNumToText.Convert(prescription.TotalMoney.ToString());
            range4.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
        }

        public void ExportPrescription2(Prescription prescription, DataTable dt, string sheetName)
        {

            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tên hàng thuốc
            Microsoft.Office.Interop.Excel.Range head1 = oSheet.get_Range("B1", "G1");
            head1.MergeCells = true;
            head1.Value2 = "HỌC VIỆN KỸ THUẬT QUÂN SỰ";
            head1.Font.Bold = true;
            head1.Font.Name = "Times New Roman";
            head1.Font.Size = "10";
            head1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // Địa chỉ nhà thuốc
            Microsoft.Office.Interop.Excel.Range head2 = oSheet.get_Range("B2", "G2");
            head2.MergeCells = true;
            head2.Value2 = "236 Hoàng Quốc Việt - Bắc Từ Liêm - Hà Nội";
            head2.Font.Bold = true;
            head2.Font.Name = "Times New Roman";
            head2.Font.Size = "10";
            head2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // tiêu đề ĐƠN THUỐC
            Microsoft.Office.Interop.Excel.Range head3 = oSheet.get_Range("A4", "H4");
            head3.MergeCells = true;
            head3.Value2 = "ĐƠN THUỐC";
            head3.Font.Bold = true;
            head3.Font.Name = "Times New Roman";
            head3.Font.Size = "25";
            head3.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Mã đơn thuốc
            Microsoft.Office.Interop.Excel.Range head4 = oSheet.get_Range("B6", "G6");
            head4.MergeCells = true;
            head4.Value2 = $"Mã đơn thuốc   : {prescription.ID_Prescription}";
            head4.Font.Bold = true;
            head4.Font.Name = "Times New Roman";
            head4.Font.Size = "11";
            head4.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // Ngày tạo
            Microsoft.Office.Interop.Excel.Range head5 = oSheet.get_Range("B7", "G7");
            head5.MergeCells = true;
            head5.Value2 = $"Ngày tạo           : {prescription.CreateDate.Day}/{prescription.CreateDate.Month}/{prescription.CreateDate.Year}";
            head5.Font.Bold = true;
            head5.Font.Name = "Times New Roman";
            head5.Font.Size = "11";
            head5.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // Bác sĩ
            Microsoft.Office.Interop.Excel.Range head6 = oSheet.get_Range("B8", "G8");
            head6.MergeCells = true;
            head6.Value2 = $"Bác sĩ               : {prescription.Doctor}";
            head6.Font.Bold = true;
            head6.Font.Name = "Times New Roman";
            head6.Font.Size = "11";
            head6.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // Hồ sơ bệnh án
            Microsoft.Office.Interop.Excel.Range head7 = oSheet.get_Range("B9", "G9");
            head7.MergeCells = true;
            head7.Value2 = $"Hồ sơ bệnh án  : {prescription.MedicalRecord}";
            head7.Font.Bold = true;
            head7.Font.Name = "Times New Roman";
            head7.Font.Size = "11";
            head7.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // Hồ sơ bệnh án
            Microsoft.Office.Interop.Excel.Range head8 = oSheet.get_Range("B11", "G11");
            head8.MergeCells = true;
            head8.Value2 = "Danh sách thuốc";
            head8.Font.Bold = true;
            head8.Font.Name = "Times New Roman";
            head8.Font.Size = "11";
            head8.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range clnull1 = oSheet.get_Range("A12", "A12");
            Microsoft.Office.Interop.Excel.Range clnull2 = oSheet.get_Range("H12", "H12");
            clnull1.ColumnWidth = 5;
            clnull2.ColumnWidth = 5;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("B12", "B12");
            cl1.Value2 = "STT";
            cl1.ColumnWidth = 5;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("C12", "C12");
            cl2.Value2 = "Tên thuốc";
            cl2.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("D12", "D12");
            cl3.Value2 = "Đơn giá";
            cl3.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("E12", "E12");
            cl4.Value2 = "Số lượng";
            cl4.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("F12", "F12");
            cl5.Value2 = "BHYT";
            cl5.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("G12", "G12");
            cl6.Value2 = "Thành tiền";
            cl6.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("B12", "G12");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];

                arr[r, 0] = r+1;
                arr[r, 1] = dr["Tên thuốc"];
                arr[r, 2] = dr["Đơn giá"];
                arr[r, 3] = dr["Số lượng"];
                arr[r, 4] = dr["BHYT"];
                arr[r, 5] = dr["Thành tiền"];
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 13;

            int columnStart = 2;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột STT, MaNV

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo phần tổng tiền
            Microsoft.Office.Interop.Excel.Range range1 = oSheet.get_Range($"B{rowEnd + 1}", $"F{rowEnd + 1}");
            Microsoft.Office.Interop.Excel.Range range2 = oSheet.get_Range($"G{rowEnd + 1}", $"G{rowEnd + 1}");
            Microsoft.Office.Interop.Excel.Range range3 = oSheet.get_Range($"B{rowEnd + 2}", $"C{rowEnd + 2}");
            Microsoft.Office.Interop.Excel.Range range4 = oSheet.get_Range($"D{rowEnd + 2}", $"G{rowEnd + 2}");

            range1.MergeCells = true;
            range1.Font.Bold = true;
            range1.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            range1.Value2 = "Tổng tiền (viết bằng số):";

            range2.Font.Bold = true;
            range2.Value2 = prescription.TotalMoney;
            range2.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            range3.MergeCells = true;
            range3.Font.Bold = true;
            range3.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            range3.Value2 = "Tổng tiền (viết bằng chữ):";

            range4.MergeCells = true;
            range4.Font.Bold = true;
            range4.Value2 = ConvertFromNumToText.Convert(prescription.TotalMoney.ToString());
            range4.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
        }
    }
}