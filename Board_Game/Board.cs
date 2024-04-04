using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_Game
{
    internal class Board
    {
        private int dimension;
        public int Dimension { get { return dimension; } set { dimension = value; } }
        public Board(int dimension) { 
            this.Dimension = dimension; 
        }
        
        public void displayBoard()
        {

            for (int i = 0; i < Dimension; i++)
            {
                Console.Write("*---*");
                /*Console.Write("\n|   |");*/
            }
            Console.WriteLine();
            for (int i = 0; i< Dimension; i++)
            {
                Console.Write("|   |");
            }
            Console.WriteLine();    
            for (int i = 0; i < Dimension; i++)
            {
                Console.Write("*---*");
            }

        }
        public void updateBoard(List<int> moveList)
        {
            for (int i = 0; i < Dimension; i++)
            {
                Console.Write("*---*");
                /*Console.Write("\n|   |");*/
            }
            Console.WriteLine();
            for (int i = 0; i < Dimension; i++)
            {
                int j = i + 1;
                if(moveList.Contains(j))
                {
                    Console.Write("| X |");
                }
                else
                {
                    Console.Write("|   |");
                }
                
            }
            Console.WriteLine();
            for (int i = 0; i < Dimension; i++)
            {
                Console.Write("*---*");
            }
        }
    }
}
