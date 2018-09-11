using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            VeryBadBoardGame mtg = new VeryBadBoardGame("mtg");

            Console.WriteLine(mtg.ExportToString());

            BadBoardGame badMtg = mtg;

            Console.WriteLine(badMtg.ExportToString());
        }
    }
}