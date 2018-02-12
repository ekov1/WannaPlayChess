﻿using WannaPlayChess.Common;
using WannaPlayChess.Figures.Contracts;

namespace WannaPlayChess.Figures
{
    public class Pawn : ChessFigure, IFigure
    {
        public Pawn(ChessColor color)
            : base(color)
        {
        }
    }
}
