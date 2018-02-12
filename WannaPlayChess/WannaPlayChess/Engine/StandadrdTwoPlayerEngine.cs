using System;
using System.Collections.Generic;
using WannaPlayChess.Board;
using WannaPlayChess.Engine.Contracts;
using WannaPlayChess.Players.Contracts;

namespace WannaPlayChess.Engine
{
    public class StandadrdTwoPlayerEngine : IChessEngine
    {
        private readonly IEnumerable<IPlayer> players;

        public IEnumerable<IPlayer> Players
        {
            get
            {
                return new List<IPlayer>(this.players);
            }
        }

        public void Initialize(IInitializeGameBoard initializeGameBoard)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void WiningConditions()
        {
            throw new NotImplementedException();
        }
    }
}
