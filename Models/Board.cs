using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFacade.Models
{
    internal class Board
    {
        public Cell[] cells=new Cell[9];

        public Board()
        {
            for (int i = 0; i < 9; i++)
            {
                cells[i] = new Cell();
            }
        }

        public bool IsBoardFull()
        {
            foreach (var cell in cells)
            {
                if (cell.IsEmpty())
                    return false;
            }
            return true;
        }

        public void DisplayBoard()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                string cellSymbol = cells[i].IsEmpty() ? "." : cells[i].symbol.ToString();
                Console.Write(cellSymbol + "\t");
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        public void SetSymbol(int cellIndex,Symbol symbol)
        {
            if (cells[cellIndex].IsEmpty())
            {
                cells[cellIndex].symbol = symbol;
            }
            else
            {
                throw new CellNotEmptyException("Cell is already occupied.");
            }
        }


    }
}
