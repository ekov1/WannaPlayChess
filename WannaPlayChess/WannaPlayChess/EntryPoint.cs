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
        }
    }
}
