using System;

namespace TicTacToe
{
    /// <summary>
    /// Class Board that represents the 3x3 playing board.
    /// </summary>
    public class Board   
    { 
        private char[][] _board;  

        /// <summary>
        /// Initializes a new instance of the <see cref="Board" /> class.
        /// </summary>
        public Board()
        {
            
        }

        /// <summary>
        /// Checks if this board cell is empty.
        /// </summary>
        /// <param name="cellLocation">The cell location.</param>
        /// <returns><c>true</c> if cellLocation is empty(of default value), <c>false</c> otherwise.</returns>
        public bool CheckIfThisBoardCellIsEmpty(Tuple<int, int> cellLocation)
        {
            return true;
        }// return true if (x,y) is empty and false if not

        public Tuple<byte, byte>[] GetAllEmptyCellsInBoard()
        {
             Tuple<byte, byte>[] locations = new Tuple<byte, byte>[1];
            locations[0]=new Tuple<byte,byte>(1,1);
            return locations;
        }

        /// <summary>
        /// Sets the this symbol at this board cell location. Returns false if the cell is not empty
        /// </summary>
        /// <param name="cellLocation">The cell location.</param>
        /// <param name="symbol">The symbol.</param>
        /// <returns><c>true</c> if cellLocation is empty, <c>false</c> otherwise.</returns>
        public bool SetThisSymbolAtThisBoardCellLocation(char symbol,Tuple<int, int> cellLocation,)
        {
            return true;
        }

        /// <summary>
        /// Checks if any Player won.
        /// </summary>
        /// <returns>System.Char.</returns>
        public char CheckIfAnyPlayerWon()
        { 
            return'x';
        }
    }
}