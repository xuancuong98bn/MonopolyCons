using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyConsole
{
    class Park : Cell
    {
        public Park()
        {
        }

        public Park(int idCell) : base (idCell)
        {
        }

        public override void Function(Player player)
        {
            int number = 0;
            int playerLocation = player.Location;
            do
            {
                Console.Write("Enter number want to go: ");
            } while (!int.TryParse(Console.ReadLine(), out number));
            player.MoveTo(number);

        }
    }
}
