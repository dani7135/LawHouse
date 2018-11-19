using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //Singletone er blevet brugt nedenunder og i kontrolleren
    //A singleton is a convenient way for accessing the service from anywhere in the application code
    public class Database
    {
        private static Database _database = null;
        private Database() { }
        public static Database Instance()
        {
            if (_database == null)
            {
                _database = new Database();

            }
            return _database;
        }
        public void CreateCase(string Arbejdstitel, string StartDato, string SlutDato, string Kørselstimer, string TimeEstimat, string Klientnr, string MedarbejderNr)
        {
            Case c = new Case(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, Klientnr, MedarbejderNr);
            using (var conn = new SqlConnection(Properties.Settings.Default.Constring))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                conn.Open();

                string sqlString = $"insert into Sag(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, Klientnr, MedarbejderNr)" + $"values('{c.Arbejdstitel}' , '{c.StartDato}' ,'{c.SlutDato}' ,'{c.Kørselstimer}' ,'{c.TimeEstimat}' , '{c.Klientnr}', '{MedarbejderNr}')";
                com.CommandText = sqlString;
                Console.WriteLine(sqlString);
                com.ExecuteNonQuery();
            }
        }
        public void CreateCase(Case c)
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.Constring))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                conn.Open();

                string sqlString = $"insert into Sag(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, Klientnr, MedarbejderNr)" + $"values('{c.Arbejdstitel}' , '{c.StartDato}' ,'{c.SlutDato}' ,'{c.Kørselstimer}' ,'{c.TimeEstimat}', '{c.Klientnr}' ,'{c.MedarbejderNr}')";
                com.CommandText = sqlString;
                Console.WriteLine(sqlString);
                com.ExecuteNonQuery();
            }
        }
        public DataTable GetAllCases()
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
