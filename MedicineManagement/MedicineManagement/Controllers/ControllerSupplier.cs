using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MedicineManagement.Models;

namespace MedicineManagement.Controllers
{
    class ControllerSupplier : ControllerBase
    {
        public ControllerSupplier() : base()
        {
            ;
        }
        public override DataTable Load()
        {
            DataTable dt = new DataTable();
            try
            {
                ds.Clear();
                string query = "SELECT * FROM DBO.SUPPLIER";
                adapter.SelectCommand = new SqlCommand(query, connection);
                cb = new SqlCommandBuilder(adapter);
                adapter.Fill(ds, "SUPPLIER");

                dt = ds.Tables["SUPPLIER"];
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
                    adapter.Fill(ds, "SUPPLIER");
                    dt = ds.Tables["SUPPLIER"];
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

            string ID_Supplier; try { ID_Supplier = value.ToString().Trim(); } catch { ID_Supplier = ""; }
            string Name; try { Name = value.ToString().Trim(); } catch { Name = ""; }
            string Address; try { Address = value.ToString().Trim(); } catch { Address = ""; }
            string Phone; try { Phone = value.ToString().Trim(); } catch { Phone = ""; }
            string Email; try { Email = value.ToString().Trim(); } catch { Email = ""; }

            if (ID_Supplier != "") { sqlSelect = sqlSelect + " or ID_Supplier like '%" + ID_Supplier + "%'"; }
            if (Name != "") { sqlSelect = sqlSelect + " or Name like N'%" + Name + "%'"; }
            if (Address != "") { sqlSelect = sqlSelect + " or Address like N'%" + Address + "%'"; }
            if (Phone != "") { sqlSelect = sqlSelect + " or Phone like N'%" + Phone + "%'"; }
            if (Email != "") { sqlSelect = sqlSelect + " or Email like N'%" + Email + "%'"; }

            string query = "";
            if (sqlSelect != "")
            {
                sqlSelect = sqlSelect.Remove(0, 3); // xoa chu " or" dau tien
                sqlSelect = " WHERE" + sqlSelect;
                query = "SELECT* FROM DBO.SUPPLIER" + sqlSelect;
            }
            return query;
        }

        public DataTable SearchAdvane(Supplier supplier)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = this.QuerySearchAdvance(supplier);
                ds.Clear();
                if (query == "")
                {
                    return this.Load();
                }
                else
                {
                    adapter.SelectCommand = new SqlCommand(query, connection);
                    cb = new SqlCommandBuilder(adapter);
                    adapter.Fill(ds, "SUPPLIER");
                    dt = ds.Tables["SUPPLIER"];
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

        private string QuerySearchAdvance(Supplier supplier)
        {
            string sqlSelect = "";

            string ID_Supplier; try { ID_Supplier = supplier.ID_Supplier.ToString().Trim(); } catch { ID_Supplier = ""; }
            string Name; try { Name = supplier.Name.ToString().Trim(); } catch { Name = ""; }
            string Address; try { Address = supplier.Address.ToString().Trim(); } catch { Address = ""; }
            string Phone; try { Phone = supplier.Phone.ToString().Trim(); } catch { Phone = ""; }
            string Email; try { Email = supplier.Email.ToString().Trim(); } catch { Email = ""; }            

            if (ID_Supplier != "") { sqlSelect = sqlSelect + " and ID_Supplier like '%" + ID_Supplier + "%'"; }
            if (Name != "") { sqlSelect = sqlSelect + " and Name like N'%" + Name + "%'"; }
            if (Address != "") { sqlSelect = sqlSelect + " and Address like N'%" + Address + "%'"; }
            if (Phone != "") { sqlSelect = sqlSelect + " and Phone like '%" + Phone + "%'"; }
            if (Email != "") { sqlSelect = sqlSelect + " and Email like '%" + Email + "%'"; }

            string query = "";
            if (sqlSelect != "")
            {
                sqlSelect = sqlSelect.Remove(0, 4); // xoa chu " and" dau tien
                sqlSelect = " WHERE" + sqlSelect;
                query = "SELECT* FROM DBO.SUPPLIER" + sqlSelect;
            }
            return query;
        }

        public void Refresh()
        {
            try
            {
                adapter.Update(ds, "SUPPLIER");
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

        public void Insert(Supplier supplier)
        {
            string query = QueryInsert(supplier);
            ExecuteNonQuery(query); 
        }

        private string QueryInsert(Supplier supplier)
        {
            string query = "";
            string Name; try { Name = supplier.Name.ToString().Trim(); } catch { Name = ""; }
            string Address; try { Address = supplier.Address.ToString().Trim(); } catch { Address = ""; }
            string Phone; try { Phone = supplier.Phone.ToString().Trim(); } catch { Phone = ""; }
            string Email; try { Email = supplier.Email.ToString().Trim(); } catch { Email = ""; }       

            if (Name == "") { Name = "null"; }
            if (Address == "") { Address = "null"; }
            if (Phone == "") { Phone = "null"; }
            if (Email == "") { Email = "null"; }

            query = "EXEC InsertSUPPLIER " + Name + ", " + Address + ", " + Phone + ", " + Email;
            return query;
        }

        // update 1 Inputcoupon row
        public void Update(Supplier supplier)
        {
            string query = QueryUpdate(supplier);
            if (query == "")
            {
                MessageBox.Show("1 số trường không được bỏ trống", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            ExecuteNonQuery(query);            
        }

        public string QueryUpdate(Supplier supplier)
        {
            string query = "";
            string ID_Supplier; try { ID_Supplier = supplier.ID_Supplier.ToString().Trim(); } catch { ID_Supplier = ""; }

            string Name; try { Name = supplier.Name.ToString().Trim(); } catch { Name = ""; }
            string Address; try { Address = supplier.Address.ToString().Trim(); } catch { Address = ""; }
            string Phone; try { Phone = supplier.Phone.ToString().Trim(); } catch { Phone = ""; }
            string Email; try { Email = supplier.Email.ToString().Trim(); } catch { Email = ""; }

            if (ID_Supplier == "")
            {
                return query;
            }

            if (Name == "") { Name = "null"; }
            if (Address == "") { Address = "null"; }
            if (Phone == "") { Phone = "null"; }
            if (Email == "") { Email = "null"; }

            query = "EXEC UpdateSUPPLIER " + ID_Supplier + ", " + Name + ", " + Address + ", " + Phone + ", " + Email;
            return query;
        }

        public void Delete(string ID_Supplier)
        {            
            ID_Supplier = ID_Supplier.Trim();
            string query = "Delete DBO.SUPPLIER  WHERE ID_Supplier = " + ID_Supplier;
            ExecuteNonQuery(query);
        }

        public override DataTable Load(string ID)
        {
            throw new NotImplementedException();
        }
    }
}
