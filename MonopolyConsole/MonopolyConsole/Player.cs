using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyConsole
{
    class Player
    {
        private string name;
        private int cash;
        private int value;
        private int location;
        private int goToPrison;
        private int ownLandNumber;
        private int playedRound;

        public string Name { get => name; set => name = value; }
        public int Cash { get => cash; set => cash = value; }
        public int Value { get => value; set => this.value = value; }
        public int Location { get => location; set => location = value; }
        public int GoToPrison { get => goToPrison; set => goToPrison = value; }
        public int OwnLandNumber { get => ownLandNumber; set => ownLandNumber = value; }
        public int PlayedRound { get => playedRound; set => playedRound = value; }

        public Player()
        {
        }
        public Player(string name)
        {
            this.Name = name;
            cash = 1000;
            value = 1000;
            location = 0;
            goToPrison = 0;
            ownLandNumber = 0;
            playedRound = 0;
        }

        public void moveUp(int number)
        {
            location += number;
        }

        public void moveDown(int number)
        {
            location -= number;
        }
        
        public void updateInfoPlayer()
        {

        }
    }
}
