using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo
{
    class PlayerManager
    {
        public void Register(Player player)
        {
            Console.WriteLine("*===============================================*");
            Console.WriteLine(player.Id + " ID Numaralı Oyuncu Kayıt Oldu : " + player.FirstName + " " + player.LastName);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("*===============================================*");
            Console.WriteLine(player.Id + " ID Numaralı Oyuncunun Kaydı Silindi: " + player.FirstName + " " + player.LastName);
        }

    }
}
