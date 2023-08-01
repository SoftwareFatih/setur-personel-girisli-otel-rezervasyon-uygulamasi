using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setur.DataBase
{
    internal class DBConnect
    {
        string connectionString = "Server=.;Database=SETUR;Trusted_Connection=True;";
        


        public DataTable ExecuteTable(string query)
        {
            DataTable table = new DataTable();
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand SqlCommand = new SqlCommand(query, conn); 
            conn.Open();
            table.Load(SqlCommand.ExecuteReader());
            conn.Close();


            return table;
        }
        public void ExecuteNonQuery(string query)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand SqlCommand = new SqlCommand(query, conn);
            conn.Open();
            SqlCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}
