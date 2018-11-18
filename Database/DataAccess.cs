using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
   
  public  class Database
    {
        public static void CreateCase(string Arbejdstitel, string StartDato, string SlutDato, string Kørselstimer, string TimeEstimat)
        {
            Case c = new Case(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat);
            using (var conn = new SqlConnection(Properties.Settings.Default.Constring))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                conn.Open();

                string sqlString = $"insert into goodboysplus1(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat)" + $"values('{c.Arbejdstitel}' , '{c.StartDato}' ,'{c.SlutDato}' ,'{c.Kørselstimer}' ,'{c.TimeEstimat}')";
                com.CommandText = sqlString;
                Console.WriteLine(sqlString);
                com.ExecuteNonQuery();
            }
        }
        public static void CreateCase(Case c)
        {
             using (var conn = new SqlConnection(Properties.Settings.Default.Constring))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                conn.Open();

                string sqlString = $"insert into goodboysplus1(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat)" + $"values('{c.Arbejdstitel}' , '{c.StartDato}' ,'{c.SlutDato}' ,'{c.Kørselstimer}' ,'{c.TimeEstimat}')";
                com.CommandText = sqlString;
                Console.WriteLine(sqlString);
                com.ExecuteNonQuery();
            }
        }
        public static DataTable GetAllCases()
        {
            using (SqlConnection conn = new SqlConnection
                (Properties.Settings.Default.Constring))
            {
                conn.Open();

                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Sag", conn))
                {
                    DataTable t = new DataTable();
                    sda.Fill(t);
                    return t;
                }

            }
        }
    }
}
