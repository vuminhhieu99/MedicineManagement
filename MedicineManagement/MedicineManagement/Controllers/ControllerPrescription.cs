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
    class ControllerPrescription : ControllerBase
    {
        public ControllerPrescription() : base()
        {
            ;
        }
        public override DataTable Load()
        {
            DataTable dt = new DataTable();
            try
            {
                ds.Clear();
                string query = "SELECT * FROM DBO.PRESCRIPTION";
                adapter.SelectCommand = new SqlCommand(query, connection);
                cb = new SqlCommandBuilder(adapter);
                adapter.Fill(ds, "PRESCRIPTION");

                dt = ds.Tables["PRESCRIPTION"];
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

        public override DataTable Load(string ID_Supplier)
        {
            try { ID_Supplier = ID_Supplier.ToString().Trim(); } catch { ID_Supplier = ""; }
            if (ID_Supplier == "")
            {
                return null;
            }

            DataTable dt = new DataTable();
            try
            {
                ds.Clear();
                string query = "SELECT * FROM DBO.PRESCRIPTION WHERE ID_Supplier = '" + ID_Supplier + "'";
                adapter.SelectCommand = new SqlCommand(query, connection);
                cb = new SqlCommandBuilder(adapter);
                adapter.Fill(ds, "PRESCRIPTION");
                dt = ds.Tables["PRESCRIPTION"];
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
                    adapter.Fill(ds, "PRESCRIPTION");
                    dt = ds.Tables["PRESCRIPTION"];
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
            string CreateDate; try { CreateDate = value.ToString().Trim(); } catch { CreateDate = ""; }
            string Doctor; try { Doctor = value.ToString().Trim(); } catch { Doctor = ""; }
            string MedicalRecord; try { MedicalRecord = value.ToString().Trim(); } catch { MedicalRecord = ""; }
            string Drugstores; try { Drugstores = value.ToString().Trim(); } catch { Drugstores = ""; }
            string TotalMoney; try { TotalMoney = value.ToString().Trim(); } catch { TotalMoney = ""; }

            if (ID_Prescription != "") { sqlSelect = sqlSelect + " or ID_Prescription like '%" + ID_Prescription + "%'"; }
            if (CreateDate != "") { sqlSelect = sqlSelect + " or CreateDate like '%" + CreateDate + "%'"; }
            if (Doctor != "") { sqlSelect = sqlSelect + " or Doctor like N'%" + Doctor + "%'"; }
            if (MedicalRecord != "") { sqlSelect = sqlSelect + " or MedicalRecord like '%" + MedicalRecord + "%'"; }
            if (Drugstores != "") { sqlSelect = sqlSelect + " or Drugstores like '%" + Drugstores + "%'"; }
            if (TotalMoney != "") { sqlSelect = sqlSelect + " or TotalMoney like '%" + TotalMoney + "%'"; }

            string query = "";
            if (sqlSelect != "")
            {
                sqlSelect = sqlSelect.Remove(0, 3); // xoa chu " and" dau tien
                sqlSelect = " WHERE" + sqlSelect;
                query = "SELECT* FROM DBO.PRESCRIPTION" + sqlSelect;

            }
            return query;
        }

        public DataTable SearchAdvance(Prescription prescription)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = this.QuerySearchAdvance(prescription);
                ds.Clear();
                if (query == "")
                {
                    return this.Load();
                }
                else
                {
                    adapter.SelectCommand = new SqlCommand(query, connection);
                    cb = new SqlCommandBuilder(adapter);
                    adapter.Fill(ds, "PRESCRIPTION");
                    dt = ds.Tables["PRESCRIPTION"];
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

        private string QuerySearchAdvance(Prescription prescription)
        {
            string sqlSelect = "";

            string ID_Prescription; try { ID_Prescription = prescription.ID_Prescription.ToString().Trim(); } catch { ID_Prescription = ""; }
            string search_StartCreateDate; try { search_StartCreateDate = prescription.Search_EndCreateDate.ToShortDateString().Trim(); } catch { search_StartCreateDate = ""; }
            string search_EndCreateDate; try { search_EndCreateDate = prescription.Search_StartCreateDate.ToShortDateString().Trim(); } catch { search_EndCreateDate = ""; }
            string Doctor; try { Doctor = prescription.Doctor.ToString().Trim(); } catch { Doctor = ""; }
            string MedicalRecord; try { MedicalRecord = prescription.MedicalRecord.ToString().Trim(); } catch { MedicalRecord = ""; }
            string Drugstores; try { Drugstores = prescription.Drugstores.ToString().Trim(); } catch { Drugstores = ""; }
            string search_MinTotalMoney; try { search_MinTotalMoney = prescription.Search_MinTotalMoney.ToString().Trim(); } catch { search_MinTotalMoney = ""; }
            string search_MaxTotalMoney; try { search_MaxTotalMoney = prescription.Search_MaxTotalMoney.ToString().Trim(); } catch { search_MaxTotalMoney = ""; }

            if (ID_Prescription != "") { sqlSelect = sqlSelect + " and ID_Prescription like '%" + ID_Prescription + "%'"; }
            if (search_StartCreateDate != "") { sqlSelect = sqlSelect + " and CreateDate >=  '" + search_StartCreateDate + "'"; }
            if (search_EndCreateDate != "") { sqlSelect = sqlSelect + " and CreateDate <=  '" + search_EndCreateDate + "'"; }
            if (Doctor != "") { sqlSelect = sqlSelect + " and Doctor like N'%" + Doctor + "%'"; }
            if (MedicalRecord != "") { sqlSelect = sqlSelect + " and MedicalRecord like '%" + MedicalRecord + "%'"; }
            if (Drugstores != "") { sqlSelect = sqlSelect + " and Drugstores like '%" + Drugstores + "%'"; }
            if (search_MinTotalMoney != "") { sqlSelect = sqlSelect + " and TotalMoney >= " + search_MinTotalMoney; }
            if (search_MaxTotalMoney != "") { sqlSelect = sqlSelect + " and TotalMoney <= " + search_MaxTotalMoney; }

            string query = "";
            if (sqlSelect != "")
            {
                sqlSelect = sqlSelect.Remove(0, 4); // xoa chu " and" dau tien
                sqlSelect = " WHERE" + sqlSelect;
                query = "SELECT* FROM DBO.PRESCRIPTION" + sqlSelect;

            }
            return query;
        }

        public void Refresh()
        {
            try
            {
                adapter.Update(ds, "PRESCRIPTION");
                cb.RefreshSchema();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi refresh");
            }
            finally
            {
                connection.Close();
            }
        }

        public void Insert(Prescription prescription)
        {
            string query = QueryInsert(prescription);
            ExecuteNonQuery(query);
        }

        private string QueryInsert(Prescription prescription)
        {
            string query = "";

            string CreateDate; try { CreateDate = prescription.CreateDate.ToShortDateString().Trim(); } catch { CreateDate = ""; }
            string Doctor; try { Doctor = prescription.Doctor.ToString().Trim(); } catch { Doctor = ""; }
            string MedicalRecord; try { MedicalRecord = prescription.MedicalRecord.ToString().Trim(); } catch { MedicalRecord = ""; }
            string Drugstores; try { Drugstores = prescription.Drugstores.ToString().Trim(); } catch { Drugstores = ""; }
            string TotalMoney; try { TotalMoney = prescription.TotalMoney.ToString().Trim(); } catch { TotalMoney = ""; }

            if (CreateDate == "") { CreateDate = "null"; }
            if (Doctor == "") { Doctor = "null"; }
            if (MedicalRecord == "") { MedicalRecord = "null"; }
            if (Drugstores == "") { Drugstores = "null"; }
            if (TotalMoney == "") { TotalMoney = "0"; }
            //query = "EXEC InsertPRESCRIPTION " + CreateDate + ", " + Doctor + ", " + MedicalRecord + ", " + Drugstores + ", " + TotalMoney;
            query = $"EXEC dbo.InsertPRESCRIPTION '{CreateDate}', N'{Doctor}', {MedicalRecord}, {Drugstores}, {TotalMoney}";
            return query;
        }

        // update 1 Inputcoupon row
        public void Update(Prescription prescription)
        {
            string query = QueryUpdate(prescription);
            if (query == "")
            {
                MessageBox.Show("1 số trường không được bỏ trống", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            ExecuteNonQuery(query);
        }

        public string QueryUpdate(Prescription prescription)
        {
            string query = "";
            string ID_Prescription; try { ID_Prescription = prescription.ID_Prescription.ToString().Trim(); } catch { ID_Prescription = ""; }
            string CreateDate; try { CreateDate = prescription.CreateDate.ToShortDateString().Trim(); } catch { CreateDate = ""; }
            string Doctor; try { Doctor = prescription.Doctor.ToString().Trim(); } catch { Doctor = ""; }
            string MedicalRecord; try { MedicalRecord = prescription.MedicalRecord.ToString().Trim(); } catch { MedicalRecord = ""; }
            string Drugstores; try { Drugstores = prescription.Drugstores.ToString().Trim(); } catch { Drugstores = ""; }
            string TotalMoney; try { TotalMoney = prescription.TotalMoney.ToString().Trim(); } catch { TotalMoney = ""; }

            if (ID_Prescription == "")
            {
                return query;
            }
            if (CreateDate == "") { CreateDate = "null"; }
            if (Doctor == "") { Doctor = "null"; }
            if (MedicalRecord == "") { MedicalRecord = "null"; }
            if (Drugstores == "") { Drugstores = "null"; }
            if (TotalMoney == "") { TotalMoney = "0"; }

            //query = "EXEC UpdatePRESCRIPTION " + ID_Prescription + CreateDate + ", " + Doctor + ", " + MedicalRecord + ", " + Drugstores + ", " + TotalMoney;
            query = $"EXECUTE dbo.UpdatePRESCRIPTION {ID_Prescription},'{CreateDate}', N'{Doctor}',{MedicalRecord}, {Drugstores}, {TotalMoney}";

            return query;
        }

        public void Delete(string ID_Prescription)
        {
            ID_Prescription = ID_Prescription.Trim();
            string query = "Delete DBO.PRESCRIPTION WHERE ID_Prescription = " + ID_Prescription;
            ExecuteNonQuery(query);

        }
    }
}
