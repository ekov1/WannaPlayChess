using System.Collections.Generic;

using WannaPlayChess.Players.Contracts;

namespace WannaPlayChess.Engine.Contracts
{
    public interface IChessEngine
    {
        IEnumerable<IPlayer> Players { get; }

        void Initialize(IInitializeGameBoard initializeGameBoard);

        void Start();

        void WiningConditions();
    }
}
