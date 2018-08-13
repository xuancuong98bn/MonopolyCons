using System;
using System.Collections;
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
        private int hasHealCard;
        private int ownLandNumber;
        private int playedRound;

        private int countLocation;
        private Dice dice;
        private GameBoard gameBoard;
        private ArrayList listCell;

        private Number num;

        public string Name { get => name; set => name = value; }
        public int Cash { get => cash; set => cash = value; }
        public int Value { get => value; set => this.value = value; }
        public int Location { get => location; set => location = value; }
        public int GoToPrison { get => goToPrison; set => goToPrison = value; }
        public int OwnLandNumber { get => ownLandNumber; set => ownLandNumber = value; }
        public int PlayedRound { get => playedRound; set => playedRound = value; }
        public int HasHealCard { get => hasHealCard; set => hasHealCard = value; }

        public Player()
        {
        }
        public Player(string name, Dice dice, GameBoard gameBoard, ArrayList listCell)
        {
            this.Name = name;
            cash = 1000;
            value = 1000;
            location = 0;
            countLocation = 0;
            goToPrison = 0;
            hasHealCard = 0;
            ownLandNumber = 0;
            playedRound = 0;

            this.dice = dice;
            this.gameBoard = gameBoard;
            this.listCell = listCell;
            num = new Number();
        }

        public void PlayerInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Cash: " + cash);
            Console.WriteLine("Value: " + value);
            Console.WriteLine("Location: "+ location);
            Console.WriteLine("GotoPrison: " + goToPrison);
            Console.WriteLine("Number Heal Card: " + hasHealCard);
            Console.WriteLine("OwnlandNumber: " + ownLandNumber);
            Console.WriteLine("PlayedRound: " + playedRound+"\n");
        }
        public void MoveUp(int number)
        {
            CheckLocationWalkThrough(number);
            countLocation += number;
            UpdateLocation();
            CheckLocation();
        }

        public void MoveDown(int number)
        {
            countLocation -= number;
            UpdateLocation();
        }
        
        public void MoveTo(int toLocation)
        {
            if (toLocation < location)
            {
                toLocation += gameBoard.TotalCell;
            }
            MoveUp(toLocation - location);
        }
        //use with positive and negative number
        public void MakeMoney(int money)
        {
            cash += money;
            value += money;
        }

        public void FineTo(Player otherPlayer, int penalty)
        {
            MakeMoney(-penalty);
            otherPlayer.MakeMoney(penalty);
        }

        public bool BuyCell(Cell cell)
        {
            if (cash < cell.BuyCell) return false;
            cash -= cell.BuyCell;
            value = value - cell.BuyCell + cell.ValueCell;
            cell.Owner = this ;
            return true;
        }

        public bool UpgradeCell(int moneyUp)
        {
            if (cash < moneyUp) return false;
            cash -= moneyUp;
            return true;
        }

        private void UpdateLocation()
        {
            location = countLocation % gameBoard.TotalCell;
            playedRound = countLocation / gameBoard.TotalCell;
        }

        public void CheckLocation()
        {
            PlayerInfo();
            ((Cell)listCell[location]).Function(this);
        }

        public void CheckLocationWalkThrough(int numberDice)
        {
            int playerLocation = location;
            int nextLocation = playerLocation + numberDice;
            for (int i = playerLocation + 1; i < nextLocation; i++)
            {
                int loc = i % gameBoard.TotalCell;
                ((Cell)listCell[loc]).DoFunctionIfWalkThrough(this);
            }
        }

        public void TurnPlayer()
        {
            int number = dice.RollDice();
            Console.WriteLine("Dice: " + number);
            if (number == num.outPrisonNum)
            {
                goToPrison = 0;
            }
            if (goToPrison > 0) goToPrison--;
            else
            {
                MoveUp(number);
            }
        }
    }
}
