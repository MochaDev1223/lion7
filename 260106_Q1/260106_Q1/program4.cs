using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260106_Q1
{
    internal class program4
    {
        public static void Run()
        {
            /*문제 4
            다음 조건을 모두 만족해야 던전에 입장할 수 있습니다:
            플레이어 레벨이 30 이상
            던전 열쇠를 보유하고 있음
            체력이 50% 이상

            각 조건의 참/거짓을 확인하고, 최종 입장 가능 여부를 출력하세요.

            >=, &&, || 연산자 활용

            */


            /* 예상 출력
            === 던전 입장 조건 ===
            레벨 조건 (30 이상): True
            열쇠 보유: True
            체력 조건 (50% 이상): True
            입장 가능: True
            */

            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            int currentHP = 60;
            int maxHP = 100;

            bool isLevelOk = playerLevel >= requiredLevel;
            bool isHpOk = currentHP >= maxHP * 0.5;

            Console.WriteLine("=== 던전 입장 조건 === \n");
            Console.WriteLine($"레벨 조건 (Lv.30 이상) : {isLevelOk}");
            Console.WriteLine($"열쇠 보유 : {hasKey}");
            Console.WriteLine($"체력 조건 (50% 이상) : {isHpOk}");
            Console.WriteLine($"입장 가능 : {isLevelOk && hasKey && isHpOk}");


        }
    }
}
