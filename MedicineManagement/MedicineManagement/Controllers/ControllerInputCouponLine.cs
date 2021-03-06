﻿using MedicineManagement.Models;
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
                ds.Clear();
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

        public override DataTable Load(string ID_InputCoupon)
        {
            try { ID_InputCoupon = ID_InputCoupon.ToString().Trim(); } catch { ID_InputCoupon = ""; }
            if (ID_InputCoupon == "")
            {
                return null;
            }

            DataTable dt = new DataTable();
            try
            {
                ds.Clear();
                string query = "SELECT * FROM DBO.INPUTCOUPONLINE WHERE ID_InputCoupon = '" + ID_InputCoupon + "'";
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

        private string QuerySearch(string value)
        {
            string sqlSelect = "";
            string ID_InputCouponLine; try { ID_InputCouponLine = value.ToString().Trim(); } catch { ID_InputCouponLine = ""; }
            string ID_InputCoupon; try { ID_InputCoupon = value.ToString().Trim(); } catch { ID_InputCoupon = ""; }
            string ID_Medicine; try { ID_Medicine = value.ToString().Trim(); } catch { ID_Medicine = ""; }
            string Name; try { Name = value.ToString().Trim(); } catch { Name = ""; }
            string UnitInput; try { UnitInput = value.ToString().Trim(); } catch { UnitInput = ""; }
            string Amount; try { Amount = value.ToString().Trim(); } catch { Amount = ""; }
            string Price; try { Price = value.ToString().Trim(); } catch { Price = ""; }
            string ExpiryDate; try { ExpiryDate = value.ToString().Trim(); } catch { ExpiryDate = ""; }
            string NumUnitOutput; try { NumUnitOutput = value.ToString().Trim(); } catch { NumUnitOutput = ""; }
            string ProductionBatch; try { ProductionBatch = value.ToString().Trim(); } catch { ProductionBatch = ""; }
            string IntoMoney; try { IntoMoney = value.ToString().Trim(); } catch { IntoMoney = ""; }            

            if (ID_InputCouponLine != "") { sqlSelect = sqlSelect + " or ID_InputCouponLine like '%" + ID_InputCouponLine + "%'"; }
            if (ID_InputCoupon != "") { sqlSelect = sqlSelect + " or ID_InputCoupon like '%" + ID_InputCoupon + "%'"; }
            if (ID_Medicine != "") { sqlSelect = sqlSelect + " or ID_Medicine like '%" + ID_Medicine + "%'"; }
            if (Name != "") { sqlSelect = sqlSelect + " or Name like N'%" + Name + "%'"; }
            if (UnitInput != "") { sqlSelect = sqlSelect + " or UnitInput like N'%" + UnitInput + "%'"; }
            if (Amount != "") { sqlSelect = sqlSelect + " or Amount like '%" + Amount + "%'"; }           
            if (Price != "") { sqlSelect = sqlSelect + " or TotalMoney like '%" + Price + "%'"; }
            if (ExpiryDate != "") { sqlSelect = sqlSelect + " or ExpiryDate like '%" + ExpiryDate + "%'"; }
            if (NumUnitOutput != "") { sqlSelect = sqlSelect + " or NumUnitOutput like '%" + NumUnitOutput + "%'"; }
            if (ProductionBatch != "") { sqlSelect = sqlSelect + " or ProductionBatch like '%" + ProductionBatch + "%'"; }
            if (IntoMoney != "") { sqlSelect = sqlSelect + " or IntoMoney like '%" + IntoMoney + "%'"; }
           
            string query = "";
            if (sqlSelect != "")
            {
                sqlSelect = sqlSelect.Remove(0, 3); // xoa chu " or" dau tien
                sqlSelect = " WHERE" + sqlSelect;
                query = "SELECT* FROM DBO.INPUTCOUPONLINE" + sqlSelect;
            }
            return query;
        }

        public DataTable SearchAdvance(Inputcouponline inputcouponline)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = this.QuerySearchAdvance(inputcouponline);
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

        private string QuerySearchAdvance(Inputcouponline inputcouponline)
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
            if (Name != "") { sqlSelect = sqlSelect + " and Name like N'%" + Name + "%'"; }
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
            try
            {
                string query = QueryInsert(inputcouponline);
                ExecuteNonQuery(query);
                

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm Thất Bại!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private string QueryInsert(Inputcouponline inputcouponline)
        {
            string query = "";

            string ID_InputCoupon; try { ID_InputCoupon = inputcouponline.ID_InputCoupon.ToString().Trim(); } catch { ID_InputCoupon = ""; }
            string ID_Medicine; try { ID_Medicine = inputcouponline.ID_Medicine.ToString().Trim(); } catch { ID_Medicine = ""; }
            string Name; try { Name = inputcouponline.Name.ToString().Trim(); } catch { Name = ""; }
            string UnitInput; try { UnitInput = inputcouponline.UnitInput.ToString().Trim(); } catch { UnitInput = ""; }           
            string Amount; try { Amount = inputcouponline.Amount.ToString().Trim(); } catch { Amount = ""; }
            string Price; try { Price = inputcouponline.Price.ToString().Trim(); } catch { Price = ""; }
            string ExpiryDate; try { ExpiryDate = inputcouponline.ExpiryDate.ToShortDateString().Trim(); } catch { ExpiryDate = ""; }
            string NumUnitOutput; try { NumUnitOutput = inputcouponline.NumUnitOutput.ToString().Trim(); } catch { NumUnitOutput = ""; }
            string ProductionBatch; try { ProductionBatch = inputcouponline.ProductionBatch.ToString().Trim(); } catch { ProductionBatch = ""; }

            if (ID_InputCoupon == "" || ID_Medicine == "") { return query; }
            if (Name == "") { Name = "null"; }
            if (UnitInput == "") { UnitInput = "Hộp"; }
            if (Amount == "") { Amount = "1"; }
            if (Price == "") { Price = "0"; }
            if (ExpiryDate == "") { ExpiryDate = "null"; }
            if (NumUnitOutput == "") { NumUnitOutput = "1"; }
            if (ProductionBatch == "") { ProductionBatch = "null"; }
            
            query = "EXEC InsertINPUTCOUPONLINE " + ID_InputCoupon + ", " + ID_Medicine + ", N'" + Name + "', N'" + UnitInput + "', " + Amount + ", " + Price + ", '" + ExpiryDate + "', " + NumUnitOutput + ", " + ProductionBatch;
            return query;
        }
        // update 1 Inputcouponline row
        public void Update(Inputcouponline inputcouponline)
        {
            try
            {
                string query = QueryUpdate(inputcouponline);
                if (query == "")
                    return;
                ExecuteNonQuery(query);
            }
            catch(Exception)
            {
                MessageBox.Show("Sửa Thất Bại!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            string Amount; try { Amount = inputcouponline.Amount.ToString().Trim(); } catch { Amount = ""; }
            string Price; try { Price = inputcouponline.Price.ToString().Trim(); } catch { Price = ""; }
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
            if (ProductionBatch == "") { ProductionBatch = "null"; }
            query = "EXEC UpdateINPUTCOUPONLINE " + ID_InputCouponLine + ", " + ID_InputCoupon + ", " + ID_Medicine  + ", N'" + Name + "', N'"+ UnitInput + "', " + Amount + ", " + Price + ", '" + ExpiryDate + "', " + NumUnitOutput + ", " + ProductionBatch ;

            return query;
        }

        public void Delete(string ID_InputCouponLine)
        {
            try
            {

            ID_InputCouponLine = ID_InputCouponLine.Trim();
            string query = "Delete DBO.INPUTCOUPONLINE WHERE ID_InputCouponLine = " + ID_InputCouponLine;
            ExecuteNonQuery(query);

            }
            catch (Exception)
            {
                
            }
        }
        //Truong thêm vào
        public void DeleteOnInputCoupon(string ID_InputCoupon)
        {
            try
            {

                ID_InputCoupon = ID_InputCoupon.Trim();
                string query = "Delete DBO.INPUTCOUPONLINE WHERE ID_InputCoupon = " + ID_InputCoupon;
                ExecuteNonQuery(query);

            }
            catch (Exception)
            {

            }
        }
    }
}
