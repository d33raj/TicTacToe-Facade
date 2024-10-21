using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFacade.Models
{
    internal class Result
    {
        public bool CheckRows(Board board)
        {
            for(int row = 0;row<3;row++)
            {
                int rowIndex = row * 3;
                if( (board.cells[rowIndex].symbol== board.cells[rowIndex+1].symbol) 
                   && (board.cells[rowIndex+1].symbol == board.cells[rowIndex + 2].symbol) 
                   && !board.cells[rowIndex].IsEmpty())
                {  return true;  }
            }
            return false;
        }

        public bool CheckColumns(Board board)
        {
            for (int column = 0; column < 3; column++)
            {
                if ((board.cells[column].symbol == board.cells[column+3].symbol)
                   && (board.cells[column+3].symbol == board.cells[column+6].symbol)
                   && !board.cells[column].IsEmpty())
                { return true; }
            }
            return false;
        }

        public bool CheckDiagonal(Board board)
        {
            if ((board.cells[0].symbol == board.cells[4].symbol)
                  && (board.cells[4].symbol == board.cells[8].symbol)
                  && !board.cells[0].IsEmpty())
            { return true; }

            if ((board.cells[2].symbol == board.cells[4].symbol)
                 && (board.cells[4].symbol == board.cells[6].symbol)
                 && !board.cells[2].IsEmpty())
            { return true; }

            return false;
        }
    }
}
