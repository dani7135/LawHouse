using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class  Cases
    {
        public string SagsNr { get; set; }
        public string Arbejdstitel { get; set; }
        public string StartDato { get; set; }
        public string SlutDato { get; set; }
        public string Kørselstimer { get; set; }
        public string TimeEstimat { get; set; }

        public Cases() { }
        public Cases(string Arbejdstitel, string StartDato, string SlutDato, string Kørselstimer, string TimeEstimat)
        {
            this.Arbejdstitel = Arbejdstitel;
            this.StartDato = StartDato;
            this.StartDato = SlutDato;
            this.Kørselstimer = Kørselstimer;
            this.TimeEstimat = TimeEstimat;
        }

    }
  public  class CasesDatabase
    {
        public static void CreateCases(string Arbejdstitel, string StartDato, string SlutDato, string Kørselstimer, string TimeEstimat)
        {
            Cases c = new Cases(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat);
            using (var conn = new SqlConnection(Properties.Settings.Default.Constring))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                conn.Open();

                string sqlString = $"insert into goodboysplus1(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat)" + $"values('{Arbejdstitel}' , '{StartDato}' ,'{SlutDato}' ,'{Kørselstimer}' ,'{TimeEstimat}')";
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
