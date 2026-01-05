using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseATK              = +38;
            int elementalMastery     = 41;
            int weaponLv             = 1;
            int MaxWeaponRv          = 90;
            int tier                 = 3;
            int RefinementRank       = 1;

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃     baseATK              {baseATK}       ┃");
            Console.WriteLine($"┃     elementalMastery     {elementalMastery}       ┃");
            Console.WriteLine($"┃     weaponLv             {weaponLv}        ┃");
            Console.WriteLine($"┃     MaxWeaponRv          {MaxWeaponRv}       ┃");
            Console.WriteLine($"┃     tier                 {tier}        ┃");
            Console.WriteLine($"┃     RefinementRank       {RefinementRank}        ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Console.WriteLine();
        }
    }
}
