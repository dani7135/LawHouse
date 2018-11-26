using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace BusinessLogic
{

    public class Controller
    {
        private static DatabaseCase database = DatabaseCase.Instance();
       public static void CreateCase(string Arbejdstitel, string StartDato, string SlutDato, string Kørselstimer, string TimeEstimat, string SagsBeskrivelse, string InterneNoter, string KlientNr, string AdvokatId, string YdelsesTypeNr)
        {
            Case @case = new Case(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, SagsBeskrivelse, InterneNoter, KlientNr, AdvokatId, YdelsesTypeNr);
            database.CreateCase(@case);
        }
   
        public static List<Case> GetAllCases()
        {
            Case @case = new Case();
            List<Case> GetAll = database.GetAllCase();

            return GetAll;
        }   
        public static void Update(object UpdateObject)
        {

            Case @case = (Case)UpdateObject;
            database.Update(@case);

        }
        public static List<ListItems> GetAllItems()
        {
            ListItems list = new ListItems();
            List<ListItems> GetItems = database.GetList();
            return GetItems;
        }

        public static void CreateAdvokat(string advokatNavn)
        {
            Advokat ad = new Advokat(advokatNavn);
            database.CreateAdvokat(ad);
        }
        public static void AddSpecialToAdvokat(string specialName, int advokatId)
        {
            database.AddSpecialToAdvokat(specialName, advokatId);
        }
        public static List<Klient> GetAllClient()
        {
            Klient klient = new Klient();
            List<Klient> GetClient = database.KlientList();
            return GetClient;
        }
        public static void CreateKlient()
        {
            Klient KL = new Klient();
            database.CreateKlient(KL);
        }

    }
}
