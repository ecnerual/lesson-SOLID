using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            var rip = new BadBoardGame("mtg");
            
            rip.Play();
            rip.Save();
            Console.Write(rip.GameName);
            rip.Save();
            
            var wgf = BadBoardGame.Load("mtg");
        }
    }
}