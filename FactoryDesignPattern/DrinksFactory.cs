namespace FactoryDesignPattern
{
    public class DrinksFactory
    {
        public static IDrink CreateDrink(string drinkType)
        {
            switch (drinkType)
            {
                case "Mocha":
                    return new Mocha(new string[] { "coffee", "milk", "other stuff" });
                case "Tea":
                    return new Tea(new string[] { "black tea", "hot water", "suger" });
                default:
                    return null;
            }
        } 
    }
}
