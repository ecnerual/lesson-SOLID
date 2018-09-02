using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger loger = new ConsoleLogger();

            Console.WriteLine("Hello World!");

            BoardGame magic = new BoardGame(loger);
            
            magic.Play(1);
        }
    }
}