namespace TicTacToe
{
    /// <summary>
    ///     Class ComputerPlayer.
    /// </summary>
    /// <seealso cref="TicTacToe.Player" />
    public class ComputerPlayer : Player
    {
        /// <summary>
        ///     Makes a random move.
        ///     Pick a random empty location on the board
        /// </summary>
        /// <returns><c>true</c> if CheckIfIWon return true (the player won), <c>false</c> otherwise.</returns>
        public override bool MakeRandomMove()
        {
            return false;
        }

        /// <summary>
        ///     Makes a smart move.
        ///     It sets the player symbol on one of the empty cells of the board
        ///     and return a flag either this current player won or not.
        ///     It calls findEmptyCellLocation to locate the move.
        /// </summary>
        /// <returns><c>true</c> if the CheckIfIWon returned true (the player won), <c>false</c> otherwise.</returns>
        public override bool MakeSmartMove()
        {
            return true;
        }

        /// <summary>
        ///     Picks the symbol.
        /// </summary>
        /// <returns>System.Char.</returns>
        public override char PickSymbol()
        {
            return 'o';
        }
    }
}