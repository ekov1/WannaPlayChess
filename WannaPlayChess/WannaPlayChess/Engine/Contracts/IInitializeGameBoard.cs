using System.Collections.Generic;
using WannaPlayChess.Board;
using WannaPlayChess.Players.Contracts;

namespace WannaPlayChess.Engine.Contracts
{
    public interface IInitializeGameBoard
    {
        void Initialize(IList<IPlayer> players, IBoard board);

    }
}
