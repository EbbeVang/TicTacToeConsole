using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsole
{
    class TicTacToeGame
    {
        private TicTacToeBoard _board = new TicTacToeBoard();
        private Player _player1 = new Player();
        private Player _player2 = new Player();

        private Random random = new Random();
        private Player _currentPlayer;

        public Player CurrentPlayer
        {
            get { return _currentPlayer; }
        }

        public void setup(String playername1, string playername2)
        {
            setPlayerNames(playername1, playername2);
            randomBegin();
        }

        public void switchPlayer()
        {
            if (CurrentPlayer.Equals(_player1))
            {
                _currentPlayer = _player2;
            }
            else
            {
                _currentPlayer = _player1;
            }
            
        }

        public Boolean playPiece(char c, int row, int col)
        {
            return _board.setPiece(c, row, col);
        }

        public char[,] getBoard()
        {
            return _board.Board;
        }

        private void randomBegin()
        {
            if (random.NextDouble() < 0.5)
            {
                _currentPlayer = _player1;
                _player1.Piece = _board.Pieces[0];
                _player2.Piece = _board.Pieces[1];
            }
            else
            {
                _currentPlayer = _player2;
                _player2.Piece = _board.Pieces[0];
                _player1.Piece = _board.Pieces[1];
            }

        }

        private void setPlayerNames(String playerName1, string playername2)
        {
            _player1.Name = playerName1;
            _player2.Name = playername2;
        }
    }
}

