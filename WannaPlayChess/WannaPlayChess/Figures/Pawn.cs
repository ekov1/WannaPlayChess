using WannaPlayChess.Common;
using WannaPlayChess.Figures.Contracts;

namespace WannaPlayChess.Figures
{
    public class Pawn : IFigure
    {
        public Pawn(ChessColor color)
        {
            this.Color = color;
        }

        public ChessColor Color { get; private set; }
    }
}
