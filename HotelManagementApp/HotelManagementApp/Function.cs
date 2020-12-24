using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace HotelManagementApp
{
    class Function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = "data source=LAPTOP-FL10P2Q7;database=Tb_Room;integrated security=true";
            return sql;
        }
        public DataSet getData(String query)
        {
            SqlConnection sql = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sql;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            return ds;
        }
        public void setData(String query,String msg)
        {
            try
            {
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            
            
        }
    }
}
