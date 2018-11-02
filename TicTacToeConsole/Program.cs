using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsole
{
    class Program
    {
        static TicTacToeGame g;
        static void Main(string[] args)
        {
            //play game
            
            g = new TicTacToeGame();
            Console.WriteLine("Welcome to TicaTacToe \nplease entr your names");
            g.setup(Console.ReadLine(), Console.ReadLine());

            while (true)
            {
                showBoard();
                Console.WriteLine("play for helvede" + g.CurrentPlayer.Name);
                Console.Write("row:");
                int row = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                Console.Write("col:");
                int col = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                if (g.playPiece(g.CurrentPlayer.Piece, row, col))
                {
                    g.switchPlayer();

                }
                Console.Clear();
            }

            //TestBoard();
        }

        public static void showBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(g.getBoard()[i,j]);
                    Console.Write("|");
                }

                Console.WriteLine();
            }
        }

        private static void TestBoard()
        {
            TicTacToeBoard b = new TicTacToeBoard();
            b.setPiece('x', 0, 0);
            b.setPiece('o', 2, 2);
            b.setPiece('x', 0, 1);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(b.Board[i, j]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
