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
            connectionSTR = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyThuoc;Integrated Security=True";
            connection = new SqlConnection(connectionSTR);
            ds = new DataSet();
            adapter = new SqlDataAdapter();
        }
        public abstract DataTable Load();
        public abstract DataTable Load(string ID);
        public void ExecuteNonQuery(string query)
        {
            try
            {
                using (var command = new SqlCommand { Connection = connection })
                {
                    connection.Open();
                    command.CommandText = query;
                    var count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Thành công", "thông báo", MessageBoxButtons.OK);
                    }
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
