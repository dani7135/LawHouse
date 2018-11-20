using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Case
    {
        public string SagsNr { get; set; }
        public string Arbejdstitel { get; set; }
        public string StartDato { get; set; }
        public string SlutDato { get; set; }
        public string Kørselstimer { get; set; }
        public string TimeEstimat { get; set; }     
        public string SagsBeskrivelse { get; set; } 
        public string InterneNoter { get; set; }
        public string Klientnr { get; set; }
        public string AdvokatId { get; set; }

        public Case() { }
        public Case(string Arbejdstitel, string StartDato, string SlutDato, string Kørselstimer, string TimeEstimat, string SagsBeskrivelse , string InterneNoter, string Klientnr, string AdvokatId)
        {
            this.Arbejdstitel = Arbejdstitel;
            this.StartDato = StartDato;
            this.SlutDato = SlutDato;
            this.Kørselstimer = Kørselstimer;
            this.TimeEstimat = TimeEstimat;
            this.SagsBeskrivelse = SagsBeskrivelse;
            this.InterneNoter = InterneNoter;
            this.Klientnr = Klientnr;
            this.AdvokatId = AdvokatId;
        }
    }
}
