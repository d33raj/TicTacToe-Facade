using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFacade.Models
{
    internal class Player
    {
        public Symbol type {  get; set; }

        public Player(Symbol symbol)
        {
            type = symbol; 
        }

        public void PlayGame(Board board)
        {
            bool validMove=false;
            while (!validMove)
            {
                try
                {
                    Console.WriteLine($"Player {type}, choose a cell (0-8): ");
                    int cellIndex = int.Parse(Console.ReadLine());
                    board.SetSymbol(cellIndex, type);

                    validMove = true; 
                }
                catch (CellNotEmptyException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


    }
}
