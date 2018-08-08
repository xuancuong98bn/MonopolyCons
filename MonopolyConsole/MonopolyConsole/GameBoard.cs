using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MonopolyConsole
{
    class GameBoard
    {
        private int totalCell;
        ArrayList listCell;
        public int TotalCell { get => totalCell; set => totalCell = value; }

        public GameBoard(int totalCell, ArrayList listCell)
        {
            this.TotalCell = totalCell;
            this.listCell = listCell;
            InitCell();
        }

        private void InitCell()
        {            
            for (int i = 0; i < TotalCell; i++)
            {
                Cell cell = new Cell(i);
                listCell.Add(cell);
            }
            SetupCard();
        }

        public void AddCard(Object card, int index)
        {
            listCell[index] = card;
        }

        public void SetupCard()
        {
            AddCard(new StartCell(), 0);
        }
    }
}
