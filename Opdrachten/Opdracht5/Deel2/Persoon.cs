using System;

namespace deel2
{
    public class Persoon : Gebruiker, IInformatie
    {
        private string naam;
        private string voornaam;
        public string Naam
        {
            get
            {
                return this.naam;
            }
            set
            {
                this.naam = value;
            }
        }

        public string Voornaam
        {
            get
            {
                return this.voornaam;
            }
            set
            {
                this.voornaam = value;
            }
        }

        public string VolledigeNaam
        {
            get;
        }

        public DateTime GeboorteDatum
        {
            get;
            set;
        }


        public int Leeftijd()
        {
            return 0;
        }

        public override string GenereerWachtwoord()
        {
            return "Persoon - wachtwoord";
        }

        public string GenereerWachtwoord(int input)
        {
            return "Test2";
        }

         public string GenereerWachtwoord(string input)
        {
            return "Test1";
        }


       /*  public int GenereerWachtwoord()
        {
            return "54896465";
        } */

        public override string ToString()
        {
            return "waarden van object persoon";
        }
      
    }
}