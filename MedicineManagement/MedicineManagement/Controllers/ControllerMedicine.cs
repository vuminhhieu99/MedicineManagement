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
    class ControllerMedicine : ControllerBase
    {
        public ControllerMedicine() : base()
        {
            ;
        }
        public override DataTable Load()
        {
            DataTable dt = new DataTable();
            try
            {
                ds.Clear();
                string query = "SELECT * FROM DBO.MEDICINE";
                adapter.SelectCommand = new SqlCommand(query, connection);
                cb = new SqlCommandBuilder(adapter);
                adapter.Fill(ds, "MEDICINE");
                dt = ds.Tables["MEDICINE"];
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

        public DataTable WarnInventory()
        {
            DataTable dt = new DataTable();
            try
            {
                ds.Clear();
                string query = "SELECT * FROM DBO.MEDICINE WHERE totalInventory <= 10 ORDER BY totalInventory";
                adapter.SelectCommand = new SqlCommand(query, connection);
                cb = new SqlCommandBuilder(adapter);
                adapter.Fill(ds, "MEDICINE");
                dt = ds.Tables["MEDICINE"];
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
                    adapter.Fill(ds, "MEDICINE");
                    dt = ds.Tables["MEDICINE"];
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

            string ID_Medicine; try { ID_Medicine = value.ToString().Trim(); } catch { ID_Medicine = ""; }
            string Name; try { Name = value.ToString().Trim(); } catch { Name = ""; }
            string MedicineGroup; try { MedicineGroup = value.ToString().Trim(); } catch { MedicineGroup = ""; }
            string Unit; try { Unit = value.ToString().Trim(); } catch { Unit = ""; }
            string Price; try { Price = value.ToString().Trim(); } catch { Price = ""; }
            string TotalInventory; try { TotalInventory = value.ToString().Trim(); } catch { TotalInventory = ""; }

            if (ID_Medicine != "") { sqlSelect = sqlSelect + " or ID_Medicine like N'%" + ID_Medicine + "%'"; }
            if (Name != "") { sqlSelect = sqlSelect + " or Name like N'%" + Name + "%'"; }
            if (MedicineGroup != "") { sqlSelect = sqlSelect + " or MedicineGroup like N'%" + MedicineGroup + "%'"; }
            if (Unit != "") { sqlSelect = sqlSelect + " or Unit like N'%" + Unit + "%'"; }
            if (Price != "") { sqlSelect = sqlSelect + " or Price like N'%" + Price + "%'"; }
            if (TotalInventory != "") { sqlSelect = sqlSelect + " or TotalInventory like N'%" + TotalInventory + "%'"; }

            string query = "";
            if (sqlSelect != "")
            {
                sqlSelect = sqlSelect.Remove(0, 3); // xoa chu " or" dau tien
                sqlSelect = " WHERE" + sqlSelect;
                query = "SELECT* FROM DBO.MEDICINE" + sqlSelect;
            }
            return query;
        }


        public DataTable SearchAdvance(Medicine medicine)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = this.QuerySearchAdvance(medicine);
                ds.Clear();
                if (query == "")
                {
                    return this.Load();
                }
                else
                {
                    adapter.SelectCommand = new SqlCommand(query, connection);
                    cb = new SqlCommandBuilder(adapter);
                    adapter.Fill(ds, "MEDICINE");
                    dt = ds.Tables["MEDICINE"];
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

        private string QuerySearchAdvance(Medicine medicine)
        {
            string sqlSelect = "";

            string ID_Medicine; try { ID_Medicine = medicine.ID_Medicine.ToString().Trim(); } catch { ID_Medicine = ""; }
            string Name; try { Name = medicine.Name.ToString().Trim(); } catch { Name = ""; }
            string MedicineGroup; try { MedicineGroup = medicine.MedicineGroup.ToString().Trim(); } catch { MedicineGroup = ""; }
            string Unit; try { Unit = medicine.Unit.ToString().Trim(); } catch { Unit = ""; }
            string Search_MinPrice; try { Search_MinPrice = medicine.Search_MinPrice.ToString().Trim(); } catch { Search_MinPrice = ""; }
            string Search_MaxPrice; try { Search_MaxPrice = medicine.Search_MaxPrice.ToString().Trim(); } catch { Search_MaxPrice = ""; }
            string Search_MinTotalInventory; try { Search_MinTotalInventory = medicine.Search_MinTotalInventory.ToString().Trim(); } catch { Search_MinTotalInventory = ""; }
            string Search_MaxTotalInventory; try { Search_MaxTotalInventory = medicine.Search_MaxTotalInventory.ToString().Trim(); } catch { Search_MaxTotalInventory = ""; }
            string MostUsedMonth; try { MostUsedMonth = medicine.MostUsedMonth.ToString().Trim(); } catch { MostUsedMonth = ""; }
            

            if (ID_Medicine != "" && ID_Medicine != "-1") { sqlSelect = sqlSelect + " and ID_Medicine like N'%" + ID_Medicine + "%'"; }
            if (Name != "") { sqlSelect = sqlSelect + " and Name like N'%" + Name + "%'"; }
            if (MedicineGroup != "") { sqlSelect = sqlSelect + " and MedicineGroup like N'%" + MedicineGroup + "%'"; }
            if (Unit != "") { sqlSelect = sqlSelect + " and Unit like N'%" + Unit + "%'"; }
            if (Search_MinPrice != "" && Search_MinPrice != "0") { sqlSelect = sqlSelect + " and Price >= " + Convert.ToInt32(Search_MinPrice); }
            if (Search_MaxPrice != "" && Search_MaxPrice != "0") { sqlSelect = sqlSelect + " and Price <= " + Convert.ToInt32(Search_MaxPrice); }
            if (Search_MinTotalInventory != "" && Search_MinTotalInventory != "0") { sqlSelect = sqlSelect + " and TotalInventory >= " + Convert.ToInt32(Search_MinTotalInventory); }
            if (Search_MaxTotalInventory != "" && Search_MaxTotalInventory != "0") { sqlSelect = sqlSelect + " and TotalInventory <= " + Convert.ToInt32(Search_MaxTotalInventory); }
            if (MostUsedMonth != "")
            {
                int count = ListMostUsedMonth(MostUsedMonth).Length;
                if (count > 0)
                {
                    string[] month = ListMostUsedMonth(MostUsedMonth);
                    for (int i=0; i < count; i++)
                    {
                        sqlSelect = sqlSelect + " and MostUsedMonth like '%" + month[i] + "%'";
                    }
                }

            }
            
            string query = "";
            if (sqlSelect != "")
            {
                sqlSelect = sqlSelect.Remove(0, 4); // xoa chu " and" dau tien
                sqlSelect = " WHERE" + sqlSelect;
                query = "SELECT* FROM DBO.MEDICINE" + sqlSelect;
            }
            return query;
        }

        public void Refresh()
        {
            try
            {
                adapter.Update(ds, "MEDICINE");
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

        public void Insert(Medicine medicine)
        {
            string query = QueryInsert(medicine);
            ExecuteNonQuery(query);
        }

        private string QueryInsert(Medicine medicine)
        {
            string query = "";

            string Name; try { Name = medicine.Name.ToString().Trim(); } catch { Name = ""; }
            string MedicineGroup; try { MedicineGroup = medicine.MedicineGroup.ToString().Trim(); } catch { MedicineGroup = ""; }
            string Uses; try { Uses = medicine.Uses.ToString().Trim(); } catch { Uses = ""; }
            string Unit; try { Unit = medicine.Unit.ToString().Trim(); } catch { Unit = ""; }
            string Price; try { Price = medicine.Price.ToString().Trim(); } catch { Price = ""; }
            string TotalInventory; try { TotalInventory = medicine.TotalInventory.ToString().Trim(); } catch { TotalInventory = ""; }
            string Note; try { Note = medicine.Note.ToString().Trim(); } catch { Note = ""; }
            string MostUsedMonth; try { MostUsedMonth = medicine.MostUsedMonth.ToString().Trim(); } catch { MostUsedMonth = ""; }

            if (Name == "") { Name = "null"; }
            if (MedicineGroup == "") { MedicineGroup = "null"; }
            if (Uses == "") { Uses = "null"; }
            if (Unit == "") { Unit = "null"; }
            if (Price == "") { Price = "0"; }
            if (TotalInventory == "") { TotalInventory = "0"; }
            if (Note == "") { Note = "null"; }
            if (MostUsedMonth == "") { MostUsedMonth = "null"; }

            //query = "EXEC InserMEDICINE " + Name + ", " + MedicineGroup + ", " + Uses + ", " + Unit + ", " + Price + ", " + TotalInventory + ", " + Note + ", " + MostUsedMonth;

            // sua lai cau query bi sai cu phap
            int mostUsed = Convert.ToInt32(MostUsedMonth);
            query = $"EXEC InsertMEDICINE N'{Name}', N'{MedicineGroup}', N'{Uses}', N'{Uses}', {Price}, {TotalInventory}, N'{Note}', {MostUsedMonth}";
            return query;
        }

        // update 1 Medicine row
        public void Update(Medicine medicine)
        {
            string query = QueryUpdate(medicine);
            if (query == "")
            {
                MessageBox.Show("1 số trường không được bỏ trống", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            ExecuteNonQuery(query);
        }

        public string QueryUpdate(Medicine medicine)
        {
            string query = "";
            string ID_Medicine; try { ID_Medicine = medicine.ID_Medicine.ToString().Trim(); } catch { ID_Medicine = ""; }

            string Name; try { Name = medicine.Name.ToString().Trim(); } catch { Name = ""; }
            string MedicineGroup; try { MedicineGroup = medicine.MedicineGroup.ToString().Trim(); } catch { MedicineGroup = ""; }
            string Uses; try { Uses = medicine.Uses.ToString().Trim(); } catch { Uses = ""; }
            string Unit; try { Unit = medicine.Unit.ToString().Trim(); } catch { Unit = ""; }
            string Price; try { Price = medicine.Price.ToString().Trim(); } catch { Price = ""; }
            string TotalInventory; try { TotalInventory = medicine.TotalInventory.ToString().Trim(); } catch { TotalInventory = ""; }
            string Note; try { Note = medicine.Note.ToString().Trim(); } catch { Note = ""; }
            string MostUsedMonth; try { MostUsedMonth = medicine.MostUsedMonth.ToString().Trim(); } catch { MostUsedMonth = ""; }

            if (ID_Medicine == "")
            {
                return query;
            }

            if (Name == "") { Name = "null"; }
            if (MedicineGroup == "") { MedicineGroup = "null"; }
            if (Uses == "") { Uses = "null"; }
            if (Unit == "") { Unit = "null"; }
            if (Price == "") { Price = "0"; }
            if (TotalInventory == "") { TotalInventory = "0"; }
            if (Note == "") { Note = "null"; }
            if (MostUsedMonth == "") { MostUsedMonth = "null"; }

            // Sua lai cau query bi sai cu phap

            int mostUsed = Convert.ToInt32(MostUsedMonth);
            query = $"EXEC UpdateMEDICINE {ID_Medicine}, N'{Name}', N'{MedicineGroup}', N'{Uses}', N'{Unit}', {Price}, {TotalInventory}, N'{Note}', {mostUsed}";


            return query;
        }

        public void Delete(string ID_Medicine)
        {
            ID_Medicine = ID_Medicine.Trim();
            string query = "Delete DBO.MEDICINE WHERE ID_Medicine = " + ID_Medicine;
            ExecuteNonQuery(query);

        }

        public override DataTable Load(string ID)
        {
            throw new NotImplementedException();
        }

        public DataTable WarnInventory(string ID_Medicine)
        {
            DataTable dt = new DataTable();


            return dt;
        }

        public string[] ListMostUsedMonth(string mostUsedMonth)
        {
            mostUsedMonth = mostUsedMonth.Trim();
            string[] arrListStr = mostUsedMonth.Split(',');           

            return arrListStr;
        }

        // cảnh báo dịch bệnh theo mùa
        public DataTable WarDisease()
        {
            DataTable dt = new DataTable();
            int warnMonth = DateTime.Now.AddMonths(1).Month;
            Medicine medicine = new Medicine();
            medicine.MostUsedMonth = warnMonth.ToString();
            dt = this.SearchAdvance(medicine);
            return dt;
        }

    }
}
