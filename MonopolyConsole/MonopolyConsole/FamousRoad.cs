using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyConsole
{
    class FamousRoad : Cell
    {
        private int levelHouse;
        private int buyHouse_1;
        private int buyHouse_2;
        private int buyRestaurant;
        private int[] priceUpgrate;

        public FamousRoad()
        {
        }

        public FamousRoad(int idCell, String nameCell, int buyCell, int sellCell, int penalty, 
            int buyHouse_1, int buyHouse_2, int buyRestaurant) : base(idCell, nameCell, buyCell, sellCell, penalty)
        {
            levelHouse = 0;
            this.buyHouse_1 = buyHouse_1;
            this.buyHouse_2 = buyHouse_2;
            this.buyRestaurant = buyRestaurant;
            priceUpgrate = new int[] { buyHouse_1, buyHouse_2, buyRestaurant };
        }

        public override void Function(Player player)
        {
            double number = 1;
            BuyThisCell(player, number);
        }

        public override void UpgradeCell(Player player)
        {
            if (levelHouse < priceUpgrate.Length && player.Cash > priceUpgrate[levelHouse])
            {
                if (QuestionYN("Do you want to upgrade?(Y/N)"))
                {
                    player.UpgradeCell(priceUpgrate[levelHouse]);
                    levelHouse++;
                }
            }
        }
    }
}
