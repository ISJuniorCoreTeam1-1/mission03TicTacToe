using System;

namespace mission03TicTacToe
{
 
    class Driver
    {
        static void Main(string[] args)
        {

            //Create a new Game
            Supporting myGame = new Supporting();

            //This is the array for the board to store answers, Spots 1-9 correlate with nine spots on board
            char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //Welcome user to the game
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("\n");

            //Print out initial board and prompt for first turn by player 1
            string selectedValue = "";
            string str = "";
            myGame.PrintBoard(board);
            Console.WriteLine("Player 1: It's your turn. Enter the number on the board to place your X");
            //Read In User Entry and update the array
            str = Console.ReadLine();
            selectedValue = str;
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i].ToString() == str)
                {
                    board[i] = 'X';
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (myGame.Winner(board) == 0)
                {
                    myGame.PrintBoard(board);
                    Console.WriteLine("Player 2: It's your turn. Enter the number on the board to place your X");
                    //Read In User Entry and update the array
                    str = Console.ReadLine();
                    selectedValue = str;
                    for (int j = 0; j < board.Length; j++)
                    {
                        if (board[j].ToString() == str)
                        {
                            board[j] = 'O';
                        }
                    }
                    if (myGame.Winner(board) == 0)
                    {

                        myGame.PrintBoard(board);
                        Console.WriteLine("Player 1: It's your turn. Enter the number on the board to place your X");
                        //Read In User Entry and update the array
                        str = Console.ReadLine();
                        selectedValue = str;
                        for (int k = 0; k < board.Length; k++)
                        {
                            if (board[k].ToString() == str)
                            {
                                board[k] = 'X';
                            }
                        }
                    }
            
                }
            }
            myGame.PrintBoard(board);
            
            if (myGame.Winner(board) == 0)
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                Console.WriteLine("Player " + myGame.Winner(board) + " won the game!");
            }
        }
    }
}
