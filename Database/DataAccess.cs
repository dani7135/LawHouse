using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess// testComment
{
    //Singletone er blevet brugt nedenunder og i kontrolleren
    //A singleton is a convenient way for accessing the service from anywhere in the application code
    public class Database
    {
        int testint;
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
        public void CreateCase(string Arbejdstitel, string StartDato, string SlutDato, string Kørselstimer, string TimeEstimat, string SagsBeskrivelse , string InterneNoter, string Klientnr, string AdvokatId)
        {
            Case c = new Case(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, SagsBeskrivelse, InterneNoter, Klientnr, AdvokatId);
            using (var conn = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = conn;
                    conn.Open();

                    string sqlString = $"insert into Sag(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, SagsBeskrivelse, InterneNoter , Klientnr, AdvokatId)" + $"values('{c.Arbejdstitel}' , '{c.StartDato}' ,'{c.SlutDato}' ,'{c.Kørselstimer}' ,'{c.TimeEstimat}' , '{c.SagsBeskrivelse}',  '{c.InterneNoter}' , '{c.Klientnr}', '{c.AdvokatId}')";
                    com.CommandText = sqlString;
                    Console.WriteLine(sqlString);
                    com.ExecuteNonQuery();
                }

            }
        }
        public void CreateCase(Case c)
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                conn.Open();

                string sqlString = $"insert into Sag(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, SagsBeskrivelse, InterneNoter , Klientnr, AdvokatId)" + $"values('{c.Arbejdstitel}' , '{c.StartDato}' ,'{c.SlutDato}' ,'{c.Kørselstimer}' ,'{c.TimeEstimat}' , '{c.SagsBeskrivelse}',  '{c.InterneNoter}' , '{c.Klientnr}', '{c.AdvokatId}')";
                com.CommandText = sqlString;
                Console.WriteLine(sqlString);
                com.ExecuteNonQuery();
            }
        }

        /*public DataTable GetAllCases()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                conn.Open();

                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Sag", conn))
                {
                    DataTable t = new DataTable();
                    sda.Fill(t);
                    return t;
                }

            }Skal nok slettes
        }*/ 

        public List<Case> GetAllCase()
        {
            string sqlString = "select * from Sag " +
               "join Advokat on Sag.AdvokatID = Advokat.AdvokatId";

            List<Case> Alle = new List<Case>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            using (SqlCommand com = new SqlCommand(sqlString, conn))
            {
                conn.Open();
                using (SqlDataReader sqld = com.ExecuteReader())
                {
                    if (sqld.HasRows)
                        while (sqld.Read())
                        {
                            Case @case = new Case();
                            @case.SagsNr = sqld["Sagsnr"].ToString();
                            @case.Arbejdstitel = sqld["Arbejdstitel"].ToString();
                            @case.StartDato = sqld["StartDato"].ToString();
                            @case.SlutDato = sqld["SlutDato"].ToString();
                            @case.Kørselstimer = sqld["Kørselstimer"].ToString();
                            @case.TimeEstimat = sqld["TimeEstimat"].ToString();
                            @case.SagsBeskrivelse = sqld["SagsBeskrivelse"].ToString();
                            @case.InterneNoter = sqld["InterneNoter"].ToString();
                            @case.Klientnr = sqld["Klientnr"].ToString();
                            @case.AdvokatId = sqld["AdvokatId"].ToString();
                            Alle.Add(@case);
                        }
                    return Alle;
                }
            }
        }
    }

}

