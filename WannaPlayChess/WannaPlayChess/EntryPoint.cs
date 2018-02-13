using System;
using WannaPlayChess.Engine;
using WannaPlayChess.Engine.Contracts;
using WannaPlayChess.Engine.Initializations;
using WannaPlayChess.InputProviders;
using WannaPlayChess.InputProviders.Contracts;
using WannaPlayChess.Renderes;
using WannaPlayChess.Renderes.Contracts;

namespace WannaPlayChess
{
    public class EntryPoint
    {
        public static void Main()
        {
            IRenderer renderer = new ConsoleRenderer();
            renderer.RenderMainMenu();

            IInputProvider inputProvider = new ConsoleInputProvider();

            IChessEngine engine = new StandadrdTwoPlayerEngine(renderer, inputProvider);

            IInitializeGameBoard initializeGameBoard = new StandadGameInitialization();

            engine.Initialize(initializeGameBoard);
            engine.Start();

            Console.ReadLine();
        }
    }
}
