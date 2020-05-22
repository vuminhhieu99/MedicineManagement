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

        public DataTable Search(Prescriptionline prescriptionline)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = this.QuerySearch(prescriptionline);
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

        private string QuerySearch(Prescriptionline prescriptionline)
        {
            string sqlSelect = "";

            string ID_Prescription; try { ID_Prescription = prescriptionline.ID_Prescription.ToString().Trim(); } catch { ID_Prescription = ""; }
            string ID_Medicine; try { ID_Medicine = prescriptionline.ID_Medicine.ToString().Trim(); } catch { ID_Medicine = ""; }
            string Search_MinAmount; try { Search_MinAmount = prescriptionline.Search_MinAmount.ToString().Trim(); } catch { Search_MinAmount="" }
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
    }
}
