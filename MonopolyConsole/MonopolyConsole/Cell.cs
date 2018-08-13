using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyConsole
{
    class Cell
    {
        protected int idCell;
        private String nameCell;
        protected Player owner;
        protected int buyCell;
        protected int sellCell;
        protected int valueCell;
        protected int penalty;
        protected Number number = new Number();

        public Cell()
        {

        }

        public Cell(int idCell)
        {
            this.idCell = idCell;            
        }

        public Cell(int idCell, String nameCell)
        {
            this.idCell = idCell;
            this.nameCell = nameCell;
        }
        public Cell(int idCell, String nameCell, int buyCell, int sellCell, int penalty)
        {
            this.idCell = idCell;
            this.nameCell = nameCell;
            this.buyCell = buyCell;
            this.sellCell = sellCell;
            valueCell = sellCell;
            this.penalty = penalty;
        }

        public int IdCell { get => idCell; set => idCell = value; }
        public int BuyCell { get => buyCell; set => buyCell = value; }
        public int SellCell { get => sellCell; set => sellCell = value; }
        public int ValueCell { get => valueCell; set => valueCell = value; }
        public Player Owner { get => owner; set => owner = value; }
        public int Penalty { get => penalty; set => penalty = value; }
        protected string NameCell { get => nameCell; set => nameCell = value; }

        public virtual void Function(Player player) {
            //Override in subclass
        }

        public virtual void DoFunctionIfWalkThrough(Player player)
        {
            //Override in subclass
        }
        public virtual void IncValue(int value)
        {
            //use to modify value of this cell
        }

        public virtual void UpgradeCell(Player player)
        {
            //use with each child
        }
        public bool BuyThisCell(Player player, double factor)
        {
            if (BuyOrNot(player, factor))
            {
                player.BuyCell(this);
                return true;
            }
            return false;
        }

        public bool BuyOrNot(Player player, double factor)
        {
            if (!owner.Equals(""))
            {
                if (owner.Equals(player))
                {
                    UpgradeCell(player);
                }
                else
                {
                    Fine(player, factor);
                }
                return false;
            }
            if (player.Cash < buyCell)
            {
                Console.WriteLine("Not enough cash");
                return false;
            }
            return QuestionYN("Do you want to buy this cell ? (Y/N)");
        }

        public void Fine(Player player, double factor)
        {
            player.FineTo(owner, (int)(penalty*factor));
        }

        public bool QuestionYN(String s)
        {
            do
            {
                Console.WriteLine(s);
                if (Console.ReadLine().Equals("Y"))
                    return true;
                if (Console.ReadLine().Equals("N"))
                    return false;
                Console.WriteLine("Invalid character");
            } while (true);
        }
    }
}
