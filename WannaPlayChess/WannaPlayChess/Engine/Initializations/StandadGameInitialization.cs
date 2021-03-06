﻿using System;
using System.Collections.Generic;
using WannaPlayChess.Board;
using WannaPlayChess.Common;
using WannaPlayChess.Engine.Contracts;
using WannaPlayChess.Figures;
using WannaPlayChess.Figures.Contracts;
using WannaPlayChess.Players.Contracts;

namespace WannaPlayChess.Engine.Initializations
{
    public class StandadGameInitialization : IInitializeGameBoard
    {
        private const int BoradTotalRowsCols = 8;

        private IList<Type> figureTypes;

        public StandadGameInitialization()
        {
            this.figureTypes = new List<Type>()
            {
                typeof(Rook),
                typeof(Knight),
                typeof(Bishop),
                typeof(Queen),
                typeof(King),
                typeof(Bishop),
                typeof(Knight),
                typeof(Rook)
            };
        }

        public void Initialize(IList<IPlayer> players, IBoard board)
        {
            this.ValidateGameInitialization(players, board);

            var firstPlayer = players[0];
            var secondPlayer = players[1];

            this.InitializePawns(firstPlayer, board, 7);
            this.InitializeKingsRow(firstPlayer, board, 8);

            this.InitializePawns(secondPlayer, board, 2);
            this.InitializeKingsRow(secondPlayer, board, 1);
        }

        private void InitializeKingsRow(IPlayer player, IBoard board, int chessRow)
        {
            for (int i = 0; i < BoradTotalRowsCols; i++)
            {
                var figureType = this.figureTypes[i];
                var figureInstance = (IFigure)Activator.CreateInstance(figureType, player.Color);
                player.AddFigure(figureInstance);

                var position = new Position(chessRow, (char)(i + 'a'));
                board.AddFigure(figureInstance, position);
            }
        }

        private void InitializePawns(IPlayer player, IBoard board, int chessRow)
        {
            for (int i = 0; i < BoradTotalRowsCols; i++)
            {
                Pawn pawn = new Pawn(player.Color);
                player.AddFigure(pawn);

                var position = new Position(chessRow, (char)(i + 'a'));
                board.AddFigure(pawn, position);
            }
        }

        private void ValidateGameInitialization(ICollection<IPlayer> players, IBoard board)
        {
            if (players.Count != GlobalConstants.StandardGameNumberOfPlayers)
            {
                throw new InvalidOperationException("Standad Game Initialization needs two players!");
            }

            if (board.TotalRows != BoradTotalRowsCols || board.TotalCols != BoradTotalRowsCols)
            {
                throw new InvalidOperationException("Standad Game Initialization needs (8 rows X cols)!");
            }
        }
    }
}
