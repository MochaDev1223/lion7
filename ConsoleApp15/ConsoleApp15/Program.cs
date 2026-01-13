using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void SayHello()
        {
            Console.WriteLine("안녕하세요, 용사님");
            Console.WriteLine("모험을 시작합니다.");
        }

        static void ShowGameStart()
        {
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║ ⚔ RPG 게임 시작 ⚔ ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
        }

        static void PrintSeparator()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }

        static void Attack(int att, int def)
        {
            Console.WriteLine("공격력 전달받았다. : " + att);
            Console.WriteLine("방어력 : " + def);
        } 

        static void playerStat(string playerName, int playerAtk, int playerDef, int playerDex, int playerLuk)
        {

            Console.WriteLine("플레이어 이름 : " + playerName);
            Console.WriteLine("공격력 : " + playerAtk);
            Console.WriteLine("방어력 : " + playerDef);
            Console.WriteLine("민첩 : " + playerDex);
            Console.WriteLine("운 : " + playerLuk);

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //ShowGameStart();
            //Console.WriteLine();

            //SayHello();
            //PrintSeparator();

            //Console.WriteLine("게임 메뉴를 불러옵니다.....");

            //PrintSeparator();


            ////같은 함수를 여러번 호출 가능
            //Console.WriteLine("게임 종료");

            //PrintSeparator();

            //Attack(100, 20);

            playerStat("서승태", 100, 20, 200, 4);

        }
    }
}
