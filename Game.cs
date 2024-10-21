using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeFacade.Models;

namespace TicTacToeFacade
{
    internal class Game
    {
        public Player Player1;
        public Player Player2; 
        public Player CurrentPlayer;
        public Result Result;
        public Board Board;

        public Game()
        {
            Player1 = new Player(Symbol.X);
            Player2=new Player(Symbol.O);
            Board = new Board();
            Result= new Result();
            CurrentPlayer = Player1;
        }

        public void Start()
        {
            bool gameWon = false;

            while (!gameWon && !Board.IsBoardFull())
            {
                Board.DisplayBoard();
                CurrentPlayer.PlayGame(Board);

                gameWon=Result.CheckRows(Board) || Result.CheckColumns(Board) || Result.CheckDiagonal(Board);

                if (gameWon)
                {
                    Board.DisplayBoard();
                    Console.WriteLine($"\n===============================\nPlayer {CurrentPlayer.type} wins!");
                    break;
                }

                CurrentPlayer = (CurrentPlayer == Player1) ? Player2 : Player1;
            }

            if (!gameWon)
            {
                Console.WriteLine("\n===============================\nIt's a draw!");
            }

            Board.DisplayBoard();
        
        }
    }
}
