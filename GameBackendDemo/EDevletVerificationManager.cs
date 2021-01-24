using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo
{
    class EDevletVerificationManager
    {
        AgeManager ageManager = new AgeManager();
        public void Verification(Player player)
        {
            Console.WriteLine("*===============================================*");
            Console.WriteLine(player.Id + " ID Numaralı Oyuncunun Kimlik Bilgileri Doğrulandı, Adı: " + player.FirstName + " " + player.LastName + " Yaşı : "+ ageManager.CalculateAge(player));
        }
    }
}
