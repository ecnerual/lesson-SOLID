namespace DependencyInversionPrinciple
{
    public class Log
    {
        public string Body { get; set; }

        public Log(string body)
        {
            Body = body;
        }
    }
}