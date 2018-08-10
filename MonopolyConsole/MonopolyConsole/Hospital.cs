using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyConsole
{
    class Hospital : Cell
    {
        private int fixPenalty;
        public Hospital()
        {
        }

        public Hospital(int idCell, int buyCell, int sellCell, int penalty, int fixPenalty) : base (idCell, buyCell, sellCell, penalty)
        {
            this.fixPenalty = fixPenalty;
        }

        public override void Function(Player player)
        {
            BuyThisCell(player);
        }
    }
}
