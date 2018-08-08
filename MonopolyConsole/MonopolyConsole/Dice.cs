using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyConsole
{
    class Dice
    {
        private int number = 0;
        private Random rand;

        public Dice()
        {
            rand = new Random();
        }

        public int RollDice()
        {
            number = rand.Next(1, 7);
            return number;
        }
    }
}
