using System;
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

        public void RenderMainMenu()
        {
            ConosoleHelpers.SetCursorAtCenter(Logo.Length);
            Console.WriteLine(Logo);

            Thread.Sleep(1500);
            // main menu
        }

        public void RenderBoard(IBoard board)
        {
            Console.BackgroundColor = ConsoleColor.White;
            var startRowPrintInt = Console.WindowHeight / 2 - (board.TotalRows / 2) * CharactersPerBoardSquare;
            var startColPrintInt = Console.WindowWidth / 2 - (board.TotalCols / 2) * CharactersPerBoardSquare;

            Console.SetCursorPosition(startColPrintInt, startRowPrintInt);
        }
    }
}
