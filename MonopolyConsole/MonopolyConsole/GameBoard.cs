using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MonopolyConsole
{
    class GameBoard
    {
        private int totalCell;

        public GameBoard(int totalCell)
        {
            this.totalCell = totalCell;
        }

        public ArrayList initCell()
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < totalCell; i++)
            {
                Cell cell = new Cell(i);
                list.Add(cell);
            }
            return list;
        }

        public void addCard(Object card, int index, ArrayList listCell)
        {
           
        }


    }
}
