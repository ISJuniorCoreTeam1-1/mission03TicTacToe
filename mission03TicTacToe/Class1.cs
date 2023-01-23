using System;
using System.Collections.Generic;
using System.Text;

namespace mission03TicTacToe
{
    public class Supporting
    {

        //Constructor
        public Supporting()
        {
             string placeholder = "hello";
        }



        // This is where we print the board
        public void PrintBoard(char[] board)
        {


            //Tic-Tac-Toe board. Players will type in which spot they want their X or O in (1-9)
            //It will store it in board array and change what spot they chose to either X or O
            Console.WriteLine("    |    |    ");
            Console.WriteLine("{0}   | {1}  | {2} ", board[1], board[2], board[3]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            Console.WriteLine("{0}   | {1}  | {2} ", board[4], board[5], board[6]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            Console.WriteLine("{0}   | {1}  | {2} ", board[7], board[8], board[9]);
            Console.WriteLine("    |    |    ");
        }







        //This is the class that allows us to check for a winner
        public int Winner(char[] board)
        {

            //Default noone has won yet.
            int whoWon = 0;

            //Is there a horizontal win?

            if (board[1] == board[2] & board[1] == board[3])
            {
                //someone won!

                if(board[1] == 'X')
                {
                    //Player one X's won
                    whoWon = 1;
                }
            }

            //Is there a vertical win?

            
            //Is there a diagonal win?

            


            return whoWon;

        }
    }
}
