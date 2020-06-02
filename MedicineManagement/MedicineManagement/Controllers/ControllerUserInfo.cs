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
    class ControllerUserInfo : ControllerBase
    {
        public ControllerUserInfo() : base()
        {
            ;
        }
        public override DataTable Load()
        {
            DataTable dt = new DataTable();
            try
            {
                ds.Clear();
                string query = "SELECT * FROM DBO.USERINFO";
                adapter.SelectCommand = new SqlCommand(query, connection);
                cb = new SqlCommandBuilder(adapter);
                adapter.Fill(ds, "USERINFO");

                dt = ds.Tables["USERINFO"];
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

        // update UserInfo
        public void Update(UserInfo userinfo)
        {
            try
            {
                string query = QueryUpdate(userinfo);
                if (query == "")
                {
                    MessageBox.Show("1 số trường không được bỏ trống", "Lỗi", MessageBoxButtons.OK);
                    return;
                }
                ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thât bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public string QueryUpdate(UserInfo userinfo)
        {
            string query = "";
            string UserName; try { UserName = userinfo.UserName.ToString().Trim(); } catch { UserName = ""; }
            string UserAddress; try { UserAddress = userinfo.UserAddress.ToString().Trim(); } catch { UserAddress = ""; }
            string UserEmail; try { UserEmail = userinfo.UserEmail.ToString().Trim(); } catch { UserEmail = ""; }
            string UserPhone; try { UserPhone = userinfo.UserPhone.ToString().Trim(); } catch { UserPhone = ""; }

            if (UserName == "") { UserName = "null"; }
            if (UserAddress == "") { UserAddress = "null"; }
            if (UserEmail == "") { UserEmail = "null"; }
            if (UserPhone == "") { UserPhone = "null"; }

            query = $"UPDATE UserInfo SET UserName = N'{UserName}', UserAddress = N'{UserAddress}', UserEmail = '{UserEmail}', UserPhone = '{UserPhone}', CreateDate = GETDATE()";
            return query;
        }

        public override DataTable Search(string text)
        {
            throw new NotImplementedException();
        }

        public override DataTable Load(string ID)
        {
            throw new NotImplementedException();
        }
    }
}
