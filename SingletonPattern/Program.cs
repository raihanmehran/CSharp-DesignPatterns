// See https://aka.ms/new-console-template for more information


using SingletonPattern;

var twitterBroker = TwitterBroker.TwitterBrokerInstance;
Console.WriteLine(twitterBroker.Timeout);
twitterBroker.Timeout = 100;

var anotherTotallyDifferentItSeemsTwitterBroker = TwitterBroker.TwitterBrokerInstance;
Console.WriteLine();
Console.WriteLine(twitterBroker.Timeout);
Console.WriteLine(anotherTotallyDifferentItSeemsTwitterBroker.Timeout);


anotherTotallyDifferentItSeemsTwitterBroker.Timeout = 200;
Console.WriteLine();
Console.WriteLine(twitterBroker.Timeout);
Console.WriteLine(anotherTotallyDifferentItSeemsTwitterBroker.Timeout);

var twitterBroker3 = TwitterBroker.TwitterBrokerInstance;
twitterBroker3.Timeout = 50;



Console.WriteLine();
Console.WriteLine(twitterBroker.Timeout);
Console.WriteLine(anotherTotallyDifferentItSeemsTwitterBroker.Timeout);
Console.WriteLine(twitterBroker3.Timeout);