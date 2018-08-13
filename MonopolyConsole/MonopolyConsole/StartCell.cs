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

        public StartCell(int idCell, String nameCell) : base(idCell, nameCell)
        {
            treasure = number.startCellValue;
        }

        public int Treasure { get => treasure; set => treasure = value; }

        public override void DoFunctionIfWalkThrough(Player player)
        {
            player.MakeMoney(Treasure);
        }
    }
}
