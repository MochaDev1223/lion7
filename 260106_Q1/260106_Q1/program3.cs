using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260106_Q1
{
    internal class program3
    {
        public static void Run()
        {
            /*문제 3
            파티에서 골드 1234를 획득했습니다. 파티원은 5명입니다.
            1인당 받을 골드는 얼마인가요?
            분배 후 남는 골드는 얼마인가요?

            / 연산자와 % 연산자 사용

            */


            /* 예상 출력
            총 골드: 1234
            파티원: 5명
            1인당 골드: 246
            남은 골드: 4
            */

            int totalGold = 1234;
            int partyMembers = 5;
            Console.WriteLine("=== 골드 분배 === \n");
            Console.WriteLine($"총 골드 : {totalGold}");
            Console.WriteLine($"파티원 : {partyMembers}");
            Console.WriteLine($"1인당 골드 : {totalGold / partyMembers}");
            Console.WriteLine($"남은 골드 : {totalGold % partyMembers}");

        }
    }
}
