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

        private static Database database = Database.Instance();
       public static void CreateCase(string Arbejdstitel, string StartDato, string SlutDato, string Kørselstimer, string TimeEstimat,string Klientnr, string MedarbejderNr)
        {
            Case @case = new Case(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, Klientnr, MedarbejderNr);
            database.CreateCase(@case);
        }


    }
}
