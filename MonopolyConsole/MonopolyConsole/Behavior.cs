using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MonopolyConsole
{
    class Behavior
    {
        private Player player;
        private Dice dice;
        private GameBoard gameBoard;
        private ArrayList listCell;
        private Number num;


        public Behavior()
        {
        }

        public Behavior(Player player, Dice dice, GameBoard gameBoard, ArrayList listCell)
        {
            this.player = player;
            this.dice = dice;
            this.gameBoard = gameBoard;
            this.listCell = listCell;
            num = new Number();
        }

        public void CheckLocation()
        {
            int playerLocation = player.Location;
            player.PlayerInfo();
            ((Cell)listCell[playerLocation]).Function(player);
        }

        public void CheckLocationWalkThrough(int numberDice)
        {
            int playerLocation = player.Location;
            int nextLocation = playerLocation + numberDice;
            for (int i = playerLocation+1; i < nextLocation; i++)
            {
                if (i >= gameBoard.TotalCell)
                {
                    i -= gameBoard.TotalCell;
                }
                ((Cell)listCell[i]).DoFunctionIfWalkThrough(player);
            }
        }

        public void TurnPlayer()
        {
            CheckLocation();
            int number =  dice.RollDice();
            if (number == num.outPrisonNum)
            {
                player.GoToPrison = 0;
            }
            if (player.GoToPrison > 0) player.GoToPrison--;
            else
            {
                CheckLocationWalkThrough(number);
                player.MoveUp(number);
                CheckLocation();
            }
        }
    }
}
