using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260106_Q1
{
    internal class program2
    {
        public static void Run()
        {
            /*문제 2
            플레이어가 몬스터 3마리를 처치했습니다.
            몬스터 1마리당 경험치: 150
            레벨업에 필요한 경험치: 500

            총 획득 경험치와 레벨업까지 남은 경험치를 계산하세요.

            *연산자와 -연산자 사용
            */


            /* 예상 출력
            처치한 몬스터: 3마리
            획득 경험치: 450
            레벨업까지 필요: 50
            */

            int expPerMonster = 150;
            int monstersKilled = 3;
            int expForLevelUp = 500;
            int totalExp = expPerMonster * monstersKilled;


            Console.WriteLine("=== 사냥 시작 ===\n");

            Console.WriteLine("플레이어가 몬스터 3마리를 처치했습니다.");
            Console.WriteLine($"처치한 몬스터: {monstersKilled}마리");
            Console.WriteLine($"획득 경험치 : {totalExp}");
            Console.WriteLine($"레벨업까지 남은 경험치 : {expForLevelUp - totalExp}");


        }
    }
}
