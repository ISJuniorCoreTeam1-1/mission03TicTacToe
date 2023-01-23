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
    public void PrintBoard(int[] board)
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
        //loop through the array and print it
        //for (int i =0; i < 9; i++)
        //{
        //    Console.WriteLine('   |   |   ');
        //    Console.WriteLine(' 1 | 2 | 3 ');
        //    Console.WriteLine('___________');
        //    Console.WriteLine('   |   |   ');
        //    Console.WriteLine(' 4 | 5 | 6 ');
        //    Console.WriteLine('___________');
        //    Console.WriteLine('   |   |   ');
        //    Console.WriteLine(' 7 | 8 | 9 ');

        //}
    }
    }
}
