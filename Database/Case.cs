﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
   public class Case
    {
        public string SagsNr { get; set; }
        public string Arbejdstitel { get; set; }
        public string StartDato { get; set; }
        public string SlutDato { get; set; }
        public string Kørselstimer { get; set; }
        public string TimeEstimat { get; set; }

        public Case() { }
        public Case(string Arbejdstitel, string StartDato, string SlutDato, string Kørselstimer, string TimeEstimat)
        {
            this.Arbejdstitel = Arbejdstitel;
            this.StartDato = StartDato;
            this.StartDato = SlutDato;
            this.Kørselstimer = Kørselstimer;
            this.TimeEstimat = TimeEstimat;
        }
    }
}