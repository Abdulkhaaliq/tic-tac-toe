using System;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 2);
            _boardRenderer.Render();
        }


        public int coordinates(int x, int y)
        {
            var result = x * 3 + y;

            return result;

        }

        char[] pos = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public void CheckWin()
        {
            if (pos[0] == 'X' && pos[1] == 'X' && pos[2] == 'X' ||
                pos[3] == 'X' && pos[4] == 'X' && pos[5] == 'X' ||
                pos[6] == 'X' && pos[7] == 'X' && pos[8] == 'X')
            {
                Console.SetCursorPosition(10, 16);
                Console.WriteLine(" X has won");

                Console.SetCursorPosition(10, 18);
                Console.WriteLine("Game Over");
                return;
            }

            if (pos[0] == 'X' && pos[3] == 'X' && pos[6] == 'X' ||
               pos[1] == 'X' && pos[4] == 'X' && pos[7] == 'X' ||
               pos[2] == 'X' && pos[5] == 'X' && pos[8] == 'X')
            {
                Console.SetCursorPosition(10, 16);
                Console.WriteLine(" X has won");

                Console.SetCursorPosition(10, 18);
                Console.WriteLine("Game Over");
                return;
            }

            if (pos[0] == 'X' && pos[4] == 'X' && pos[8] == 'X' ||
               pos[2] == 'X' && pos[4] == 'X' && pos[6] == 'X'
               )
            {
                Console.SetCursorPosition(10, 16);
                Console.WriteLine(" X has won");

                Console.SetCursorPosition(10, 18);
                Console.WriteLine("Game Over");
                return;
            }
  
            if (pos[0] == 'O' && pos[1] == 'O' && pos[2] == 'O' ||
                pos[3] == 'O' && pos[4] == 'O' && pos[5] == 'O' ||
                pos[6] == 'O' && pos[7] == 'O' && pos[8] == 'O')
            {
                Console.SetCursorPosition(10, 16);
                Console.WriteLine(" O has won");

                Console.SetCursorPosition(10, 18);
                Console.WriteLine("Game Over");
                return;
            }

            if (pos[0] == 'O' && pos[3] == 'O' && pos[6] == 'O' ||
                pos[1] == 'O' && pos[4] == 'O' && pos[7] == 'O' ||
                pos[2] == 'O' && pos[5] == 'O' && pos[8] == 'O')
            {
                Console.SetCursorPosition(10, 16);
                Console.WriteLine(" O has won");

                Console.SetCursorPosition(10, 18);
                Console.WriteLine("Game Over");
                return;
            }

            if (pos[0] == 'O' && pos[4] == 'O' && pos[8] == 'O' ||
                pos[2] == 'O' && pos[4] == 'O' && pos[6] == 'O'
               )
            {
                Console.SetCursorPosition(10, 16);
                Console.WriteLine(" O has won");

                Console.SetCursorPosition(10, 18);
                Console.WriteLine("Game Over");
                return;
            }
        }
        public void Run()
        {
            for (int index = 0; index < pos.Length; index++)
            {
                if(index >= pos.Length)
                {
                    Console.SetCursorPosition(10, 16);

                    Console.WriteLine("Donkey");
                }


                Console.SetCursorPosition(10, 12);
                Console.WriteLine("Enter row");
                var inputX = Int32.Parse(Console.ReadLine()) - 1;


                Console.SetCursorPosition(10, 14);
                Console.WriteLine("Enter column");
                var inputY = Int32.Parse(Console.ReadLine()) - 1;
                var input = coordinates(inputX, inputY);
                var playerCharacter = ' ';

                if (pos[input] != ' ')
                {
                    Console.WriteLine("Invalid Character");
                }
                else
                {
                    if (index % 2 == 0)
                    {
                        playerCharacter = 'X';
                    }
                    else
                    {
                        playerCharacter = 'O';
                    }

                    if (playerCharacter == 'X')
                    {
                        
                        _boardRenderer.AddMove(inputX, inputY, PlayerEnum.X, true);
                    }
                    else
                    {
                        _boardRenderer.AddMove(inputX, inputY, PlayerEnum.O, true);
                    }

                    pos[input] = playerCharacter;

                    CheckWin();                  
                }
             }     
        }
    }
}
