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
    public static class Facade
    {
        public static void Start()
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
