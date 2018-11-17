class Price : Menuitem
{
    private int waarde;
    private string valuta;

    public int Waarde 
    {get{
        return Waarde;
    }
    set
    {
        Waarde=value;
    }}
    public string Valuta {get; set;}

    public Price(int Waarde, string Valuta)
    {
        //Laadvermogen = laadvermogen;
        Waarde = waarde;
        Valuta=valuta;
        
    }
    public Price()
    {

    }
}