namespace ObserverPattern
{
    public class Candidate
    {
        public string Name { get; set; }  
        public void Notify(string opportunities)
        {
            Console.WriteLine($"{this.Name} has been notified about the new opportunities: {opportunities}");
        }
    }
}