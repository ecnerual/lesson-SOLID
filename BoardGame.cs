using System;

namespace DependencyInversionPrinciple
{
    public class BoardGame
    {
        private readonly ILogger _logger;

        public BoardGame(ILogger log)
        {
            _logger = log;
        }

        public void Play(int nbOfPlayers)
        {
            if (nbOfPlayers <= 1)
            {
                _logger.Error(new Log("PAS D AMIS LOL!"));
            }

            Console.WriteLine("lets play some magic!");
        }
    }
}