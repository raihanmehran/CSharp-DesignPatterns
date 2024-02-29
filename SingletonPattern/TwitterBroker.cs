namespace SingletonPattern
{
    public sealed class TwitterBroker
    {
        private TwitterBroker()
        {
            
        }

        public static TwitterBroker TwitterBrokerInstance { get; } = new TwitterBroker();

        public int Timeout { get; set; }
    }
}
