using System;
using System.Collections.Generic;
using System.Text;

namespace logicRockPaperScissors
{
    class Player
    {
        string name;
        string hand;
        public Player(string name, string hand)
        {
            this.name = name;
            this.hand = hand;
        }
        RockPaperScissorsGameLogic logicGame = new RockPaperScissorsGameLogic();
    }
}