namespace DataAccess
{
    public class Advokat
    {
        public string AdvokatId { get; set; }
        public string Navn { get; set; }
        public string Efteruddannelse { get; set; } 

        public Advokat() { }
        public Advokat(string AdvokatId, string navn)
        {
            AdvokatId = AdvokatId;
            Navn = navn;
        }
        public Advokat(string AdvokatId, string navn, string efteruddannelse)
        {
            AdvokatId = AdvokatId;
            Navn = navn;
            Efteruddannelse = efteruddannelse;
        }
    }
}