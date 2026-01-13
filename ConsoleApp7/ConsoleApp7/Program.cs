using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10, b = 20;
            //int max = (a > b) ? a : b;
            //Console.WriteLine(max);


            //Console.Write("점수를 입력하세요: ");
            //int score = int.Parse(Console.ReadLine());

            //int score = 85;
            //string result = (score >= 60) ? "합격" : "불합격";

            //Console.WriteLine("=== 시험 결과 ===");
            //Console.WriteLine($"점수 : {score}");
            //Console.WriteLine($"결과 : {result}");

            /*// 예제2 레벨에 따른 등급
            //레벨 45
            //50보다 크면 고급 
            //50 ~ 30 사이면 중급
            //그렇지 않으면 초급

            // 플레이어 등급
            // 레벨 : 00
            // 등급 : 00

            int playerLv = 45;
            string grade = (playerLv > 50) ? "고급" : (playerLv >= 30 ? "중급" : "초급");


            Console.WriteLine("플레이어 등급");
            Console.WriteLine($"레벨 : {playerLv}");
            Console.WriteLine($"등급 : {grade}");*/


            // 예제 3

            //int health = 30;
            //int maxHealth = 100;

            //// 헬스 상태 70 안전  70~30 주의    이하 위험
            //string state = (health > 70) ? "안전" : (health >= 30 ? "주의" : "위험");

            //Console.WriteLine($"헬스 상태 : {state}");

            // 예제 2: 데미지 계산
            int baseDamage = 50;
            int bonusDamage = 20;
            double criticalMultiplier = 1.5;

            // 잘못된 계산
            double damage1 = baseDamage + bonusDamage * criticalMultiplier;
            // 올바른 계산
            double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            Console.WriteLine($"기본 데미지: {baseDamage}");
            Console.WriteLine($"보너스 데미지: {bonusDamage}");
            Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            Console.WriteLine($"올바른 계산: {damage2}");  // 105.0

        }
    }
}
