﻿using System;

namespace TicTacToe
{
    class Player
    {
        private readonly char _mySymbolOnBoard;  // set by the constructor; could be either ‘x’ or ‘o’
        private bool _iamCurrentlyPlaying;// the playing filed
        private bool _iWon; // initialized to ‘false by constructor
        private Board theBoard;
        /// <summary>
        /// Initializes a new instance of the <see cref="Player" /> class.
        /// </summary>
        /// <param name="symbol">The player symbol.</param>
        /// <param name="board">The board instance.</param>
        public Player(char symbol,Board board) // Constructor
        {
            _mySymbolOnBoard = symbol;
            theBoard = board;
        }


        /// <summary>
        /// Makes a smart move. 
        /// It sets the player symbol on one of the empty cells of the board
        /// and return a flag either this current player won or not. 
        /// It calls findEmptyCellLocation to locate the move.
        /// </summary>
        /// <returns><c>true</c> if the CheckIfIWon returned true (the player won), <c>false</c> otherwise.</returns>
        public bool MakeSmartMove()
        {

        }

        /// <summary>
        /// Makes a random move. 
        /// Pick a random empty location on the board
        /// </summary>
        /// <returns><c>true</c> if CheckIfIWon return true (the player won), <c>false</c> otherwise.</returns>
        public bool MakeRandomMove()
        {
        }

        /// <summary>
        /// Finds the empty cell location that can make me win.
        /// The selection is based on defined rules here.
        /// </summary>
        /// <returns>Tuple&lt;System.Int32, System.Int32&gt;.</returns>
        private Tuple<byte, byte> FindBestEmptyCellLocation() 
        {
        }

        /// <summary>
        /// Checks if the current player won.  returns true if player won the game and false o.w.
        /// </summary>
        /// <returns><c>true</c> if the player won, <c>false</c> otherwise.</returns>
        private bool CheckIfIWon()  
        {
        }
    }
}