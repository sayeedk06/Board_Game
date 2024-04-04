using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Game
{
    internal abstract class Player
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public bool CurrentPlayer { get; set; }


        public void makeMove(int move) 
        {
           
        }
        public abstract void undoMove();
        public abstract void redoMove();

    }
}
