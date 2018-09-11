using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    class VeryBadBoardGame : BadBoardGame
    {
        public VeryBadBoardGame(string gameName) : base(gameName)
        {
        }

        public new string ExportToString()
        {
            return "this is so bad m8! Never play this game!!!";
        }
    }
}
