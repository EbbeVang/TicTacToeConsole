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
        static void Main(string[] args)
        {
            //TestBoard();
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
