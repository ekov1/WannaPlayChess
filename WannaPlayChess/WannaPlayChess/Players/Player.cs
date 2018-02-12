using System;
using System.Collections.Generic;
using WannaPlayChess.Common;
using WannaPlayChess.Figures.Contracts;
using WannaPlayChess.Players.Contracts;

namespace WannaPlayChess.Players
{
    public class Player : IPlayer
    {
        private ICollection<IFigure> figures;

        public Player(string name, ChessColor color)
        {
            this.Name = name;
            this.Color = color;
            this.figures = new List<IFigure>();
        }

        public string Name { get; private set; }

        public ChessColor Color { get; private set; }

        public void AddFigure(IFigure figure)
        {
            ObjectValidator.CheckIfObjectIsNull(figure, GlobalErrormessages.NullFigureErrorMessage);
            this.CheckIfFigureExist(figure);
            figures.Add(figure);
        }

        public void RemoveFigure(IFigure figure)
        {
            ObjectValidator.CheckIfObjectIsNull(figure, GlobalErrormessages.NullFigureErrorMessage);
            CheckIfFigureDoesNotExist(figure);
            figures.Remove(figure);
        }

        private void CheckIfFigureExist(IFigure figure)
        {
            if (this.figures.Contains(figure))
            {
                throw new InvalidOperationException("This player already owns this figure!");
            }
        }

        private void CheckIfFigureDoesNotExist(IFigure figure)
        {
            if (!this.figures.Contains(figure))
            {
                throw new InvalidOperationException("This player does not own this figure!");
            }
        }
    }
}
