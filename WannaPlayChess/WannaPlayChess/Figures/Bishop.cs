using WannaPlayChess.Common;
using WannaPlayChess.Figures.Contracts;

namespace WannaPlayChess.Figures
{
    public class Bishop : ChessFigure, IFigure
    {
        public Bishop(ChessColor color) 
            : base(color)
        {
        }
    }
}
