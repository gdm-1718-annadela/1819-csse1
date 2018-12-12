namespace deel2
{
    public class Docent:Persoon
    {

        public string Emailadres
        {
            get;
            set;
        }

        public Opleiding Opleiding
        {
            get;
            set;
        }
        // list?
        
        public override int GenereerWachtwoord()
        {
            return 8;
        }
    }
}