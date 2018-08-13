using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyConsole
{
    class Festival : Cell
    {
        private int price;

        public Festival()
        {
        }

        public Festival(int idCell, String nameCell) : base(idCell, nameCell)
        {
            price = number.festivalValue;
        }

        public int Price { get => price ; set => price = value ; }

        public override void Function(Player player)
        {
            //will override later
        }
    }
}
