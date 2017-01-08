using System;

namespace TicTacToe
{
    class Player
    {
        private bool _iamCurrentlyPlaying;// the playing filed
        private readonly char _mySymbolOnBoard;  // set by the constructor; could be either ‘x’ or ‘o’
        private bool _iWon; // initialized to ‘false by constructor
                               
        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        public Player() // Constructor
        {
        }

        /// <summary>
        /// Makes a move. 
        /// It sets the player symbol on one of the empty cells of the board
        /// and return a flag either this current player won or not. 
        /// It calls findEmptyCellLocation to locate the move.
        /// </summary>
        public void MakeAMove()
        {

        }
        

        /// <summary>
        /// Finds the empty cell location that can make me win. 
        /// The selection is based on defined rules here.
        /// </summary>
        /// <param name="theBoard">The board.</param>
        /// <returns>Tuple&lt;System.Int32, System.Int32&gt;.</returns>
        public Tuple<int, int> FindBestEmptyCellLocation(Board theBoard) 
        {
        }

        /// <summary>
        /// Checks if the current player won.  returns true if player won the game and false o.w.
        /// </summary>
        /// <returns><c>true</c> if the player won, <c>false</c> otherwise.</returns>
        public bool CheckIfIWon(Board theBoard)  
        {
        }
    }
}