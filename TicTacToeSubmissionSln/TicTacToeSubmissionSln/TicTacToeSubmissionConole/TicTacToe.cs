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

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 2);
            _boardRenderer.Render();
        }


        public int getCoords(int x, int y)
        {
            var result = x * 3 + y;

            return result;

        }

        char[] spaces = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public void CheckXWin()
        {
            if (spaces[0] == 'X' && spaces[1] == 'X' && spaces[2] == 'X' ||
                spaces[3] == 'X' && spaces[4] == 'X' && spaces[5] == 'X' ||
                spaces[6] == 'X' && spaces[7] == 'X' && spaces[8] == 'X')
            {
                Console.WriteLine(" X has won,");
                Console.WriteLine("Game Over");
                return;
            }

            if (spaces[0] == 'X' && spaces[3] == 'X' && spaces[6] == 'X' ||
               spaces[1] == 'X' && spaces[4] == 'X' && spaces[7] == 'X' ||
               spaces[2] == 'X' && spaces[5] == 'X' && spaces[8] == 'X')
            {
                Console.WriteLine(" X has won");
                Console.WriteLine("Game Over");
                return;
            }

            if (spaces[0] == 'X' && spaces[4] == 'X' && spaces[8] == 'X' ||
               spaces[2] == 'X' && spaces[4] == 'X' && spaces[6] == 'X'
               )
            {
                Console.WriteLine(" X has won");
                Console.WriteLine("Game Over");
                return;
            }
        }

        public void CheckOWin()
        {
            if (spaces[0] == 'O' && spaces[1] == 'O' && spaces[2] == 'O' ||
                spaces[3] == 'O' && spaces[4] == 'O' && spaces[5] == 'O' ||
                spaces[6] == 'O' && spaces[7] == 'O' && spaces[8] == 'O')
            {
                Console.WriteLine(" O has won");
                Console.WriteLine("Game Over");
                return;
            }

            if (spaces[0] == 'O' && spaces[3] == 'O' && spaces[6] == 'O' ||
                spaces[1] == 'O' && spaces[4] == 'O' && spaces[7] == 'O' ||
                spaces[2] == 'O' && spaces[5] == 'O' && spaces[8] == 'O')
            {
                Console.WriteLine(" O has won");
                Console.WriteLine("Game Over");
                return;
            }

            if (spaces[0] == 'O' && spaces[4] == 'O' && spaces[8] == 'O' ||
                spaces[2] == 'O' && spaces[4] == 'O' && spaces[6] == 'O'
               )
            {
                Console.WriteLine(" O has won");
                Console.WriteLine("Thank you for playing");
                return;
            }
        }
        public void TicTacToeGame()
        {
            for (int index = 0; index < spaces.Length; index++)
            {
                if(index >= spaces.Length)
                {
                    Console.WriteLine("Donkey");
                }


                Console.SetCursorPosition(10, 12);
                Console.WriteLine("Enter row");
                var getUserInputX = Int32.Parse(Console.ReadLine()) - 1;


                Console.SetCursorPosition(10, 14);
                Console.WriteLine("Enter column");
                var getUserInputY = Int32.Parse(Console.ReadLine()) - 1;
                var getUserInput = getCoords(getUserInputX, getUserInputY);
                var playerCharacter = ' ';

                if (spaces[getUserInput] != ' ')
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
                        
                        _boardRenderer.AddMove(getUserInputX, getUserInputY, PlayerEnum.X, true);
                    }
                    else
                    {
                        _boardRenderer.AddMove(getUserInputX, getUserInputY, PlayerEnum.O, true);
                    }

                    spaces[getUserInput] = playerCharacter;

                    CheckXWin();
                    CheckOWin();
                }
             }     
        }
    }
}
