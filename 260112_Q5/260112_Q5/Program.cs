using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260112_Q5
{
    //문제 1: 평균 계산 함수
    //정수 배열을 받아 평균을 반환하는 함수를 만드세요.

    //문제 2: 등급 판별 함수
    //점수를 받아 A, B, C, D, F 등급을 반환하는 함수를 만드세요.

    //문제 3: 소수 판별 함수
    //숫자를 받아 소수인지 판별하는 함수를 만드세요.

    //문제 4: 경험치 시스템
    //현재 경험치와 획득 경험치를 받아
    //레벨업 여부와 새 경험치를 반환하는 함수를 만드세요. (out 사용)

    //문제 5: 아이템 강화 시스템
    //강화 레벨에 따라 성공 확률이 달라지는
    //아이템 강화 시스템을 함수로 구현하세요.

    internal class Program
    {
        static Random rand = new Random();

        static int GetSuccessRate(int level)
        {
            if (level == 1) return 100;
            else if (level == 2) return 80;
            else if (level == 3) return 60;
            else if (level == 4) return 40;
            else if (level == 5) return 20;
            else return 10;
        }

        static void EnhanceItem(int currentLevel, out bool isSuccess, out int newLevel)
        {
            int successRate = GetSuccessRate(currentLevel);

            //for문 사용시 난수 고정으로 정적난수
            //Random rand = new Random();

            int roll = rand.Next(1, 101);

            if (roll <= successRate)
            {
                isSuccess = true;
                newLevel = currentLevel + 1;
            }

            else
            {
                isSuccess = false;
                newLevel = currentLevel;
            }

        }

        static void Main(string[] args)
        {
            int level = 2;

            bool success;
            int resultLevel;

            for (int i = 0; i < 5; i++)
            {
                EnhanceItem(level, out success, out resultLevel);

                Console.WriteLine($"현재 강화 레벨: +{level}");
                Console.WriteLine($"강화 성공 여부: {success}");
                Console.WriteLine($"강화 후 레벨: +{resultLevel}");
                Console.WriteLine();

                level = resultLevel;
            }

        }
    }
}
