class Voertuig
{
    //velden
    private int laadvermogen;
    private string kleur;
    //properties
    //methodes
    //constructors
    //...

    

    //properties
    // int Laadvermogen
    // {
    //     get;
    //     set;
    // }

    //property
    public int Laadvermogen
    {
        get
        {
            return laadvermogen;
        }
        set
        {
            laadvermogen=value;
        }
        
    }
    public string Motor {get; set;}
    public string Kleur {get; set;}

    //constructor
    public Voertuig(int laadvermogen, string kleur)
    {
        //Laadvermogen = laadvermogen;
        this.laadvermogen = laadvermogen;
        Kleur = kleur;
    }

    public Voertuig()
    {
    }

    //uitlezen
    public string ToString()
    {
        return "Voertuig met laadvermogen: "+ this.laadvermogen + ", kleur: "+ this.Kleur;
    }
}