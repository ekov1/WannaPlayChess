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
    using WannaPlayChess.Players;

    public class StandadrdTwoPlayerEngine : IChessEngine
    {
        private readonly IRenderer renderer;
        private readonly IInputProvider inputProvider;

        private readonly IEnumerable<IPlayer> players;
        private readonly IBoard board;

        public StandadrdTwoPlayerEngine(IRenderer renderer, IInputProvider inputProvider)
        {
            this.renderer = renderer;
            this.inputProvider = inputProvider;
            this.board = new Board();
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
            var players = new List<IPlayer>() { new Player("w", ChessColor.White), new Player("b", ChessColor.Black) };
           // var players = this.inputProvider.GetPlayers(GlobalConstants.StandardGameNumberOfPlayers);
            initializeGameBoard.Initialize(players, this.board);
            this.renderer.RenderBoard(board);
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
