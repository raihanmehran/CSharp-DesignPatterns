// See https://aka.ms/new-console-template for more information


using FactoryDesignPattern;

Console.WriteLine("Welcome to Starbucks :)");

Console.WriteLine("What kink of drink sir ?");

string drinkkind = Console.ReadLine();

IDrink drink = DrinksFactory.CreateDrink(drinkkind);

Console.WriteLine($"Here's you drink sir, that's gonna be {drink.Price()}");

Console.ReadKey();