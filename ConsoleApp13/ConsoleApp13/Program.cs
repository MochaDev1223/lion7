using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // 유니코드

            #region 인벤토리 시스템
            /*
                        //인벤토리 시스템 (최대 5개)
                        string[] inventory = new string[5];

                        //아이템 추가
                        inventory[0] = "회복 포션";
                        inventory[1] = "마나 포션";
                        inventory[2] = "강철 검";
                        inventory[3] = "가죽 갑옷";
                        inventory[4] = "마법 반지";


                        //인벤토리 출력
                        Console.WriteLine("=== 인벤토리 ===");

                        for (int i = 0; i < inventory.Length; i++)
                        {
                            Console.WriteLine($"[{i + 1}] {inventory[i]}");
                        }

                        //특정 아이템 사용
                        Console.WriteLine($"\n{inventory[0]}를 사용했습니다!");
                        inventory[0] = "(비어있음)";

                        for (int i = 0; i < inventory.Length; i++)
                        {
                            Console.WriteLine($"[{i + 1}] {inventory[i]}");
                        }
            */
            #endregion

            #region 플레이어 스탯 배열
            /*
                        //hp 100
                        //mp 50
                        //공격력 80
                        //방어력 60
                        //민첩 45

                        string[] playerStatName = new string[5];
                        int[] playerStat = new int[5];

                        playerStatName[0] = "HP";
                        playerStatName[1] = "MP";
                        playerStatName[2] = "공격력";
                        playerStatName[3] = "방어력";
                        playerStatName[4] = "민첩";

                        playerStat[0] = 100;
                        playerStat[1] = 50;
                        playerStat[2] = 80;
                        playerStat[3] = 60;
                        playerStat[4] = 45;


                        Console.WriteLine("\n=== 플레이어 스탯 ===");

                        for (int i = 0; i < playerStatName.Length; i++)
                        {
                            Console.WriteLine($"[{i + 1}] {playerStatName[i]} : {playerStat[i]}");
                        }
            */
            #endregion

            #region 일일 퀘스트 진행도
            /*
                        int maxQuest = 5;
                        string isClear;

                        string[] enemyName = { "고블린", "오크", "슬라임", "드래곤", "좀비" };

                        *//* string[] enemyName = new string[5];
                         enemyName[0] = "고블린";
                         enemyName[1] = "오크";
                         enemyName[2] = "슬라임";
                         enemyName[3] = "드래곤";
                         enemyName[4] = "좀비";*//*

                        int[] clearCount = { 5, 3, 8, 2, 7 };

                        *//*int[] clearCount = new int[5];
                        clearCount[0] = 5;
                        clearCount[1] = 3;
                        clearCount[2] = 8;
                        clearCount[3] = 2;
                        clearCount[4] = 7;*//*



                        Console.WriteLine("\n=== 일일 퀘스트 진행도 ===");

                        for (int i = 0; i < enemyName.Length; i++)
                        {
                            if (clearCount[i] >= maxQuest)
                            {
                                isClear = "✅ 완료";
                            }

                            else
                                isClear = "⏳ 진행중";

                            Console.WriteLine($"{enemyName[i]} : ({clearCount[i]} / {maxQuest} : {isClear})");
                        }
            */
            #endregion

            #region 배열의 길이, 순회 합계, 큰수 작은수 찾기, Sort

            int[] scores = { 85, 92, 78, 95, 88 };

            // 배열 길이
            Console.WriteLine("총 점수 개수 : " + scores.Length);

            // 배열 순회
            Console.WriteLine("\n개별 점수");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"플레이어 {i + 1} : {scores[i]}점");
            }

            // 배열 내 합계 계산

            int sum = 0;

            for (int i = 0;i < scores.Length; i++)
            {
                sum += scores[i];
            }

            Console.WriteLine($"\n총점 : {sum}점");
            Console.WriteLine($"평균 : {(float)sum / scores.Length}점");

            // 최고점 찾기
            int highScore = scores[0];

            for (int i = 0; i < scores.Length; i++)
            {
                if (highScore < scores[i])
                    highScore = scores[i];
            }

            Console.WriteLine($"최고 점수 : {highScore}");

            // 최저점 찾기

            int lowScore = scores[0];

            for (int i = 0; i < scores.Length; i++)
            {
                if (lowScore > scores[i])
                    lowScore = scores[i];
            }

            Console.WriteLine($"최저 점수 : {lowScore}");

            // Array 클래스 매서드 활용

            Console.WriteLine("\n=== Array 매서드 ===");

            int[] sortedScores = (int[])scores.Clone();
            Array.Sort(sortedScores);
            Console.Write("정렬 후 : ");

            for(int i = 0; i < sortedScores.Length; i++)
            {
                Console.Write($"{sortedScores[i]} ");
            }

            // 역순 정렬
            Array.Reverse(sortedScores);
            Console.Write("\n역순 정렬 : ");

            for (int i = 0; i < sortedScores.Length; i++)
            {
                Console.Write($"{sortedScores[i]} ");
            }

            // 검색
            int searchScore = 92;
            int index = Array.IndexOf(scores, searchScore);
            Console.WriteLine($"\n{searchScore}점의 위치 : 인덱스 {index}");
            Console.WriteLine("찾은 값 : " + scores[index]);

            #endregion

        }
    }
}
