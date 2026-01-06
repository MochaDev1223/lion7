using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260106_Q1
{
    internal class program1
    {
        public static void Run()
        {
            /* 문제 1
            플레이어의 현재 체력이 80이고, 최대 체력이 100입니다.
            몬스터에게 25의 데미지를 받았습니다
            회복 포션으로 30을 회복했습니다
            독 데미지로 5를 받았습니다
            최종 체력을 계산하여 출력하세요.
            /*

            /* 예상출력 
            초기 체력: 80 / 100
            데미지 - 25: 55 / 100
            회복 + 30: 85 / 100
            독 데미지 -5: 80 / 100
            */

            int currentHP = 80;
            int maxHP = 100;
            int damage = 25;
            int heal = 30;
            int poison = 5;

            Console.WriteLine("=== 게임 시작 === \n");
            Console.WriteLine($"체력 : {currentHP} / {maxHP}\n");

            Console.WriteLine("몬스터에게 25의 데미지를 받았습니다!");
            Console.WriteLine($"체력 : {currentHP -= damage} / {maxHP}\n");

            Console.WriteLine("회복 포션으로 30을 회복했습니다!");
            Console.WriteLine($"체력 : {currentHP += heal} / {maxHP}\n");

            Console.WriteLine("독 데미지로 5를 받았습니다!");
            Console.WriteLine($"체력 : {currentHP -= poison} / {maxHP}\n");



        }
    }
}
