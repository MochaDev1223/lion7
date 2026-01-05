using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 상수(const) : 값을 변경할 수 없는 변수

            //const double Pi = 3.141592;
            //const int MaxScore = 100;

            //Console.WriteLine("Pi: " + Pi);
            //Console.WriteLine("Max score: "+ MaxScore);

            const int maxPlayer = 4;
            const int startGold = 1000;
            const string ver = "1.0.0";

            Console.WriteLine("=== 게임설정 ===");
            Console.WriteLine($"최대 플레이어: {maxPlayer}명");
            Console.WriteLine($"시작 골드: {startGold}G");
            Console.WriteLine($"버전: {ver}");
        }
    }
}
