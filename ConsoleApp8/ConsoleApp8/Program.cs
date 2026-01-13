using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //현재 체력: 30 / 100
            //⚠️ 경고: 체력이 위험합니다!
            //회복 아이템을 사용하세요!
            //💊 체력이 50 % 이하입니다.

            //⚔️ 적이 사거리 안에 있습니다!
            //공격 가능!
            Console.OutputEncoding = Encoding.UTF8;

            int hp = 30;
            int maxHp = 100;
            int enemyDistance = 5;
            int atkRange = 3;

            if ((double)hp / maxHp <= 0.3) 
            {
                Console.WriteLine("⚠️ 경고: 체력이 위험합니다!");
                Console.WriteLine("회복 아이템을 사용하세요!");
            }
            else if ((double)hp / maxHp <= 0.5)
                Console.WriteLine("💊 체력이 50 % 이하입니다.");

            else if (hp == 0)
                Console.WriteLine("게임 오버");

            if (enemyDistance <= atkRange)
            {
                Console.WriteLine("⚔️ 적이 사거리 안에 있습니다!");
                Console.WriteLine("공격 가능!");
            }

            else
                Console.WriteLine("공격할 적을 찾지 못했습니다.");

            

        }
    }
}