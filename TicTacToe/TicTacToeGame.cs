using System;

namespace TicTacToe
{
    internal class TicTacToeGame
    {
        /// <summary>
        /// Start Tic Tac Toe Game
        /// </summary>
        public static void StartTheGame()
        {
            Board board = new Board(new Tuple<char, char>('x','o'));
            HumanPlayer p1 = new HumanPlayer();
            ComputerPlayer p2 = new ComputerPlayer();
            var noOneWon = true;
            while (noOneWon)
            {
                // play random
                noOneWon = p1.MakeRandomMove();
                if (noOneWon)
                    noOneWon = p2.MakeRandomMove();
                
                noOneWon = false;// just to end this loop
                //// OR play smart
                //noOneWon = p1.MakeSmartMove();
                //if (noOneWon)
                //    noOneWon = p2.MakeSmartMove();
            }
        }

        private static void Main(string[] args)
        {
            StartTheGame();
        }
       
    }
}