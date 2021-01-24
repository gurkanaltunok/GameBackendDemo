using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo
{
    class GameSalesManager
    {
        public void ListGames(Games game)
        {
            Console.WriteLine("*===============================================*");
            Console.WriteLine("Oyun Adı: "+ game.GameName);
            Console.WriteLine("Oyun Fiyatı: "+ game.GamePrice);
        }
    }
}
