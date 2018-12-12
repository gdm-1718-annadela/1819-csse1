namespace deel2
{
    public class Gebruiker
    {
        protected string wachtwoord;
        public string Gebruikersnaam
        {
            get;
            set;
        }

        public virtual string GenereerWachtwoord()
        {
            return "Gebruiker - wachtwoord";
        }

        public void GenereerGebruikersaam()
        {
            this.Gebruikersnaam = "test";
        }

        public Gebruiker()
        {
            this.wachtwoord = GenereerWachtwoord();
        }

    }
}