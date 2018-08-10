using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyConsole
{
    class ToPrison : Cell
    {
        public ToPrison()
        {
        }
        public ToPrison(int idCell) : base(idCell)
        {
        }

        public override void Function(Player player)
        {
            player.MoveDown(number.distanceFromPrison);
            player.GoToPrison = 3;
        }
    }
}
