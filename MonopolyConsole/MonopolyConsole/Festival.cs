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

        public Festival(int idCell, int price) : base(idCell)
        {
            this.price = price;
        }

        public int Price { get => price ; set => price = value ; }
    }
}
