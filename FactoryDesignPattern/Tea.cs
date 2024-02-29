namespace FactoryDesignPattern
{
    public class Tea : IDrink
    {
        public Tea(string[] ingredients)
        {
            
        }
        public void Making()
        {
            throw new NotImplementedException();
        }

        public int Price()
        {
            return 3;
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}
