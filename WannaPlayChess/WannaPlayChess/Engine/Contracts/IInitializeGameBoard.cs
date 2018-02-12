using System.Collections.Generic;
using WannaPlayChess.Board;
using WannaPlayChess.Players.Contracts;

namespace WannaPlayChess.Engine.Contracts
{
    public interface IInitializeGameBoard
    {
        void Initialize(IEnumerable<IPlayer> players, IBoard board);
    }
}
