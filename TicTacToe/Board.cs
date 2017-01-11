using System;

namespace TicTacToe
{
    /// <summary>
    ///     Class Board that represents the 3x3 playing board.
    /// </summary>
    public class Board
    {
        public readonly Tuple<char, char> BoardSymbols;
       
        private char[][] _board;

        public Board(Tuple<char, char> playersSymbols)
        {
            BoardSymbols = playersSymbols;
            _board = null;
        }

        public Board()
        {
            
        }
        /// <summary>
        ///     Checks if this board cell is empty.
        /// </summary>
        /// <param name="cellLocation">The cell location.</param>
        /// <returns><c>true</c> if cellLocation is empty(of default value), <c>false</c> otherwise.</returns>
        public bool CheckIfThisBoardCellIsEmpty(Tuple<int, int> cellLocation)
        {
            return true;
        }

        /// <summary>
        ///     Gets all empty cells in board.
        /// </summary>
        /// <returns>Tuple&lt;System.Byte, System.Byte&gt;[].</returns>
        public Tuple<byte, byte>[] GetAllEmptyCellsInBoard()
        {
            
            return null;
        }


        /// <summary>
        ///     Sets the this symbol at this board cell location. Returns false if the cell is not empty
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <param name="cellLocation">The cell location.</param>
        /// <returns><c>true</c> if insert success, <c>false</c> otherwise.</returns>
        public bool SetThisSymbolAtThisBoardCellLocation(char symbol, Tuple<int, int> cellLocation)
        {
            return true;
        }


        /// <summary>
        ///     Checks if any Player won.
        /// </summary>
        /// <returns>System.Char.</returns>
        public char CheckIfAnyPlayerWon()
        {
            return 'x';
        }

        /// <summary>
        /// Shows the board on screen.
        /// </summary>
        public void ShowBoard()
        {
        }
    }
}