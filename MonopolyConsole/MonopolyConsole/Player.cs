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

        private int countLocation;
        private GameBoard gameBoard;

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
        public Player(string name, GameBoard gameBoard)
        {
            this.Name = name;
            cash = 1000;
            value = 1000;
            location = 0;
            countLocation = 0;
            goToPrison = 0;
            ownLandNumber = 0;
            playedRound = 0;

            this.gameBoard = gameBoard;
        }

        public void MoveUp(int number)
        {
            countLocation += number;
            UpdateLocation();
        }

        public void MoveDown(int number)
        {
            countLocation -= number;
            UpdateLocation();
        }
        
        private void UpdateLocation()
        {
            location = countLocation % gameBoard.TotalCell;
            playedRound = countLocation / gameBoard.TotalCell;
        }
    }
}
