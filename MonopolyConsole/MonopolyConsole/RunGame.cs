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
            Number number = new Number();
            ArrayList listCell = new ArrayList();
            Dice dice = new Dice();
            GameBoard gameBoard = new GameBoard(number.numCell, listCell);
            Player player = new Player("Player 1", dice, gameBoard, listCell);

            player.TurnPlayer();
            player.TurnPlayer();
            player.TurnPlayer();
            Console.ReadKey();
        }
    }
}