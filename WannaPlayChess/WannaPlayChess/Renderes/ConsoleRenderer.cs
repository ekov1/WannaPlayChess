﻿using System;
using System.Threading;
using WannaPlayChess.Board;
using WannaPlayChess.Common.Console;
using WannaPlayChess.Renderes.Contracts;

namespace WannaPlayChess.Renderes
{
    public class ConsoleRenderer : IRenderer
    {
        private const string Logo = "WannaPlayChess";
        private const int CharactersPerBoardSquare = 9;
        private const ConsoleColor black = ConsoleColor.DarkGray;
        private const ConsoleColor white = ConsoleColor.Gray;

        public void RenderMainMenu()
        {
            ConosoleHelpers.SetCursorAtCenter(Logo.Length);
            Console.WriteLine(Logo);

            Thread.Sleep(1500);
            // main menu
        }

        public void RenderBoard(IBoard board)
        {
            Console.Clear();
            var startRowPrintInt = Console.WindowHeight / 2 - (board.TotalRows / 2) * CharactersPerBoardSquare;
            var startColPrintInt = Console.WindowWidth / 2 - (board.TotalCols / 2) * CharactersPerBoardSquare;

            var currentRowPrint = startRowPrintInt;
            var currentColPrint = startColPrintInt;

            int counter = 0;
            for (int top = 0; top < board.TotalRows; top++)
            {
                for (int left = 0; left < board.TotalCols; left++)
                {
                    currentColPrint = startColPrintInt + top * CharactersPerBoardSquare;
                    currentRowPrint = startRowPrintInt + left * CharactersPerBoardSquare;

                    if (counter % 2 == 0)
                    {
                        Console.BackgroundColor = black;
                    }
                    else
                    {
                        Console.BackgroundColor = white;
                    }

                    for (int i = 0; i < CharactersPerBoardSquare; i++)
                    {

                        for (int j = 0; j < CharactersPerBoardSquare; j++)
                        {
                            Console.SetCursorPosition(currentColPrint + j, currentRowPrint + i);
                            Console.WriteLine(" ");
                        }
                    }
                    counter++;
                }
                counter++;
            }

            Console.ReadLine();
        }
    }
}
