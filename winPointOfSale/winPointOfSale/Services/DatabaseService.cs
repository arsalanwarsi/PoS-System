using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace winPointOfSale.Services
{
    public class DatabaseService
    {
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        public void DMLOperations(String QRY)
        {
            SqlCommand obj = new SqlCommand(QRY, con);
            con.Open();
            obj.ExecuteNonQuery();
            con.Close();
        }
        public DataTable tableData(String QRY)
        {
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
