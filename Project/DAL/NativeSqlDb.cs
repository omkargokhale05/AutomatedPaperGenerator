using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Project.DAL
{

    public static class NativeSqlDb
    {
        public static string ConStr
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["Project.Properties.Settings.QuestionDbConnectionString"].ConnectionString;
            }
        }

        public static DataTable ExecuteReader(string sql)
        {
            SqlConnection con = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable("Dt");
            con.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public static int ExecuteNonQuery(string sql)
        {
            SqlConnection con = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int sayi = 0;
            try
            {
                sayi = cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            return sayi;
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int sayi = 0;
            foreach (SqlParameter p in param)
            {
                cmd.Parameters.Add(p);
            }
            try
            {
                sayi = cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            return sayi;
        }

        public static object ExecuteScalar(string sql)
        {
            SqlConnection con = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            object o;
            try
            {
                o = cmd.ExecuteScalar();
            }
            finally
            {
                con.Close();
            }
            return o;
        }

    }
}
