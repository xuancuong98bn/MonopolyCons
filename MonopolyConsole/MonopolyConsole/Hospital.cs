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

        public Hospital(int idCell, String nameCell, int buyCell, int sellCell, int penalty, int fixPenalty) : base (idCell, nameCell, buyCell, sellCell, penalty)
        {
            this.fixPenalty = fixPenalty;
        }

        public override void Function(Player player)
        {
            double number = 1;
            if (player.HasHealCard-- > 0)
            {
                number = 0.5;
            }
            if (BuyThisCell(player, number))
            {
                penalty = fixPenalty;
            } else if (penalty != fixPenalty)
            {
                player.MakeMoney(-penalty);
            }
        }
    }
}
