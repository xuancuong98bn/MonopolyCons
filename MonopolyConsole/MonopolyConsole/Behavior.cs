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
        
        public Behavior()
        {
        }

        public Behavior(Player player, Dice dice, GameBoard gameBoard, ArrayList listCell)
        {
            this.player = player;
            this.dice = dice;
            this.gameBoard = gameBoard;
            this.listCell = listCell;
        }

        public void CheckLocation()
        {
            int playerLocation = player.Location;
            Console.WriteLine(playerLocation);
            ((Cell)listCell[playerLocation]).Function();
        }

        public void TurnPlayer()
        {
            CheckLocation();
            int number =  dice.RollDice();
            player.MoveUp(number);
            CheckLocation();
        }
    }
}
