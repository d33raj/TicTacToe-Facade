using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFacade.Models
{
    internal class Cell
    {
       public Symbol symbol;

        public Cell()
        {
            symbol = Symbol.EMPTY;
        }

        public bool IsEmpty()
        {
            if(symbol == Symbol.EMPTY) 
                return true;
            return false;
        }

    }
}
