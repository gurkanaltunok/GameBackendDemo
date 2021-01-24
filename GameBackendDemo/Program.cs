using System;
using System.Collections.Generic;

namespace GameBackendDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager();
            EDevletVerificationManager eDevletVerificationManager = new EDevletVerificationManager();
            GameSalesManager gameSalesManager = new GameSalesManager();

            Player player1 = new Player();
            player1.Id = 1;
            player1.TcNo = "12345678910";
            player1.FirstName = "Gürkan";
            player1.LastName = "Altunok";
            player1.YearOfBirth = 2001;

            CampaignPlayer player2 = new CampaignPlayer();
            player2.Id = 2;
            player2.TcNo = "28472891829";
            player2.FirstName = "Engin";
            player2.LastName = "Demiroğ";
            player2.YearOfBirth = 1990;
            player2.CampaignCode = "AD4EDK";

            Games game1 = new Games();
            game1.GameId = 1;
            game1.GameName = "GTA V";
            game1.GamePrice = 100;

            Games game2 = new Games();
            game2.GameId = 2;
            game2.GameName = "Cyberpunk 2077";
            game2.GamePrice = 200;

            Games game3 = new Games();
            game3.GameId = 3;
            game3.GameName = "Rainbow Six Siege";
            game3.GamePrice = 150;

            Games[] games = new Games[] { game1, game2, game3 };

            playerManager.Register(player1);

            playerManager.Register(player2);

            playerManager.Delete(player1);

            eDevletVerificationManager.Verification(player1);

            eDevletVerificationManager.Verification(player2);

            foreach (var game in games)
            {
                gameSalesManager.ListGames(game);
            }

        }
    }
}
