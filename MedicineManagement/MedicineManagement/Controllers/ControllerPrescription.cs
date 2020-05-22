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

        public DataTable Search(Prescription prescription)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = this.QuerySearch(prescription);
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

        private string QuerySearch(Prescription prescription)
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
            if (Doctor != "") { sqlSelect = sqlSelect + " and Doctor like '%" + Doctor + "%'"; }
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
    }
}
