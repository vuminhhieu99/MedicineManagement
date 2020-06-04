using MedicineManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineManagement.Controllers
{
    class ControllerPrescriptionLine: ControllerBase
    {
        public ControllerPrescriptionLine() : base()
        {
            ;
        }
        public override DataTable Load()
        {
            DataTable dt = new DataTable();
            try
            {
                ds.Clear();
                string query = "SELECT * FROM DBO.PRESCRIPTIONLINE";
                adapter.SelectCommand = new SqlCommand(query, connection);
                cb = new SqlCommandBuilder(adapter);
                adapter.Fill(ds, "PRESCRIPTIONLINE");

                dt = ds.Tables["PRESCRIPTIONLINE"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            connection.Close();
            return dt;
        }

        public override DataTable Load(string ID_Prescription)
        {
            try { ID_Prescription = ID_Prescription.ToString().Trim(); } catch { ID_Prescription = ""; }
            if (ID_Prescription == "")
            {
                return null;
            }

            DataTable dt = new DataTable();
            try
            {
                ds.Clear();
                //string query = "SELECT * FROM DBO.PRESCRIPTIONLINE WHERE ID_Prescription = '" + ID_Prescription + "'";
                // sua lai cau quẻy
                //string query = $"SELECT m.ID_Medicine AS N'Mã thuốc', m.Name AS N'Tên thuốc', m.Price AS N'Đơn giá', p.Amount AS N'Số lượng', p.HealthInsurance AS N'BHYT', p.IntoMoney AS N'Thành tiền'  FROM dbo.MEDICINE m, dbo.PRESCRIPTIONLINE p WHERE m.ID_Medicine = p.ID_Medicine AND p.ID_Prescription = {ID_Prescription}";
                string query = $"SELECT m.ID_Medicine AS N'Mã thuốc', m.Name AS N'Tên thuốc', m.Price AS N'Đơn giá', p.Amount AS N'Số lượng', p.HealthInsurance AS N'BHYT', p.IntoMoney AS N'Thành tiền', p.ID_Prescription AS 'Mã đơn thuốc'  FROM dbo.MEDICINE m, dbo.PRESCRIPTIONLINE p WHERE m.ID_Medicine = p.ID_Medicine AND p.ID_Prescription = {ID_Prescription}";

                adapter.SelectCommand = new SqlCommand(query, connection);
                cb = new SqlCommandBuilder(adapter);
                adapter.Fill(ds, "PRESCRIPTIONLINE");
                dt = ds.Tables["PRESCRIPTIONLINE"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            connection.Close();
            return dt;
        }

        public override DataTable Search(string value)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = this.QuerySearch(value);
                ds.Clear();
                if (query == "")
                {
                    return this.Load();
                }
                else
                {
                    adapter.SelectCommand = new SqlCommand(query, connection);
                    cb = new SqlCommandBuilder(adapter);
                    adapter.Fill(ds, "PRESCRIPTIONLINE");
                    dt = ds.Tables["PRESCRIPTIONLINE"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        private string QuerySearch(string value)
        {
            string sqlSelect = "";

            string ID_Prescription; try { ID_Prescription = value.ToString().Trim(); } catch { ID_Prescription = ""; }
            string ID_Medicine; try { ID_Medicine = value.ToString().Trim(); } catch { ID_Medicine = ""; }
            string Amount; try { Amount = value.ToString().Trim(); } catch { Amount = ""; }
            string HealthInsurance; try { HealthInsurance = value.ToString().Trim(); } catch { HealthInsurance = ""; }
            string IntoMoney; try { IntoMoney = value.ToString().Trim(); } catch { IntoMoney = ""; }

            if (ID_Prescription != "") { sqlSelect = sqlSelect + " or ID_Prescription like '%" + ID_Prescription + "%'"; }
            if (ID_Medicine != "") { sqlSelect = sqlSelect + " or ID_Medicine like '%" + ID_Medicine + "%'"; }
            if (Amount != "") { sqlSelect = sqlSelect + " or Amount like '%" + Amount + "%'"; }
            if (HealthInsurance != "") { sqlSelect = sqlSelect + " or HealthInsurance like '%" + HealthInsurance + "%'"; }
            if (IntoMoney != "") { sqlSelect = sqlSelect + " or IntoMoney like '%" + IntoMoney + "%'"; }
            
            string query = "";
            if (sqlSelect != "")
            {
                sqlSelect = sqlSelect.Remove(0, 3); // xoa chu " or" dau tien
                sqlSelect = " WHERE" + sqlSelect;
                query = "SELECT* FROM DBO.PRESCRIPTIONLINE" + sqlSelect;
            }
            return query;
        }

        public DataTable SearchAdvance(Prescriptionline prescriptionline)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = this.QuerySearchAdvance(prescriptionline);
                ds.Clear();
                if (query == "")
                {
                    return this.Load();
                }
                else
                {
                    adapter.SelectCommand = new SqlCommand(query, connection);
                    cb = new SqlCommandBuilder(adapter);
                    adapter.Fill(ds, "PRESCRIPTIONLINE");
                    dt = ds.Tables["PRESCRIPTIONLINE"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        private string QuerySearchAdvance(Prescriptionline prescriptionline)
        {
            string sqlSelect = "";

            string ID_Prescription; try { ID_Prescription = prescriptionline.ID_Prescription.ToString().Trim(); } catch { ID_Prescription = ""; }
            string ID_Medicine; try { ID_Medicine = prescriptionline.ID_Medicine.ToString().Trim(); } catch { ID_Medicine = ""; }
            string Search_MinAmount; try { Search_MinAmount = prescriptionline.Search_MinAmount.ToString().Trim(); } catch { Search_MinAmount = ""; }
            string Search_MaxAmount = prescriptionline.Search_MaxAmount.ToString().Trim();
            string HealthInsurance = prescriptionline.HealthInsurance.ToString().Trim();           
            string Search_MinIntoMoney = prescriptionline.Search_MinIntoMoney.ToString().Trim();
            string Search_MaxIntoMoney = prescriptionline.Search_MaxIntoMoney.ToString().Trim();

            if (ID_Prescription != "") { sqlSelect = sqlSelect + " and ID_Prescription like '%" + ID_Prescription + "%'"; }
            if (ID_Medicine != "") { sqlSelect = sqlSelect + " and ID_Medicine like '%" + ID_Medicine + "%'"; }
            if (Search_MinAmount != "") { sqlSelect = sqlSelect + " and Amount >= " + Search_MinAmount; }
            if (Search_MaxAmount != "") { sqlSelect = sqlSelect + " and Amount <= " + Search_MaxAmount; }
            if (HealthInsurance != "") { sqlSelect = sqlSelect + " and HealthInsurance like '%" + HealthInsurance + "%'"; }
            if (Search_MinIntoMoney != "") { sqlSelect = sqlSelect + " and IntoMoney >= " + Search_MinIntoMoney; }
            if (Search_MaxIntoMoney != "") { sqlSelect = sqlSelect + " and IntoMoney <= " + Search_MaxIntoMoney; }

            string query = "";
            if (sqlSelect != "")
            {
                sqlSelect = sqlSelect.Remove(0, 4); // xoa chu " and" dau tien
                sqlSelect = " WHERE" + sqlSelect;
                query = "SELECT* FROM DBO.PRESCRIPTIONLINE" + sqlSelect;
            }
            return query;
        }

        public void Refresh()
        {
            try
            {
                adapter.Update(ds, "PRESCRIPTIONLINE");
                cb.RefreshSchema();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cập nhật thất bại");
            }
            finally
            {
                connection.Close();
            }
        }

        public void Insert(Prescriptionline prescriptionline)
        {
            string query = QueryInsert(prescriptionline);
            if (query == "")
                return;
            ExecuteNonQuery(query);
        }

        private string QueryInsert(Prescriptionline prescriptionline)
        {
            string query = "";

            string ID_Prescription; try { ID_Prescription = prescriptionline.ID_Prescription.ToString().Trim(); } catch { ID_Prescription = ""; }
            string ID_Medicine; try { ID_Medicine = prescriptionline.ID_Medicine.ToString().Trim(); } catch { ID_Medicine = ""; }
            string Amount; try { Amount = prescriptionline.Amount.ToString().Trim(); } catch { Amount = ""; }
            string HealthInsurance; try { HealthInsurance = prescriptionline.HealthInsurance.ToString().Trim(); } catch { HealthInsurance = ""; }
           
            if (ID_Prescription == "" || ID_Medicine == "") {
                MessageBox.Show("ID_Prescription và ID_Medicine không được bỏ trống", "Cập nhật thất bại");
                return query;
            }
            if (Amount == "") { Amount = "0"; }
            if (HealthInsurance == "") { HealthInsurance = "0"; }

            //query = "EXEC InsertPRESCRIPTIONLINE " + ID_Prescription + ", " + ID_Medicine + ", " + Amount + ", " + HealthInsurance;
            query = $"EXEC dbo.InsertPRESCRIPTIONLINE {ID_Prescription}, {ID_Medicine}, {Amount}, {HealthInsurance} ";

            return query;
        }
        // update 1 Inputcouponline row
        public void Update(Prescriptionline prescriptionline)
        {
            string query = QueryUpdate(prescriptionline);
            if (query == "")
                return;
            ExecuteNonQuery(query);
        }

        public string QueryUpdate(Prescriptionline prescriptionline)
        {
            string query = "";
            string ID_Prescription; try { ID_Prescription = prescriptionline.ID_Prescription.ToString().Trim(); } catch { ID_Prescription = ""; }
            string ID_Medicine; try { ID_Medicine = prescriptionline.ID_Medicine.ToString().Trim(); } catch { ID_Medicine = ""; }
            string Amount; try { Amount = prescriptionline.Amount.ToString().Trim(); } catch { Amount = ""; }
            string HealthInsurance; try { HealthInsurance = prescriptionline.HealthInsurance.ToString().Trim(); } catch { HealthInsurance = ""; }

            if (ID_Prescription == "" || ID_Medicine == "")
            {
                MessageBox.Show("ID_Prescription và ID_Medicine không được bỏ trống", "Cập nhật thất bại");
                return query;
            }
            if (Amount == "") { Amount = "0"; }
            if (HealthInsurance == "") { HealthInsurance = "0"; }
            query = "EXEC UpdatePRESCRIPTIONLINE " + ID_Prescription + ", " + ID_Medicine + ", " + Amount + ", " + HealthInsurance;

            return query;
        }

        public void Delete(string ID_Prescription, string ID_Medicine)
        {
            ID_Prescription = ID_Prescription.Trim();
            ID_Medicine = ID_Medicine.Trim();
            string query = "Delete DBO.PRESCRIPTIONLINE WHERE ID_Prescription = " + ID_Prescription + " AND ID_Medicine = "+ ID_Medicine;
            ExecuteNonQuery(query);            
        }

        public int SellInMonth(string ID_Medicine)
        {
            int totalAmount = 0;
            if(ID_Medicine == null || ID_Medicine == "")
            {
                return totalAmount;            }



            ID_Medicine = ID_Medicine.Trim();

            int month = DateTime.Now.Month;
            string query= "SELECT Amount FROM DBO.PRESCRIPTIONLINE INNER JOIN PRESCRIPTION ON PRESCRIPTIONLINE.ID_Prescription = PRESCRIPTION.ID_Prescription AND MONTH(PRESCRIPTION.CreateDate) = MONTH(GETDATE()) AND PRESCRIPTIONLINE.ID_Medicine = " + ID_Medicine;
                       

            try
            {
                DataTable dt = new DataTable();
                ds.Clear();             
               
                adapter.SelectCommand = new SqlCommand(query, connection);
                cb = new SqlCommandBuilder(adapter);
                adapter.Fill(ds, "PRESCRIPTIONLINE");
                dt = ds.Tables["PRESCRIPTIONLINE"];
               
                foreach (DataRow row in dt.Rows)
                {
                    int value; try { value = Convert.ToInt32(row["Amount"].ToString()); } catch { continue; }
                    totalAmount += value;                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return totalAmount;
        }

    }
}
