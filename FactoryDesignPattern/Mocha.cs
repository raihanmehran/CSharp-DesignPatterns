namespace FactoryDesignPattern
{
    public class Mocha : IDrink
    {
        public Mocha(string[] ingredients)
        {

        }

        public void Making()
        {
            throw new NotImplementedException();
        }

        public int Price()
        {
            return 5;
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}
