using System;

namespace mission03TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello firends!");
             //This is the array for the board to store answers, Spots 1-9 correlate with nine spots on board
            char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int player = 1;
           
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("\n");
           
            if (player == 1) //Deciding whose turn it is
            {
                Console.WriteLine("Player 1: It's your turn");
            }
            else
            {
                Console.WriteLine("Player 2: It's your turn");
            }
           

                Console.WriteLine("\n");
               
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
    }
}
