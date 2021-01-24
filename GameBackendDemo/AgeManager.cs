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
            int age = year -= player.YearOfBirth;
            year = 2021;
            return age;
            
        }
    }
}
