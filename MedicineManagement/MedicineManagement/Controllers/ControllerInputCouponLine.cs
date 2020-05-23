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
    class ControllerInputCouponLine : ControllerBase
    {
        public ControllerInputCouponLine() : base()
        {
            ;
        }
        public override DataTable Load()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM DBO.INPUTCOUPONLINE";
                adapter.SelectCommand = new SqlCommand(query, connection);
                cb = new SqlCommandBuilder(adapter);
                adapter.Fill(ds, "INPUTCOUPONLINE");

                dt = ds.Tables["INPUTCOUPONLINE"];
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

        public DataTable Search(Inputcouponline inputcouponline)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = this.QuerySearch(inputcouponline);
                ds.Clear();
                if (query == "")
                {
                    return this.Load();
                }
                else
                {
                    adapter.SelectCommand = new SqlCommand(query, connection);
                    cb = new SqlCommandBuilder(adapter);
                    adapter.Fill(ds, "INPUTCOUPONLINE");
                    dt = ds.Tables["INPUTCOUPONLINE"];
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

        private string QuerySearch(Inputcouponline inputcouponline)
        {
            string sqlSelect = "";
            string ID_InputCouponLine; try { ID_InputCouponLine = inputcouponline.ID_InputCouponLine.ToString().Trim(); } catch { ID_InputCouponLine = ""; }
            string ID_InputCoupon; try { ID_InputCoupon = inputcouponline.ID_InputCoupon.ToString().Trim(); } catch { ID_InputCoupon = ""; }
            string ID_Medicine; try { ID_Medicine = inputcouponline.ID_Medicine.ToString().Trim(); } catch { ID_Medicine = ""; }
            string Name; try { Name = inputcouponline.Name.ToString().Trim(); } catch { Name = ""; }
            string Search_MinAmount; try { Search_MinAmount = inputcouponline.Search_MinAmount.ToString().Trim(); } catch { Search_MinAmount = ""; }
            string Search_MaxAmount; try { Search_MaxAmount = inputcouponline.Search_MaxAmount.ToString().Trim(); } catch { Search_MaxAmount = ""; }
            string Search_MinPrice; try { Search_MinPrice = inputcouponline.Search_MinPrice.ToString().Trim(); } catch { Search_MinPrice = ""; }
            string Search_MaxPrice; try { Search_MaxPrice = inputcouponline.Search_MaxPrice.ToString().Trim(); } catch { Search_MaxPrice = ""; }
            string Search_StartExpiryDate; try { Search_StartExpiryDate = inputcouponline.Search_StartExpiryDate.ToShortDateString().Trim(); } catch { Search_StartExpiryDate = ""; }
            string Search_EndExpiryDate; try { Search_EndExpiryDate = inputcouponline.Search_EndExpiryDate.ToShortDateString().Trim(); } catch { Search_EndExpiryDate = ""; }
            string Search_MinIntoMoney; try { Search_MinIntoMoney = inputcouponline.Search_MinIntoMoney.ToString().Trim(); } catch { Search_MinIntoMoney = ""; }
            string Search_MaxIntoMoney; try { Search_MaxIntoMoney = inputcouponline.Search_MaxIntoMoney.ToString().Trim(); } catch { Search_MaxIntoMoney = ""; }

            if (ID_InputCouponLine != "") { sqlSelect = sqlSelect + " and ID_InputCouponLine like '%" + ID_InputCouponLine + "%'"; }
            if (ID_InputCoupon != "") { sqlSelect = sqlSelect + " and ID_InputCoupon like '%" + ID_InputCoupon + "%'"; }
            if (ID_Medicine != "") { sqlSelect = sqlSelect + " and ID_Medicine like '%" + ID_Medicine + "%'"; }
            if (Name != "") { sqlSelect = sqlSelect + " and Name like '%" + Name + "%'"; }
            if (Search_MinAmount != "") { sqlSelect = sqlSelect + " and Amount >= " + Search_MinAmount; }
            if (Search_MaxAmount != "") { sqlSelect = sqlSelect + " and Amount <= " + Search_MaxAmount; }
            if (Search_MinPrice != "") { sqlSelect = sqlSelect + " and TotalMoney >= " + Search_MinPrice; }
            if (Search_MaxPrice != "") { sqlSelect = sqlSelect + " and TotalMoney <= " + Search_MaxPrice; }
            if (Search_StartExpiryDate != "") { sqlSelect = sqlSelect + " and ExpiryDate >=  '" + Search_StartExpiryDate + "'"; }
            if (Search_EndExpiryDate != "") { sqlSelect = sqlSelect + " and ExpiryDate <=  '" + Search_EndExpiryDate + "'"; }
            if (Search_MinIntoMoney != "") { sqlSelect = sqlSelect + " and IntoMoney >= " + Search_MinIntoMoney; }
            if (Search_MaxIntoMoney != "") { sqlSelect = sqlSelect + " and IntoMoney <= " + Search_MaxIntoMoney; }

            string query = "";
            if (sqlSelect != "")
            {
                sqlSelect = sqlSelect.Remove(0, 4); // xoa chu " and" dau tien
                sqlSelect = " WHERE" + sqlSelect;
                query = "SELECT* FROM DBO.INPUTCOUPONLINE" + sqlSelect;
            }
            return query;
        }

        // update all Inputcouponline row
        public void Refresh()
        {
            try
            {
                adapter.Update(ds, "INPUTCOUPONLINE");
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

        public void Insert(Inputcouponline inputcouponline)
        {
            using (var command = new SqlCommand { Connection = connection })
            {
                connection.Open();
                command.CommandText = QueryInsert(inputcouponline);
                var count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("cập nhật thành công", "thông báo", MessageBoxButtons.OK);
                }
                connection.Close();
            }
        }

        private string QueryInsert(Inputcouponline inputcouponline)
        {
            string query = "";

            string ID_InputCoupon; try { ID_InputCoupon = inputcouponline.ID_InputCoupon.ToString().Trim(); } catch { ID_InputCoupon = ""; }
            string ID_Medicine; try { ID_Medicine = inputcouponline.ID_Medicine.ToString().Trim(); } catch { ID_Medicine = ""; }
            string Name; try { Name = inputcouponline.Name.ToString().Trim(); } catch { Name = ""; }
            string UnitInput; try { UnitInput = inputcouponline.UnitInput.ToString().Trim(); } catch { UnitInput = ""; }           
            string Amount; try { Amount = inputcouponline.Name.ToString().Trim(); } catch { Amount = ""; }
            string Price; try { Price = inputcouponline.Name.ToString().Trim(); } catch { Price = ""; }
            string ExpiryDate; try { ExpiryDate = inputcouponline.ExpiryDate.ToShortDateString().Trim(); } catch { ExpiryDate = ""; }
            string NumUnitOutput; try { NumUnitOutput = inputcouponline.NumUnitOutput.ToString().Trim(); } catch { NumUnitOutput = ""; }
            string ProductionBatch; try { ProductionBatch = inputcouponline.ProductionBatch.ToString().Trim(); } catch { ProductionBatch = ""; }

            if (CreateDate == "") { CreateDate = "null"; }
            if (ID_Supplier == "") { ID_Supplier = "null"; }
            if (TotalMoney == "") { TotalMoney = "0"; }
            query = "INSERT DBO.INPUTCOUPON(CreateDate, ID_Supplier, TotalMoney) VALUES ( " + CreateDate + ", " + ID_Supplier + ", " + TotalMoney + ")";
            return query;
        }
        // update 1 Inputcouponline row
        public void Update(Inputcouponline inputcouponline)
        {
            string query = QueryUpdate(inputcouponline);
            if (query == "")                        
                return;
            

            using (var command = new SqlCommand { Connection = connection })
            {
                connection.Open();
                command.CommandText = query;
                var count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("cập nhật thành công", "thông báo", MessageBoxButtons.OK);
                }
                connection.Close();
            }
        }

        public string QueryUpdate(Inputcouponline inputcouponline)
        {
            string query = "";
            string ID_InputCouponLine; try { ID_InputCouponLine = inputcouponline.ID_InputCouponLine.ToString().Trim(); } catch { ID_InputCouponLine = ""; }
            string ID_InputCoupon; try { ID_InputCoupon = inputcouponline.ID_InputCoupon.ToString().Trim(); } catch { ID_InputCoupon = ""; }
            string ID_Medicine; try { ID_Medicine = inputcouponline.ID_Medicine.ToString().Trim(); } catch { ID_Medicine = ""; }

            string Name; try { Name = inputcouponline.Name.ToString().Trim(); } catch { Name = ""; }
            string UnitInput; try { UnitInput = inputcouponline.UnitInput.ToString().Trim(); } catch { UnitInput = ""; }
            string Amount; try { Amount = inputcouponline.Name.ToString().Trim(); } catch { Amount = ""; }
            string Price; try { Price = inputcouponline.Name.ToString().Trim(); } catch { Price = ""; }
            string ExpiryDate; try { ExpiryDate = inputcouponline.ExpiryDate.ToShortDateString().Trim(); } catch { ExpiryDate = ""; }
            string NumUnitOutput; try { NumUnitOutput = inputcouponline.NumUnitOutput.ToString().Trim(); } catch { NumUnitOutput = ""; }
            string ProductionBatch; try { ProductionBatch = inputcouponline.ProductionBatch.ToString().Trim(); } catch { ProductionBatch = ""; }

            if (ID_InputCouponLine == "")
                return query;
            if (ID_InputCoupon == "")
            {
                MessageBox.Show("ID_InputCoupon không được bỏ trống", "Cập nhật thất bại");
                return query;
            }
            if (ID_Medicine == "")
            {
                MessageBox.Show("ID_Medicine không được bỏ trống", "Cập nhật thất bại");
                return query;
            }

            if (Name == "") { Name = "null"; }
            if (UnitInput == "") { UnitInput = "null"; }
            if (Amount == "") { Amount = "0"; }
            if (Price == "") { Price = "0"; }
            if (ExpiryDate == "") { ExpiryDate = "null"; }
            if (NumUnitOutput == "") { NumUnitOutput = "0"; }
            if (ProductionBatch == "") { ExpiryDate = "null"; }
            query = "EXEC UpdateINPUTCOUPONLINE " + ID_InputCouponLine + ", " + ID_InputCoupon + ", " + ID_Medicine  + ", " + Name + ", " + UnitInput + ", " + Amount + ", " + Price + ", " + ExpiryDate + ", " + NumUnitOutput + ", " + ProductionBatch ;

            return query;
        }
    }
}
