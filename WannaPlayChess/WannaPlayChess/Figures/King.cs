using WannaPlayChess.Common;
using WannaPlayChess.Figures.Contracts;

namespace WannaPlayChess.Figures
{
    public class King : ChessFigure, IFigure
    {
        public King(ChessColor color) 
            : base(color)
        {
        }
    }
}
