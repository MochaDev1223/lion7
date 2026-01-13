using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void UseItem(string potion, int heal)
        {
            Console.WriteLine($"💊 {potion} 사용!");
            Console.WriteLine($"회복량 : {heal}");
            Console.WriteLine();
        }

        static void Spell(string enemyName, int enemyLevel, int enemyCount)
        {
            Console.WriteLine($"✨ {enemyName} 소환!");
            Console.WriteLine($"레벨 : {enemyLevel}");
            Console.WriteLine($"수량 : {enemyCount}마리");
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // 유니코드


            Console.WriteLine("=== 아이템 사용 ===");
            UseItem("회복 포션", 50);
            UseItem("고급 회복 포션", 100);

            Console.WriteLine("=== 소환 마법 ===");
            Spell("슬라임", 1, 1);
            Spell("고블린", 5, 1);
            Spell("드래곤", 50, 3);

        }
    }
}
