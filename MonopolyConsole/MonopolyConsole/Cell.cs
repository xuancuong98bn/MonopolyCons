using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyConsole
{
    class Cell
    {
        protected int idCell;

        public Cell()
        {

        }

        public Cell(int idCell)
        {
            this.idCell = idCell;
        }

        public int IdCell { get => idCell; set => idCell = value; }

        public virtual void Function() {
            //Override in subclass
        }
    }
}
