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
    public class DatabaseCase
    {
        private static DatabaseCase _database = null;
        private DatabaseCase() { }
        public static DatabaseCase Instance()
        {
            if (_database == null)
            {
                _database = new DatabaseCase();

            }
            return _database;
        }
        /*   public void CreateCase(string Arbejdstitel, string StartDato, string SlutDato, string Kørselstimer, string TimeEstimat, string SagsBeskrivelse , string InterneNoter, string KlientNr, string AdvokatId)
           {
               Case c = new Case(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, SagsBeskrivelse, InterneNoter, KlientNr, AdvokatId);
               using (var conn = new SqlConnection(Properties.Settings.Default.ConnString))
               {
                   using (SqlCommand com = new SqlCommand())
                   {
                       com.Connection = conn;
                       conn.Open();

                       string sqlString = $"insert into Sag(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, SagsBeskrivelse, InterneNoter , Klientnr, AdvokatId)" + $"values('{c.Arbejdstitel}' , '{c.StartDato}' ,'{c.SlutDato}' ,'{c.Kørselstimer}' ,'{c.TimeEstimat}' , '{c.SagsBeskrivelse}',  '{c.InterneNoter}' , '{c.KlientNr}', '{c.AdvokatId}')";
                       com.CommandText = sqlString;
                       Console.WriteLine(sqlString);
                       com.ExecuteNonQuery();
                   }

               }
           }
           */
       

        public void CreateCase(Case c)//Grunden til at der den her er fordi den tager en case og opretter det ud for properties
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = conn;
                    conn.Open();

                    string sqlString = $"insert into Sag(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, SagsBeskrivelse, InterneNoter , KlientNr, AdvokatId, YdelsesTypeNr)" + $"values('{c.Arbejdstitel}' , '{c.StartDato}' ,'{c.SlutDato}' ,'{c.Kørselstimer}' ,'{c.TimeEstimat}' , '{c.SagsBeskrivelse}',  '{c.InterneNoter}' , '{c.KlientNr}', '{c.AdvokatId}' , '{c.YdelsesTypeNr}')";
                    com.CommandText = sqlString;
                    com.ExecuteNonQuery();
                }

            }
        }

        public List<Case> GetAllCase()
        {
            string sqlString = "select * from Sag " +
               "join Advokat on Sag.AdvokatID = Advokat.AdvokatId" +
            " join Klient on Sag.KlientNr = Klient.KlientNr";

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
                            @case.SagsNr = sqld["SagsNr"].ToString();
                            @case.Arbejdstitel = sqld["Arbejdstitel"].ToString();
                            @case.StartDato = sqld["StartDato"].ToString();
                            @case.SlutDato = sqld["SlutDato"].ToString();
                            @case.Kørselstimer = sqld["Kørselstimer"].ToString();
                            @case.TimeEstimat = sqld["TimeEstimat"].ToString();
                            @case.SagsBeskrivelse = sqld["SagsBeskrivelse"].ToString();
                            @case.InterneNoter = sqld["InterneNoter"].ToString();
                            @case.KlientNr = sqld["Klientnr"].ToString();
                            @case.AdvokatId = sqld["AdvokatId"].ToString();
                            @case.YdelsesTypeNr = sqld["YdelsesTypeNr"].ToString();
                            Alle.Add(@case);
                        }
                    return Alle;
                }
            }

        }
        public void Update(Case @case)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = conn;
                    conn.Open();

                    string sqlString =
                    $"update Sag set Arbejdstitel = '{@case.Arbejdstitel}', StartDato = '{@case.StartDato}', SlutDato = '{@case.SlutDato}', Kørselstimer = '{@case.Kørselstimer}', TimeEstimat = '{@case.TimeEstimat}', SagsBeskrivelse = '{@case.SagsBeskrivelse}', InterneNoter = '{@case.InterneNoter}', KlientNr = '{@case.KlientNr}', AdvokatId = '{@case.AdvokatId}', YdelsesTypeNr = '{@case.YdelsesTypeNr}' " +
                    $"where SagsNr = {@case.SagsNr}";
                    com.CommandText = sqlString;
                    com.ExecuteNonQuery();
                }


            }
        }
        public List<ListItem> GetList()
        {
            string sqlString = "select * from List";
            List<ListItem> All = new List<ListItem>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            using (SqlCommand com = new SqlCommand(sqlString, conn))
            {
                conn.Open();
                using (SqlDataReader sqld = com.ExecuteReader())
                {
                    if (sqld.HasRows)
                        while (sqld.Read())
                        {
                            ListItem @list = new ListItem();
                            @list.ListID = sqld["ListID"].ToString();
                            @list.What_type = sqld["What_type"].ToString();
                            All.Add(@list);
                        }
                    return All;
                }
            }
        }

        public List<Klient> KlientList()
        {
            string sqlString = "select * from Klient";
            List<Klient> All = new List<Klient>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            using (SqlCommand com = new SqlCommand(sqlString, conn))
            {
                conn.Open();
                using (SqlDataReader sqld = com.ExecuteReader())
                {
                    if (sqld.HasRows)
                        while (sqld.Read())
                        {
                            Klient @klient = new Klient();
                            @klient.KlientNr = sqld["KlientNr"].ToString();
                            @klient.Navn = sqld["Navn"].ToString();
                            @klient.Adresse = sqld["Adresse"].ToString();
                            @klient.TelefonNr = sqld["TelefonNr"].ToString();
                            All.Add(@klient);
                        }
                    return All;
                }
            }
        }


    }


}

