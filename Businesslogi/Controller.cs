﻿using System;
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
       public static void CreateCase(string Arbejdstitel, string StartDato, string SlutDato, string Kørselstimer, string TimeEstimat, string SagsBeskrivelse, string InterneNoter, string KlientNr, string AdvokatId)
        {
            Case @case = new Case(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, SagsBeskrivelse, InterneNoter, KlientNr, AdvokatId);
            database.CreateCase(@case);
        }
   
        public static List<Case> HentAlleCases()
        {
            Case @case = new Case();
            List<Case> HentAlle = database.GetAllCase();

            return HentAlle;
        }   
        public static void Opdater(object opdateretObjekt)
        {

            Case @case = (Case)opdateretObjekt;
            database.Update(@case);

        }
        public static List<ListItems> GetAllItems()
        {
            ListItems list = new ListItems();
            List<ListItems> GetItems = database.GetList();
            return GetItems;
        }
         
         
    }
}
