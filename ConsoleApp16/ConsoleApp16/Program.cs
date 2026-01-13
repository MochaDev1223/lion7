using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void GreetPlayer(string playerName)
        {
            Console.WriteLine($"환영합니다.{playerName}님!");
        }
        
        static void ShowPlayerInfo(string job, int level)
        {
            Console.WriteLine($"직업 : {job}");
            Console.WriteLine($"레벨 : {level}");
        }

        static void DrawHealthBar(int current, int max, int barLength)
        {
            Console.Write("HP [");

            int filledLength = current / max * barLength;

            for (int i = 0; i < barLength; i++)
            {
                if (i < filledLength)
                    Console.Write("■");
                else
                    Console.Write("□");
            }

            Console.WriteLine($"] {current} / {max}");
        }

        static void ShowDamage(string attacker, string target, int damage)
        {
            Console.WriteLine($"{attacker}의 공격!");
            Console.WriteLine($"{target}에게 {damage}데미지!");

        }

        static void Main(string[] args)
        {
            GreetPlayer("서승태");
            Console.WriteLine();
            ShowPlayerInfo("전사", 27);
            Console.WriteLine();
            DrawHealthBar(75, 100, 20);
            Console.WriteLine();
            ShowDamage("플레이어", "고블린", 30);
            Console.WriteLine();
        }
    }
}
