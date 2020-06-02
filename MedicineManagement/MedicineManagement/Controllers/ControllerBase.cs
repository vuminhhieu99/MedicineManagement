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
    abstract class ControllerBase
    {
        public static UserInfo userInfo = new UserInfo();

        protected string connectionSTR;
        protected SqlConnection connection;
        protected SqlDataAdapter adapter;
        protected DataSet ds;
        protected SqlCommandBuilder cb;

        public string ConnectionSTR { get => connectionSTR; set => connectionSTR = value; }
        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public DataSet Ds { get => ds; set => ds = value; }
        public SqlCommandBuilder Cb { get => cb; set => cb = value; }

        public ControllerBase()
        {
            connectionSTR = "Data Source=DESKTOP-5ICMB9D;Initial Catalog=QuanLyThuoc;Integrated Security=True";
            connection = new SqlConnection(connectionSTR);
            ds = new DataSet();
            adapter = new SqlDataAdapter();
        }
        public abstract DataTable Load();
        public abstract DataTable Load(string ID);
        public abstract DataTable Search(string text);
        public void ExecuteNonQuery(string query)
        {
            try
            {
                using (var command = new SqlCommand { Connection = connection })
                {
                    connection.Open();
                    command.CommandText = query;
                    var count = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
