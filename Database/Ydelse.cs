using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class YdelseList
    {
        public string AdvokatId { get; set; }
        public string YdelsesTypeNr { get; set; }

        public YdelseList() { }
        public YdelseList(string AdvokatId, string YdelsesTypeNr)
        {
            this.AdvokatId = AdvokatId;
            this.YdelsesTypeNr = YdelsesTypeNr;
        }
    }
    public class YdelseType
    {
        public string YdelsesTypeNr { get; set; }
        public string YdelsesNavn { get; set; }

        public YdelseType () { }
        public YdelseType(string YdelsesTypeNr,string YdelsesNavn)
        {
            this.YdelsesNavn = YdelsesNavn;
            this.YdelsesTypeNr = YdelsesTypeNr;

        }
    }
}
