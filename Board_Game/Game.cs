using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Game
{
    internal interface Game
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public string Rules { get; set; }

        public void initiateGame() { }
        public void choosePlayerTyoe() { }
        public void assignTurns() { }   
        public void checkWinner() { }
        public void restartWinner() { }
        public void endGame() { }
    }
}
