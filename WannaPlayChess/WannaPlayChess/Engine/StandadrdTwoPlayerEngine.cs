namespace WannaPlayChess.Engine
{
    using System;
    using System.Collections.Generic;
    using WannaPlayChess.Common;
    using WannaPlayChess.Engine.Contracts;
    using WannaPlayChess.InputProviders.Contracts;
    using WannaPlayChess.Players.Contracts;
    using WannaPlayChess.Renderes.Contracts;
    using WannaPlayChess.Board;

    public class StandadrdTwoPlayerEngine : IChessEngine
    {
        private readonly IEnumerable<IPlayer> players;
        private readonly IRenderer renderer;
        private readonly IInputProvider inputProvider;
        private readonly IBoard board;

        public StandadrdTwoPlayerEngine(IRenderer renderer, IInputProvider inputProvider)
        {
            this.renderer = renderer;
            this.inputProvider = inputProvider;
        }

        public IEnumerable<IPlayer> Players
        {
            get
            {
                return new List<IPlayer>(this.players);
            }
        }

        public void Initialize(IInitializeGameBoard initializeGameBoard)
        {
            var players = inputProvider.GetPlayers(GlobalConstants.StandardGameNumberOfPlayers);
            initializeGameBoard.Initialize(players, new Board());
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
