using System;

namespace TicTacToe
{
    /// <summary>
    /// Class Player.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Gets or sets my symbol on board.
        /// </summary>
        /// <value>My symbol on board.</value>
        public char MySymbolOnBoard { set; get; }

        private bool _iamCurrentlyPlaying; // the playing filed
        private bool _iWon; // initialized to ‘false by constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Player" /> class.
        /// </summary>
        /// <param name="symbol">The player symbol.</param>
        public Player(char symbol) // Constructor
        {
            MySymbolOnBoard = symbol;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        public Player()
        {
        }

        /// <summary>
        ///     Makes a smart move.
        ///     It sets the player symbol on one of the empty cells of the board
        ///     and return a flag either this current player won or not.
        ///     It calls findEmptyCellLocation to locate the move.
        /// </summary>
        /// <returns><c>true</c> if the CheckIfIWon returned true (the player won), <c>false</c> otherwise.</returns>
        public virtual bool MakeSmartMove()
        {
            return true;
        }

        /// <summary>
        ///     Makes a random move.
        ///     Pick a random empty location on the board
        /// </summary>
        /// <returns><c>true</c> if CheckIfIWon return true (the player won), <c>false</c> otherwise.</returns>
        public virtual bool MakeRandomMove()
        {
            return true;
        }

        /// <summary>
        ///     Picks the symbol.
        /// </summary>
        /// <returns>System.Char.</returns>
        public virtual char PickSymbol()
        {
            return 'x';
        }

        /// <summary>
        ///     Finds the empty cell location that can make me win.
        ///     The selection is based on defined rules here.
        /// </summary>
        /// <returns>Tuple&lt;System.Int32, System.Int32&gt;.</returns>
        private Tuple<byte, byte> FindBestEmptyCellLocation()
        {
            return new Tuple<byte, byte>(1, 1);
        }

        /// <summary>
        ///     Checks if the current player won.  returns true if player won the game and false o.w.
        /// </summary>
        /// <returns><c>true</c> if the player won, <c>false</c> otherwise.</returns>
        private bool CheckIfIWon()
        {
            return true;
        }
    }
}