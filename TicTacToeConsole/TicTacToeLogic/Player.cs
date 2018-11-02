using System;

namespace TicTacToeConsole
{
    public class Player
    {
        private String name;
        private int gameWon;

        public Player(string name)
        {
            this.Name = name;
        }
        public Player()
        { }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int GameWon
        {
            get { return gameWon; }
            set { gameWon = value; }
        }

        
    }
}