using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyConsole
{
    class StartCell : Cell
    {
        private int treasure;

        public StartCell()
        {
        }

        public StartCell(int idCell, int treasure) : base(idCell)
        {
            Treasure = treasure;
        }

        public int Treasure { get => treasure; set => treasure = value; }

        public override void Function()
        {
            Console.WriteLine("ec");
        }
    }
}
