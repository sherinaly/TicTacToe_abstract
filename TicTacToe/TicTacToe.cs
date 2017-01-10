namespace TicTacToe
{
    class TicTacToe
    {
        public static void StartTheGame()
        {
            Board board = new Board();
            HumanPlayer p1 = new HumanPlayer();
            ComputerPlayer p2 = new ComputerPlayer();
            bool noOneWon = true;
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

        static void Main(string[] args)
        {

            TicTacToe.StartTheGame();
        }
       }
}
