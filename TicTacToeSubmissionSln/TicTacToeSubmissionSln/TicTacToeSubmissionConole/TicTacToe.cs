using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;
        private char[] pos = new char[8];
        private char[] player = new char[] { 'X', 'O'};

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(16, 6);
            _boardRenderer.Render();
        }

        public void Run()
        {
           

            int turn = 0;
            while (turn <= 3)
            {
                //Player 1
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(2, 19);

                Console.Write("Player 1: ");

                Console.SetCursorPosition(2, 20);

                Console.Write("Please Enter Row: ");
                var row = Console.ReadLine();

                Console.SetCursorPosition(2, 21);


                Console.Write("Please Enter Column: ");
                var column = Console.ReadLine();


                // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

                //PLAYER 2
                
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.SetCursorPosition(30, 19);

                    Console.Write("Player 2: ");

                    Console.SetCursorPosition(30, 20);

                    Console.Write("Please Enter Row: ");
                    var row1 = Console.ReadLine();

                    Console.SetCursorPosition(30, 21);


                    Console.Write("Please Enter Column: ");
                    var column1 = Console.ReadLine();
                    // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
                    _boardRenderer.AddMove(int.Parse(row1), int.Parse(column1), PlayerEnum.O, true);
                
                turn++;
            }
            
        }
    }
}
