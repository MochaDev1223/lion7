using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 4;

            //a += b;
            //Console.WriteLine("더하기 : " + a);
            //a = 5;

            //a -= b;
            //Console.WriteLine("빼기 : " + a);
            //a = 5;

            //a *= b;
            //Console.WriteLine("곱하기 : " + a);
            //a = 5;

            //a /= b;
            //Console.WriteLine("나누기 : " + a);

            ////캐릭터 스탯 계산
            //int baseAttack = 50;
            //int weaponDamage = 30;
            //int totalAttack = baseAttack + weaponDamage;

            //Console.WriteLine("=== 공격력 계산 ===");
            //Console.WriteLine($"기본 공격력 : {baseAttack}");
            //Console.WriteLine($"무기 데미지 : {weaponDamage}");
            //Console.WriteLine($"총 공격력 : {totalAttack}");

            ////데미지 계산
            //int playerHealth = 100;
            //int damage = 25;
            //playerHealth = playerHealth - damage;

            //Console.WriteLine("\n === 데미지 계산 ===");
            //Console.WriteLine($"받은 데미지: {damage}");
            //Console.WriteLine($"남은 체력: {playerHealth}");


            ////경험치 계산
            //int monsterSkilled = 5;
            //int expPerMonster = 100;
            //int totalExp = monsterSkilled * expPerMonster;

            //Console.WriteLine("=== 경험치 획득 ===");
            //Console.WriteLine($"처치한 몬스터: {monsterSkilled}마리");
            //Console.WriteLine($"몬스터당 경험치: {expPerMonster}");
            //Console.WriteLine($"총 경험치: {totalExp}");

            ////아이템 분배
            //int totalGold = 1000;
            //int playerCount = 4;
            //int goldPerPlayer = totalGold / playerCount;
            //int remainingGold = totalGold % playerCount;


            //Console.WriteLine("===골드 분배===");
            //Console.WriteLine($"총 골드: {totalGold}");
            //Console.WriteLine($"플레이어 수 : {playerCount}명");
            //Console.WriteLine($"1인당 골드 : {goldPerPlayer}");
            //Console.WriteLine($"남은골드: {remainingGold}");


            Console.WriteLine("=== 몬스터 처치 ===");
            int killCount = 0;

            Console.WriteLine($"고블린 처치! (킬 카운트 : {++killCount})");
            Console.WriteLine($"오크 처치! (킬 카운트 : {++killCount})");
            Console.WriteLine($"드래곤 처치! (킬 카운트 : {++killCount})");
            Console.WriteLine($"총 처치 수 : {killCount}");

            Console.WriteLine("=== 사격 ===");
            int ammoCount = 30;
            Console.WriteLine($"남은 탄약 : {ammoCount}");
            Console.WriteLine($"발사! 남은 탄약 : {--ammoCount}"); 
            Console.WriteLine($"발사! 남은 탄약 : {--ammoCount}");
            Console.WriteLine($"발사! 남은 탄약 : {--ammoCount}");

            Console.WriteLine("=== 카운트다운 ===");
            int countDown = 3;

            Console.WriteLine(countDown--);
            Console.WriteLine(countDown--);
            Console.WriteLine(countDown--);



        }
    }
}
