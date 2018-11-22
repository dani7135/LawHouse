namespace DataAccess
{
    public class Advokat
    {
        public string Navn { get; set; }
        public string Efteruddannelse { get; set; } 

        public Advokat() { }
        public Advokat(string navn)
        {
            Navn = navn;
        }
        public Advokat(string navn, string efteruddannelse)
        {
            Navn = navn;
            Efteruddannelse = efteruddannelse;
        }
    }
}