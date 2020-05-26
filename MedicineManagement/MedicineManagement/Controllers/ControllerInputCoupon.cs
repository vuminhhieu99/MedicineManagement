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
    class ControllerInputCoupon : ControllerBase
    {
        public ControllerInputCoupon() : base()
        {
            ;
        }
        public override DataTable Load()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM DBO.INPUTCOUPON";
                adapter.SelectCommand = new SqlCommand(query, connection);
                cb = new SqlCommandBuilder(adapter);
                adapter.Fill(ds, "INPUTCOUPON");

                dt = ds.Tables["INPUTCOUPON"];
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

        public DataTable Search(Inputcoupon inputcoupon)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = this.QuerySearch(inputcoupon);
                ds.Clear();
                if (query == "")
                {
                    return this.Load();
                }
                else
                {
                    adapter.SelectCommand = new SqlCommand(query, connection);
                    cb = new SqlCommandBuilder(adapter);
                    adapter.Fill(ds, "INPUTCOUPON");
                    dt = ds.Tables["INPUTCOUPON"];
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

        private string QuerySearch(Inputcoupon inputcoupon)
        {
            string sqlSelect = "";

            string ID_InputCoupon; try { ID_InputCoupon = inputcoupon.ID_InputCoupon.ToString().Trim(); } catch { ID_InputCoupon = ""; }
            string search_StartCreateDate; try { search_StartCreateDate = inputcoupon.Search_StartCreateDate.ToShortDateString().Trim(); } catch { search_StartCreateDate = ""; }
            string search_EndCreateDate; try { search_EndCreateDate = inputcoupon.Search_EndCreateDate.ToShortDateString().Trim(); } catch { search_EndCreateDate = ""; }
            string ID_Supplier; try { ID_Supplier = inputcoupon.ID_Supplier.ToString().Trim(); } catch { ID_Supplier = ""; }
            string search_MinTotalMoney; try { search_MinTotalMoney = inputcoupon.Search_MinTotalMoney.ToString().Trim(); } catch { search_MinTotalMoney = ""; }
            string search_MaxTotalMoney; try { search_MaxTotalMoney = inputcoupon.Search_MaxTotalMoney.ToString().Trim(); } catch { search_MaxTotalMoney = ""; }

            if (ID_InputCoupon != "") { sqlSelect = sqlSelect + " and ID_InputCoupon like '%" + ID_InputCoupon + "%'"; }
            if (search_StartCreateDate != "") { sqlSelect = sqlSelect + " and CreateDate >=  '" + search_StartCreateDate + "'"; }
            if (search_EndCreateDate != "") { sqlSelect = sqlSelect + " and CreateDate <=  '" + search_EndCreateDate + "'"; }
            if (ID_Supplier != "") { sqlSelect = sqlSelect + " and ID_Supplier like '%" + ID_Supplier + "%'"; }
            if (search_MinTotalMoney != "") { sqlSelect = sqlSelect + " and TotalMoney >= " + search_MinTotalMoney; }
            if (search_MaxTotalMoney != "") { sqlSelect = sqlSelect + " and TotalMoney <= " + search_MaxTotalMoney; }

            string query = "";
            if (sqlSelect != "")
            {
                sqlSelect = sqlSelect.Remove(0, 4); // xoa chu " and" dau tien
                sqlSelect = " WHERE" + sqlSelect;
                query = "SELECT* FROM DBO.INPUTCOUPON" + sqlSelect;

            }
            return query;
        }
                
        public void Refresh()
        {
            try
            {
                adapter.Update(ds, "INPUTCOUPON");
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
                
        public void Insert(Inputcoupon inputcoupon)
        {
            string query = QueryInsert(inputcoupon);
            ExecuteNonQuery(query);  
        }

        private string QueryInsert(Inputcoupon inputcoupon)
        {
            string query ="";            

            string CreateDate; try { CreateDate = inputcoupon.CreateDate.ToShortDateString().Trim(); } catch { CreateDate = ""; }
            string ID_Supplier; try { ID_Supplier = inputcoupon.ID_Supplier.ToString().Trim(); } catch { ID_Supplier = ""; }
            string TotalMoney; try { TotalMoney = inputcoupon.TotalMoney.ToString().Trim(); } catch { TotalMoney = ""; }
            
            if (CreateDate == "") { CreateDate = "null"; }
            if (ID_Supplier == "") { ID_Supplier = "null"; }
            if (TotalMoney == "") { TotalMoney = "0"; }
            query = "EXEC InsertINPUTCOUPON " + CreateDate + ", " + ID_Supplier + ", " + TotalMoney;
            return query;
        }

        // update 1 Inputcoupon row
        public void Update(Inputcoupon inputcoupon)
        {
            string query = QueryUpdate(inputcoupon);
            if (query == "")
            {
                MessageBox.Show("1 số trường không được bỏ trống", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            ExecuteNonQuery(query);

        }
        public string QueryUpdate(Inputcoupon inputcoupon)
        {
            string query = "";            
            string ID_InputCoupon; try { ID_InputCoupon = inputcoupon.ID_InputCoupon.ToString().Trim(); } catch { ID_InputCoupon = ""; }
            
            string CreateDate; try { CreateDate = inputcoupon.CreateDate.ToShortDateString().Trim(); } catch { CreateDate = ""; }
            string ID_Supplier; try { ID_Supplier = inputcoupon.ID_Supplier.ToString().Trim(); } catch { ID_Supplier = ""; }
            string TotalMoney; try { TotalMoney = inputcoupon.TotalMoney.ToString().Trim(); } catch { TotalMoney = ""; }
           
            if (ID_InputCoupon == "")
            {                
                return query;
            }                          

            if (CreateDate == "") { CreateDate = "null"; }
            if (ID_Supplier == "") { ID_Supplier = "null"; }
            if (TotalMoney == "") { TotalMoney = "0"; }
            
            query = "EXEC UpdateINPUTCOUPON " + ID_InputCoupon + ", " + CreateDate + ", " + ID_Supplier + ", " + TotalMoney;

            return query;
        }

        public void Delete(string ID_InputCoupon)
        {

            ID_InputCoupon = ID_InputCoupon.Trim();
            string query = "Delete DBO.INPUTCOUPON WHERE ID_InputCoupon = " + ID_InputCoupon;
            ExecuteNonQuery(query);           
        }

        public override DataTable Load(string ID)
        {
            throw new NotImplementedException();
        }
    }
}
