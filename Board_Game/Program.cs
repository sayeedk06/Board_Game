using System;

namespace Board_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Board b1 = new Board(6);
            HumanPlayer player1 = new HumanPlayer();
            HumanPlayer player2 = new HumanPlayer();
            TrebleCross tb1 = new TrebleCross();
            History his = new History();


            tb1.initiateGame();
            b1.displayBoard();
            int move = 10;
            while (move != 0)
            {
                Console.WriteLine();
                player1.CurrentPlayer = true;
                move = player1.inputMove();
                if (player1.CurrentPlayer)
                {
                    player1.makeMove(his, move,"player1");
                    b1.updateBoard(his.player1MoveList);
                    tb1.checkWinner(his.player1MoveList, move);
                    player1.CurrentPlayer = false;
                    
                }

                foreach(var item  in his.player1MoveList)
                {

                }
                Console.WriteLine();

                player2.CurrentPlayer = true;
                move = player2 .inputMove();
                if (player2.CurrentPlayer)
                {
                    player2.makeMove(his, move, "player2");
                    b1.updateBoard(his.player2MoveList);
                    tb1.checkWinner(his.player2MoveList, move);
                    player2.CurrentPlayer = false;
                }

                
                

               /* his.load(move);*/

              /*  move = player1.makeMove(his);
                b1.updateBoard(his.player1MoveList);
                tb1.checkWinner(his.player1MoveList, move);*/

              /*  move = player2.makeMove(his);
                b1.updateBoard(his.player2MoveList);
                tb1.checkWinner(his.player2MoveList, move);*/


            }
            



        }
    }
}