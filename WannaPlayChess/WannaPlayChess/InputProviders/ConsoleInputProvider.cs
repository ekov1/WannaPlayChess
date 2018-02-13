using System;
using System.Collections.Generic;
using WannaPlayChess.Common;
using WannaPlayChess.Common.Console;
using WannaPlayChess.InputProviders.Contracts;
using WannaPlayChess.Players;
using WannaPlayChess.Players.Contracts;

namespace WannaPlayChess.InputProviders
{
    public class ConsoleInputProvider : IInputProvider
    {
        private const string PlayerNameText = "Enter Player {0} name: ";
        public IList<IPlayer> GetPlayers(int numberOfPlayers)
        {
            var players = new List<IPlayer>();

            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.Clear();
                ConosoleHelpers.SetCursorAtCenter(PlayerNameText.Length);
                Console.WriteLine(PlayerNameText,i);
                string name = Console.ReadLine();
                var player = new Player(name, (ChessColor)(i - 1));
                players.Add(player);
            }

            return players;
        }
    }
}
