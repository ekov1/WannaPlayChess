using System.Collections.Generic;
using WannaPlayChess.Players.Contracts;

namespace WannaPlayChess.InputProviders.Contracts
{
    public interface IInputProvider
    {
        IList<IPlayer> GetPlayers(int numberOfPlayers);
    }
}
