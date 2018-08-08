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
            ArrayList listCell = new ArrayList();
            GameBoard gameBoard = new GameBoard(54, listCell);
            Player player = new Player("Player 1", gameBoard);
            Dice dice = new Dice();
            Behavior behavior = new Behavior(player, dice, gameBoard, listCell);

            
            behavior.TurnPlayer();
            behavior.TurnPlayer();
            behavior.TurnPlayer();
            Console.ReadKey();
        }
    }
}