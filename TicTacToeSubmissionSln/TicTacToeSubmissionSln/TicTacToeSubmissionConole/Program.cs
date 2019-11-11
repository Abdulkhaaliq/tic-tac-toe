using System;

namespace TicTacToeSubmissionConole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor pink = Console.ForegroundColor;

            Console.SetCursorPosition(14,2);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Welcome to Tic Tac Toe");

            var ticTacToe = new TicTacToe();

            ticTacToe.Run();         
        }
    }
}
