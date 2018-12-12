namespace startproject
{
    public class Drank : Product
    {
        private int hoeveelheid;
        private bool alcoholAanwezig;
        public override int BerekenKCal()
            {
                return 10;
            }
    }
}

