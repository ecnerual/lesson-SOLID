using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace DependencyInversionPrinciple
{
    public class BadBoardGame : IExportable
    {
        public int PlayersCount { get; set; }
        public string GameName { get; set; }
        private int _gamePlayed = 0;

        public BadBoardGame(string gameName)
        {
            GameName = gameName;
        }

        private BadBoardGame(int gamePlayed, string gameName) : this(gameName)
        {
            _gamePlayed = gamePlayed;
        }

        public void Play()
        {
            _gamePlayed++;
            Console.WriteLine("play");
        }

        public void Save()
        {
            using (var sw = new StreamWriter($"{GameName}.txt"))
            {
                sw.Write(_gamePlayed);
            }
        }

        public static BadBoardGame Load(string gameName)
        {
            BadBoardGame game = null;

            try
            {
                using (var sr = new StringReader(gameName))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        game = new BadBoardGame(int.Parse(line), gameName);
                    }
                }
            }
            catch (Exception e)
            {
                LogError(e.Message);
            }


            return game;
        }


        private static void LogError(string log)
        {
            Console.WriteLine(log);
        }

        public string ExportToString()
        {
            return $"Our game is {GameName}!! game played: {_gamePlayed}";
        }

        public string ExportToCsv()
        {
            throw new NotImplementedException();
        }

        public string ExportToJSON()
        {
            throw new NotImplementedException();
        }
    }
}














//Donc, Ici je vais vous parler des 2 premier meilleur prince de programmation disponible 