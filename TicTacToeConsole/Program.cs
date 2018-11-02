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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(showAsciiArt());
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to TicTacToe \nplease enter your names");
            g.setup(Console.ReadLine(), Console.ReadLine());
            Console.Clear();
            while (true)
            {
                Console.WriteLine(showAsciiArt());
                showBoard();
                Console.WriteLine("play " + g.CurrentPlayer.Name + "!");
                Console.Write("row:");
                int row = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                Console.WriteLine();
                Console.Write("col:");
                int col = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                Console.WriteLine();
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
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("+---+---+---+");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|");
                for (int j = 0; j < 3; j++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" ");
                    Console.Write(g.getBoard()[i,j]);
                    Console.Write(" ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("|");
                }

                Console.WriteLine();
                Console.WriteLine("+---+---+---+");
            }
        }

        private static string showAsciiArt()
        {
            return "▄▄▄█████▓ ██▓ ▄████▄  ▄▄▄█████▓ ▄▄▄       ▄████▄  ▄▄▄█████▓ ▒█████  ▓█████\r\n▓  ██▒ ▓▒▓██▒▒██▀ ▀█  ▓  ██▒ ▓▒▒████▄    ▒██▀ ▀█  ▓  ██▒ ▓▒▒██▒  ██▒▓█   ▀\r\n▒ ▓██░ ▒░▒██▒▒▓█    ▄ ▒ ▓██░ ▒░▒██  ▀█▄  ▒▓█    ▄ ▒ ▓██░ ▒░▒██░  ██▒▒███\r\n░ ▓██▓ ░ ░██░▒▓▓▄ ▄██▒░ ▓██▓ ░ ░██▄▄▄▄██ ▒▓▓▄ ▄██▒░ ▓██▓ ░ ▒██   ██░▒▓█  ▄\r\n ▒██▒ ░ ░██░▒ ▓███▀ ░  ▒██▒ ░  ▓█   ▓██▒▒ ▓███▀ ░  ▒██▒ ░ ░ ████▓▒░░▒████▒\r\n ▒ ░░   ░▓  ░ ░▒ ▒  ░  ▒ ░░    ▒▒   ▓▒█░░ ░▒ ▒  ░  ▒ ░░   ░ ▒░▒░▒░ ░░ ▒░ ░\r\n   ░     ▒ ░  ░  ▒       ░      ▒   ▒▒ ░  ░  ▒       ░      ░ ▒ ▒░  ░ ░  ░\r\n ░       ▒ ░░          ░        ░   ▒   ░          ░      ░ ░ ░ ▒     ░\r\n         ░  ░ ░                     ░  ░░ ░                   ░ ░     ░  ░\r\n            ░                           ░";
        }
        private static void TestBoard()
        {
            TicTacToeBoard b = new TicTacToeBoard();
            b.setPiece('x', 0, 0);
            b.setPiece('o', 2, 2);
            b.setPiece('x', 0, 1);

            for (int i = 0; i < 3; i++)
            {
                Console.Write("|");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(b.Board[i, j]);
                    Console.Write("|");
                }

            }
        }
    }
}
