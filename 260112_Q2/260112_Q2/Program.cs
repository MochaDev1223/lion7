using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260112_Q2
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
        static void Grade(int score)
        {
            string grade = "";

            if (score >= 90)
            {
                grade = "A";
                Console.WriteLine($"점수 : {score}");
                Console.WriteLine($"등급 : {grade}");
                Console.WriteLine();
            }

            else if (score >= 80)
            {
                grade = "B";
                Console.WriteLine($"점수 : {score}");
                Console.WriteLine($"등급 : {grade}");
                Console.WriteLine();
            }

            else if (score >= 60)
            {
                grade = "C";
                Console.WriteLine($"점수 : {score}");
                Console.WriteLine($"등급 : {grade}");
                Console.WriteLine();
            }

            else if (score >= 40)
            {
                grade = "D";
                Console.WriteLine($"점수 : {score}");
                Console.WriteLine($"등급 : {grade}");
                Console.WriteLine();
            }

            else
            {
                grade = "F";
                Console.WriteLine($"점수 : {score}");
                Console.WriteLine($"등급 : {grade}");
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            Grade(90);
            Grade(88);
            Grade(68);
            Grade(42);
            Grade(21);
        }
    }
}
