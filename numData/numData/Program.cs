using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 정수 데이터 형식
            //byte level = 50;
            //short attack = 1500;
            //int gold = 1234567;
            //long experience = 99999999L; // (L 접미사 필수)

            //Console.WriteLine("=== 캐릭터 정보 ===");
            //Console.WriteLine($"레벨 : {level}");
            //Console.WriteLine($"공격력 : {attack}");
            //Console.WriteLine($"소지금 : {gold:N0} 골드");
            //Console.WriteLine($"경험치 : {experience:N0}");

            //Console.WriteLine("\n=== 타입별 최대값 ===");
            //Console.WriteLine($"byte 최대값 : {byte.MaxValue}");
            //Console.WriteLine($"short 최대값 : {short.MaxValue}");
            //Console.WriteLine($"int 최대값 : {int.MaxValue:N0}");
            //Console.WriteLine($"long 최대값 : {long.MaxValue:N0}");

            ////실수 데이터 형식
            //float singlePrecision = 3.14f;
            //double doublePrecision = 3.141592;
            //decimal highPrecision = 3.1415926535897932384626433833m;

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);
            //Console.WriteLine("\n====================");

            //// 접미사 사용 : 숫자의 데이터 형식을 명시
            //int integerValue = 100;
            //long longValue = 100L;
            //float floatValue = 3.14f;
            //double doubleValue = 3.14;
            //decimal decimalValue = 3.14m;

            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);

            // 출력미션
            // ==== 캐릭터 능력치 ====
            // float 이동속도 5.5
            // double 공격속도 1.25
            // decimal 아이템 가격 12.99

            //float moveSpeed = 5.5f;
            //double atkSpeed = 1.25;
            //decimal itemPrice = 12.99m;

            //Console.WriteLine("==== 캐릭터 능력치 ====");
            //Console.WriteLine($"이동속도 : {moveSpeed}");
            //Console.WriteLine($"공격속도 : {atkSpeed}");
            //Console.WriteLine($"아이템 가격 : {itemPrice}");

            //bool isRunning = true;
            //bool isFinished = false;


            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);

            // 실전예제
            // 게임 실행 중 : true
            // 일시정지 : false
            // 열쇠 소지 : false
            // 문 열림 : false
            // 플레이어 생존 : true

            //=== 게임 상태 ===
            //체력: 80
            //건강상태 : true
            //위험 상태 : false

            bool isPlaying = true;
            bool isPaused = false;
            bool hasKey = false;
            bool isDoorOpen = false;
            bool isPlayerAlive = true;


            int hp = 80;
            bool isHealthy = true;
            bool isInDanger = false;

            Console.WriteLine("=== 게임 상태 ===");
            Console.WriteLine($"게임 실행 중 : {isPlaying}");
            Console.WriteLine($"일시정지 : {isPaused}");
            Console.WriteLine($"일시정지 : {hasKey}");
            Console.WriteLine($"문 열림 : {isDoorOpen}");
            Console.WriteLine($"플레이어 생존 : {isPlayerAlive}");

            Console.WriteLine("\n=== 캐릭터 상태 ===");
            Console.WriteLine($"체력 : {hp}");
            Console.WriteLine($"건강 상태 : {isHealthy}");
            Console.WriteLine($"위험 상태 : {isInDanger}");
            string hasGoldAsString = hasGold.ToString();

            Console.WriteLine($"골드 : {hasGold}");

        }
    }
}
