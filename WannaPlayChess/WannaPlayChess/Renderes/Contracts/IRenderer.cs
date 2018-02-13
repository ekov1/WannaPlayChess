using WannaPlayChess.Board;

namespace WannaPlayChess.Renderes.Contracts
{
    public interface IRenderer
    {
        void RenderMainMenu();

        void RenderBoard(IBoard board);
    }
}
