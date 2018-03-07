using System;
using System.Threading;
using WannaPlayChess.Board;
using WannaPlayChess.Common;
using WannaPlayChess.Common.Console;
using WannaPlayChess.Renderes.Contracts;

namespace WannaPlayChess.Renderes
{
    public class ConsoleRenderer : IRenderer
    {
        private const string Logo = "WannaPlayChess";

        private const ConsoleColor black = ConsoleColor.DarkGray;
        private const ConsoleColor white = ConsoleColor.Gray;

        public void RenderMainMenu()
        {
           if(Console.BufferWidth<130 || Console.WindowWidth < 130 || Console.BufferHeight<79||Console.WindowHeight < 79)
            {
                Console.WriteLine("Please set console to w/h 130/79 for best experience.");
            }

            ConsoleHelpers.SetCursorAtCenter(Logo.Length);
            Console.WriteLine(Logo);

            Thread.Sleep(1000);
            //TODO: add main menu
        }

        public void RenderBoard(IBoard board)
        {
            // validate console dimentions

            Console.Clear();
            var startRowPrintInt = Console.WindowWidth / 2 - (board.TotalRows / 2) * ConsoleConstants.CharactersPerBoardSquare;
            var startColPrintInt = Console.WindowHeight / 2 - (board.TotalCols / 2) * ConsoleConstants.CharactersPerBoardSquare;

            var currentRowPrint = startRowPrintInt;
            var currentColPrint = startColPrintInt;

            int counter = 1; // for correct board colors
            for (int top = 0; top < board.TotalRows; top++)
            {
                for (int left = 0; left < board.TotalCols; left++)
                {
                    currentRowPrint = startColPrintInt + top * ConsoleConstants.CharactersPerBoardSquare;
                    currentColPrint = startRowPrintInt + left * ConsoleConstants.CharactersPerBoardSquare;

                    ConsoleColor backgroundColor;
                    if (counter % 2 == 0)
                    {
                        backgroundColor = Console.BackgroundColor = black;
                    }
                    else
                    {
                        backgroundColor = Console.BackgroundColor = white;
                    }

                    var position = Position.FromArrCordinates(top, left, board.TotalRows);
                    var figure = board.GetfigureAtPosition(position);

                    ConsoleHelpers.PrintChessFigure(figure, backgroundColor, currentRowPrint, currentColPrint);

                    counter++;
                }
                counter++;
            }
            Console.ReadLine();
        }
    }
}
