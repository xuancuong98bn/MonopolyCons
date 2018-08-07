using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MonopolyConsole
{
    class RunGame
    {
        static void Main(string[] args)
        {
            GameBoard gameBoard = new GameBoard(10);
            Player player = new Player();
            Dice dice = new Dice();
            ArrayList listCell = gameBoard.initCell();
            Behavior behavior = new Behavior(player, dice, gameBoard, listCell);

            
            behavior.turnPlayer();
            behavior.turnPlayer();
            behavior.turnPlayer();
            Console.ReadKey();
        }
    }
}