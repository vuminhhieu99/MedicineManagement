using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicineManagement.Models;

namespace MedicineManagement.Controllers
{
    public enum DateStatistics { NGAY = 1, THANG = 2, NAM = 3 };
    public class ControllerStatistics
    {
        
        public ControllerStatistics()
        {
            ;
        }
        public Chart Tevenue(DateTime Start, DateTime End, DateStatistics format)
        {
            Chart chart = new Chart();
            if (DateTime.Compare(Start, End) == 1)
                return chart;
            if(format == DateStatistics.THANG)
            {
                TimeSpan timespan = End - Start;
                int monthCount = timespan.Days / 30 + 1;
                DateTime time = Start;
                int Pmonth;

                chart.NameChart = "Thống kê doanh thu theo tháng";
                chart.NameX = "tháng";
                chart.NameY = "doanh thu / VNĐ";
                chart.ColumnCount = monthCount;

                ControllerPrescription ctr = new ControllerPrescription();
                Prescription prescription = new Prescription();
                prescription.Search_StartCreateDate = Start;
                prescription.Search_EndCreateDate = End;
                DataTable dt = ctr.SearchAdvance(prescription);

                chart.ListColumn = new List<column>(monthCount);
                for (int i = 0; i < monthCount - 1; i++)
                {
                    column cl;
                    cl.value = 0;
                    cl.percent = 0;

                    time = time.AddMonths(i);                    
                    cl.name = time.Month + "/" + time.Year;

                    chart.ListColumn.Add(cl);
                }

                long maxValue = 0;

                for (int i = 0; i < monthCount - 1; i++)
                {
                    time = time.AddMonths(i);
                    Pmonth = time.Month;
                    column cl = chart.listColumn[i];
                    foreach (DataRow row in dt.Rows)
                    {

                        DateTime createDate;try { createDate = Convert.ToDateTime(row["createDate"].ToString()); } catch { continue; }
                        if(createDate.Month == Pmonth)
                        {                            
                            cl.value += Convert.ToInt64(row["totalMoney"].ToString());
                        }
                    }
                    chart.listColumn[i] = cl;
                    if(cl.value > maxValue)
                    {
                        maxValue = cl.value;
                    }
                }
                for (int i = 0; i < monthCount - 1; i++)
                {
                    column cl = chart.listColumn[i];
                    cl.percent = cl.value/ maxValue;
                    chart.listColumn[i] = cl;
                }

            }

            if (format == DateStatistics.NGAY)
            {
                TimeSpan timespan = End - Start;
                int dayCount = timespan.Days ;
                DateTime time = Start;
                int Pday;

                chart.NameChart = "Thống kê doanh thu theo ngày";
                chart.NameX = "tháng";
                chart.NameY = "doanh thu / VNĐ";
                chart.ColumnCount = dayCount;
                

                ControllerPrescription ctr = new ControllerPrescription();
                Prescription prescription = new Prescription();
                prescription.Search_StartCreateDate = Start;
                prescription.Search_EndCreateDate = End;
                DataTable dt = ctr.SearchAdvance(prescription);

                chart.ListColumn = new List<column>(dayCount);
                for (int i = 0; i < dayCount - 1; i++)
                {
                    column cl;
                    cl.value = 0;
                    cl.percent = 0;

                    time = time.AddDays(i);
                    cl.name = time.Day+ "/"+ time.Month + "/" + time.Year;

                    chart.ListColumn.Add(cl);
                }

                long maxValue = 0;

                for (int i = 0; i < dayCount - 1; i++)
                {
                    time = time.AddDays(i);
                    Pday = time.Day;
                    column cl = chart.listColumn[i];
                    foreach (DataRow row in dt.Rows)
                    {

                        DateTime createDate; try { createDate = Convert.ToDateTime(row["createDate"].ToString()); } catch { continue; }
                        if (createDate.Day == Pday)
                        {
                            cl.value += Convert.ToInt64(row["totalMoney"].ToString());
                        }
                    }
                    chart.listColumn[i] = cl;
                    if (cl.value > maxValue)
                    {
                        maxValue = cl.value;
                    }
                }
                for (int i = 0; i < dayCount - 1; i++)
                {
                    column cl = chart.listColumn[i];
                    cl.percent = cl.value/ maxValue;
                    chart.listColumn[i] = cl;
                }
            }

            if (format == DateStatistics.NAM)
            {
                TimeSpan timespan = End - Start;
                int namCount = timespan.Days / 365 + 1;
                DateTime time = Start;
                int Pyear;

                chart.NameChart = "Thống kê doanh thu theo năm";
                chart.NameX = "tháng";
                chart.NameY = "doanh thu / VNĐ";
                chart.ColumnCount = namCount;

                ControllerPrescription ctr = new ControllerPrescription();
                Prescription prescription = new Prescription();
                prescription.Search_StartCreateDate = Start;
                prescription.Search_EndCreateDate = End;
                DataTable dt = ctr.SearchAdvance(prescription);

                chart.ListColumn = new List<column>(namCount);
                for (int i = 0; i < namCount - 1; i++)
                {
                    column cl;
                    cl.value = 0;
                    cl.percent = 0;

                    time = time.AddYears(i);
                    cl.name = time.Month + "/" + time.Year;

                    chart.ListColumn.Add(cl);
                }

                long maxValue = 0;

                for (int i = 0; i < namCount - 1; i++)
                {
                    time = time.AddMonths(i);
                    Pyear = time.Month;
                    column cl = chart.listColumn[i];
                    foreach (DataRow row in dt.Rows)
                    {

                        DateTime createDate; try { createDate = Convert.ToDateTime(row["createDate"].ToString()); } catch { continue; }
                        if (createDate.Year == Pyear)
                        {
                            cl.value += Convert.ToInt64(row["totalMoney"].ToString());
                        }
                    }
                    chart.listColumn[i] = cl;
                    if (cl.value > maxValue)
                    {
                        maxValue = cl.value;
                    }
                }
                for (int i = 0; i < namCount - 1; i++)
                {
                    column cl = chart.listColumn[i];
                    cl.percent = cl.value/ maxValue;
                    chart.listColumn[i] = cl;
                }

            }

            return chart;
        }

        public Chart ImportMoney(DateTime Start, DateTime End, DateStatistics format)
        {
            Chart chart = new Chart();
            if (DateTime.Compare(Start, End) == 1)
                return chart;
            if (format == DateStatistics.THANG)
            {
                TimeSpan timespan = End - Start;
                int monthCount = timespan.Days / 30 + 1;
                DateTime time = Start;
                int Pmonth;

                chart.NameChart = "Thống kê tiền nhập thuốc theo tháng";
                chart.NameX = "tháng";
                chart.NameY = "doanh thu / VNĐ";
                chart.ColumnCount = monthCount;

                ControllerInputCoupon ctr = new ControllerInputCoupon();
                Inputcoupon inputcoupon = new Inputcoupon();
                inputcoupon.Search_StartCreateDate = Start;
                inputcoupon.Search_EndCreateDate = End;
                DataTable dt = ctr.SearchAdvance(inputcoupon);

                chart.ListColumn = new List<column>(monthCount);
                for (int i = 0; i < monthCount - 1; i++)
                {
                    column cl;
                    cl.value = 0;
                    cl.percent = 0;

                    time = time.AddMonths(i);
                    cl.name = time.Month + "/" + time.Year;

                    chart.ListColumn.Add(cl);
                }

                long maxValue = 0;

                for (int i = 0; i < monthCount - 1; i++)
                {
                    time = time.AddMonths(i);
                    Pmonth = time.Month;
                    column cl = chart.listColumn[i];
                    foreach (DataRow row in dt.Rows)
                    {

                        DateTime createDate; try { createDate = Convert.ToDateTime(row["createDate"].ToString()); } catch { continue; }
                        if (createDate.Month == Pmonth)
                        {
                            cl.value += Convert.ToInt64(row["totalMoney"].ToString());
                        }
                    }
                    chart.listColumn[i] = cl;
                    if (cl.value > maxValue)
                    {
                        maxValue = cl.value;
                    }
                }
                for (int i = 0; i < monthCount - 1; i++)
                {
                    column cl = chart.listColumn[i];
                    cl.percent = cl.value/ maxValue;
                    chart.listColumn[i] = cl;
                }

            }

            if (format == DateStatistics.NGAY)
            {
                TimeSpan timespan = End - Start;
                int dayCount = timespan.Days;
                DateTime time = Start;
                int Pday;

                chart.NameChart = "Thống kê tiền nhập thuốc theo ngày";
                chart.NameX = "tháng";
                chart.NameY = "doanh thu / VNĐ";
                chart.ColumnCount = dayCount;


                ControllerInputCoupon ctr = new ControllerInputCoupon();
                Inputcoupon inputcoupon = new Inputcoupon();
                inputcoupon.Search_StartCreateDate = Start;
                inputcoupon.Search_EndCreateDate = End;
                DataTable dt = ctr.SearchAdvance(inputcoupon);

                chart.ListColumn = new List<column>(dayCount);
                for (int i = 0; i < dayCount - 1; i++)
                {
                    column cl;
                    cl.value = 0;
                    cl.percent = 0;

                    time = time.AddDays(i);
                    cl.name = time.Day + "/" + time.Month + "/" + time.Year;

                    chart.ListColumn.Add(cl);
                }

                long maxValue = 0;

                for (int i = 0; i < dayCount - 1; i++)
                {
                    time = time.AddDays(i);
                    Pday = time.Day;
                    column cl = chart.listColumn[i];
                    foreach (DataRow row in dt.Rows)
                    {

                        DateTime createDate; try { createDate = Convert.ToDateTime(row["createDate"].ToString()); } catch { continue; }
                        if (createDate.Day == Pday)
                        {
                            cl.value += Convert.ToInt64(row["totalMoney"].ToString());
                        }
                    }
                    chart.listColumn[i] = cl;
                    if (cl.value > maxValue)
                    {
                        maxValue = cl.value;
                    }
                }
                for (int i = 0; i < dayCount - 1; i++)
                {
                    column cl = chart.listColumn[i];
                    cl.percent = cl.value / maxValue;
                    chart.listColumn[i] = cl;
                }
            }

            if (format == DateStatistics.NAM)
            {
                TimeSpan timespan = End - Start;
                int namCount = timespan.Days / 365 + 1;
                DateTime time = Start;
                int Pyear;

                chart.NameChart = "Thống kê doanh thu theo năm";
                chart.NameX = "năm";
                chart.NameY = "doanh thu / VNĐ";
                chart.ColumnCount = namCount;

                ControllerInputCoupon ctr = new ControllerInputCoupon();
                Inputcoupon inputcoupon = new Inputcoupon();
                inputcoupon.Search_StartCreateDate = Start;
                inputcoupon.Search_EndCreateDate = End;
                DataTable dt = ctr.SearchAdvance(inputcoupon);

                chart.ListColumn = new List<column>(namCount);
                for (int i = 0; i < namCount - 1; i++)
                {
                    column cl;
                    cl.value = 0;
                    cl.percent = 0;

                    time = time.AddYears(i);
                    cl.name =""+ time.Year;

                    chart.ListColumn.Add(cl);
                }

                long maxValue = 0;

                for (int i = 0; i < namCount - 1; i++)
                {
                    time = time.AddMonths(i);
                    Pyear = time.Month;
                    column cl = chart.listColumn[i];
                    foreach (DataRow row in dt.Rows)
                    {

                        DateTime createDate; try { createDate = Convert.ToDateTime(row["createDate"].ToString()); } catch { continue; }
                        if (createDate.Year == Pyear)
                        {
                            cl.value += Convert.ToInt64(row["totalMoney"].ToString());
                        }
                    }
                    chart.listColumn[i] = cl;
                    if (cl.value > maxValue)
                    {
                        maxValue = cl.value;
                    }
                }
                for (int i = 0; i < namCount - 1; i++)
                {
                    column cl = chart.listColumn[i];
                    cl.percent = cl.value/ maxValue;
                    chart.listColumn[i] = cl;
                }

            }

            return chart;
        }

        public Chart Profits(DateTime Start, DateTime End, DateStatistics format)
        {
            Chart chartTevenue = Tevenue(Start, End, format);
            Chart chartImportMoney = ImportMoney(Start, End, format);
            Chart chartProfits = new Chart();

            int count = chartTevenue.ColumnCount;
            long maxValue = 0; 
            for (int i = 0; i < count - 1; i++)
            {
                column cl;
                cl.value = chartTevenue.ListColumn[i].value - chartImportMoney.ListColumn[i].value;
                cl.percent = 0;
             
                cl.name = "" + chartTevenue.ListColumn[i].name;
                if (cl.value > maxValue)
                {
                    maxValue = cl.value;
                }
                chartProfits.ListColumn.Add(cl);                 
            }
            for (int i = 0; i < count - 1; i++)
            {
                column cl = chartProfits.listColumn[i];
                cl.percent = cl.value/ maxValue;
                chartProfits.listColumn[i] = cl;
            }

            return chartProfits;
        }

        

        //public DataTable WarnInventory()
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        ds.Clear();
        //        string query = "SELECT * FROM DBO.MEDICINE WHERE totalInventory <= 10 ORDER BY totalInventory";
        //        adapter.SelectCommand = new SqlCommand(query, connection);
        //        cb = new SqlCommandBuilder(adapter);
        //        adapter.Fill(ds, "MEDICINE");
        //        dt = ds.Tables["MEDICINE"];
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    connection.Close();
        //    return dt;
        //}

    }
}
