namespace TicTacToe
{
    internal class TicTacToe
    {
        public static void StartTheGame()
        {
            var board = new Board();
            var p1 = new HumanPlayer();
            var p2 = new ComputerPlayer();
            var noOneWon = true;
            while (noOneWon)
            {
                // play random
                noOneWon = p1.MakeRandomMove();
                if (noOneWon)
                    noOneWon = p2.MakeRandomMove();

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