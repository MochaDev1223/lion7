using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260106_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //### 도전 문제 1: 크리티컬 데미지 계산
            // 기본 공격력 100, 크리티컬 확률 25 % 일 때:
            //-일반 공격 데미지
            //-크리티컬 공격 데미지(1.5배)
            //-4번 공격 시 평균 데미지

            int baseAtk = 100;
            float critRate = 0.25f;
            var critDamage = baseAtk * 1.5f;
            var averageDamage = (baseAtk * (1 - critRate) + (critDamage * critRate));



            Console.WriteLine($"일반 공격 데미지 : {baseAtk}");
            Console.WriteLine($"크리티컬 공격 데미지 : {critDamage}");
            Console.WriteLine($"1회 공격 시 평균 데미지 : {averageDamage}");
            Console.WriteLine($"4회 공격 시 평균 데미지 : {averageDamage * 4}");


        }
    }
}
