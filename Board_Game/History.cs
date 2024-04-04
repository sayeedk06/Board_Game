using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Game
{
    internal class History
    {
        public List<int> player1MoveList  = new List<int>();
        public List<int> player2MoveList  = new List<int>();

        public void loadPlayer1(int move)
        {
            if (move != 0)
            {
                player1MoveList.Add(move);
            }else
            {
                Console.WriteLine("The end");
            }
            
        }
        public void loadPlayer2(int move)
        {
            if (move != 0)
            {
                player2MoveList.Add(move);
            }
            else
            {
                Console.WriteLine("The end");
            }

        }




    }
}
