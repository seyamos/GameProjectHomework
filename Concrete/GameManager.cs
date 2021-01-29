using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomework
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameId + " No'lu " + game.GameName +", " + game.GamePrice +"$ fiyatıyla sisteme eklendi");
        }
    }
}
