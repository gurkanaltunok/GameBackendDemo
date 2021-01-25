using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendDemo
{
    class AgeManager
    {
        int year = 2021;

        public int CalculateAge(Player player)
        {
            return year - player.YearOfBirth;
            
        }
    }
}
