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

        public void RenderMainMenu()
        {
            ConosoleHelpers.SetCursorAtCenter(Logo.Length);
            Console.WriteLine(Logo);

            Thread.Sleep(1500);
            // main menu
        }

        public void RenderBoard(IBoard board)
        {
            throw new System.NotImplementedException();
        }
    }
}
