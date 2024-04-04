using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Game
{
    internal class HumanPlayer : Player
    {
        
        public override void undoMove()
        {
            throw new NotImplementedException();    
        }
        public override void redoMove()
        {
            throw new NotImplementedException();
        }
        public int inputMove()
        {
            Console.WriteLine("Enter your move");
            int move = Convert.ToInt32(Console.ReadLine());
            return move;
        }
        public void makeMove(History his, int move, string playtype)
        {
            if (playtype == "player1")
            {
                his.loadPlayer1(move);
            }
            else if (playtype == "player2")
            {
                his.loadPlayer2(move);
            }

        }
    }
}
