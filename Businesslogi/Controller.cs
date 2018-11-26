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
        private static DatabaseCase currentDatabaseInstance = DatabaseCase.Instance();
        public static void Update(object objectToUpdate)
        {
            Case @case = (Case)objectToUpdate;
            currentDatabaseInstance.Update(@case);
        }

        public static List<Klient> GetAllClient()
        {
            //Klient klient = new Klient();
            List<Klient> GetClient = currentDatabaseInstance.KlientList();
            return GetClient;
        }
        public static List<Advokat> GetAllAdvokat()
        {
            //Advokat advokat = new Advokat();
            List<Advokat> ad = currentDatabaseInstance.GetAllAdvokat();
            return ad;
        }
        public static List<Case> GetAllCases()
        {
            //Case @case = new Case();
            List<Case> listToReturn = currentDatabaseInstance.GetAllCase();
            return listToReturn;
        }
        public static List<ListItems> GetAllItems()
        {
            //ListItems list = new ListItems();
            List<ListItems> GetItems = currentDatabaseInstance.GetList();
            return GetItems;
        }
        public static List<YdelseList> GetAllYdelser()
        {
            List<YdelseList> ydelseLists = currentDatabaseInstance.YdelsesLists();
            return ydelseLists;
        }
        public static List<YdelseType> GetAllYdelseType()
        {
            List<YdelseType> ydT = currentDatabaseInstance.YdelseType();
            return ydT;
        }

        public static void CreateCase(string Arbejdstitel, string StartDato, string SlutDato, string Kørselstimer,
            string TimeEstimat, string SagsBeskrivelse, string InterneNoter, string KlientNr, string AdvokatId, string YdelsesTypeNr)
        {
            Case @case = new Case(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, SagsBeskrivelse, InterneNoter, KlientNr, AdvokatId, YdelsesTypeNr);
            currentDatabaseInstance.CreateCase(@case);
        }
        public static void CreateAdvokat(string AdvokatId, string advokatNavn)
        {
            Advokat ad = new Advokat(AdvokatId, advokatNavn);
            currentDatabaseInstance.CreateAdvokat(ad);
        }
        public static void AddSpecialToAdvokat(string specialName, int advokatId)
        {
            currentDatabaseInstance.AddSpecialToAdvokat(specialName, advokatId);
        }
        public static void CreateKlient(String Navn, string Adresse, string TelefonNr)
        {
            Klient KL = new Klient(Navn, Adresse, TelefonNr);
            currentDatabaseInstance.CreateKlient(KL);
        }
    }
}
