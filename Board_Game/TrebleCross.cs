using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Game
{
    internal class TrebleCross : Game
    {
        public void initiateGame() 
        {
            Console.WriteLine("Game starts");
        }
        public int MoveX { get; set; }
        public int GameID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string GameName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Rules { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void choosePlayerTyoe() { }
        public void assignTurns() { }
        public void checkWinner(List<int> moveList, int currentMove) {
            moveList.Sort();
            int idv = moveList.IndexOf(currentMove);
    /*        Console.WriteLine("idv = " + idv);*/
            if (moveList.Count >= 3)
            {
                int comp = idv - 2;

                Console.WriteLine("idv = " + idv + "comp = " + comp);
                
                if (moveList[idv] - moveList[comp] == 2)
                {
                    Console.WriteLine("The person is a Winner");
                }
                else
                {
                    Console.WriteLine("Not yet fam");
                }
            }
            


        }
        public void restartWinner() { }
        public void endGame() { }

        public void tcMoveValidation() {
        
        
        
        }
    }
}
