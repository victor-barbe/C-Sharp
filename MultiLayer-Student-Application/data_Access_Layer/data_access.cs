using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace data_Access_Layer
{
    public class data_access
    {
        static SqlConnection conn;
        static SqlCommand comm;
        static SqlDataAdapter da;
        static DataTable dt;

        static data_access()
        {
            conn = new SqlConnection();
            comm = new SqlCommand();
            comm.Connection = conn;
            da = new SqlDataAdapter();
            da.SelectCommand = comm;
        }

        public static void Link()
        {
            conn.ConnectionString = @"Data Source = LAPTOP-O4UNKVNA\SQLEXPRESS; Initial Catalog = grades_managment; Integrated Security = True";

            conn.Open();

        }

        public static void unLink()
        {
            conn.Close();
        }
        
        public static DataTable SelectData(string strsql)
        {

            comm.CommandText = strsql;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

       public static void ExecuteQuery(string strsql)
        {
            comm.CommandText = strsql;
            comm.ExecuteNonQuery();
        }
    }
}   
