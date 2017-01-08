using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TicTacToe
{
    class Program
    {
           static void Main(string[] args)
           {
               Board board=new Board();
               Player p1=new Player('x',board);
               Player p2=new Player('o',board);
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
       }
}
