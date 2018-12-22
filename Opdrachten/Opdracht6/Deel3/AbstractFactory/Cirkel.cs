namespace AbstractFactory
{
  public class Cirkel : IVorm
  {
    public void Teken()
    {
      // hier kan je vb velden aanmaken met diameter en straal (in vormfactory kan je dan de parameters meegeven)
      System.Console.WriteLine("Cirkel");
      // throw new System.NotImplementedException();
    }
  }
}