using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 콘솔 기본 세팅
            Console.OutputEncoding = Encoding.UTF8;         // 유니코드
            Console.Title = "🎮 RPG 콘솔 게임";             // 콘솔 제목
            Console.ForegroundColor = ConsoleColor.Green;   // 콘솔 텍스트 색
            Console.ResetColor();
            Console.CursorVisible = false;                  // 깜빡이는 커서 삭제
            #endregion

            #region 아이템 구매 시스템
            /*
                        int playerGold = 500;
                        int itemPrice = 250;
                        string itemName = "강철 검";

                        Console.WriteLine("=== 상점 ===");
                        Console.WriteLine($"아이템 : {itemName}");
                        Console.WriteLine($"가격 : {itemPrice}G");
                        Console.WriteLine($"소지금 : {playerGold}G\n");

                        if (playerGold >= itemPrice) 
                        {
                            // 구매 가능
                            Console.WriteLine("구매 성공!");
                            Console.WriteLine($"{itemName}을 획득했습니다.");
                            Console.WriteLine($"남은 골드 : {playerGold - itemPrice}G");
                        }

                        else
                        {
                            int needGold = itemPrice - playerGold;
                            Console.WriteLine("골드가 부족합니다.");
                            Console.WriteLine($"필요한 골드 : {needGold}G");
                        }


                        Console.WriteLine("\n=== 던전 입장 ===");
                        int playerLv = 48;
                        int requiredLv = 50;

                        if (playerLv >= requiredLv)
                        {
                            Console.WriteLine("던전에 입장합니다!");
                            Console.WriteLine("전투 준비!");
                        }
                        else
                        {
                            Console.WriteLine("레벨이 부족합니다.");
                            Console.WriteLine("레벨업이 필요합니다.");
                            Console.WriteLine($"현재 레벨 : Lv.{playerLv}");
                            Console.WriteLine($"권장 레벨 : Lv.{requiredLv}");
            */
            #endregion

            #region 점수에 따른 등급 판정
            /*
                        string rank;

                        Console.WriteLine("=== 게임 랭크 시스템 ===");
                        Console.Write("점수를 입력하세요 : ");
                        int score = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\n점수 : {score}");

                        // 등급 기준
                        if (score >= 10000) 
                        {
                            rank = "SSS";
                            Console.WriteLine($"등급 : {rank} (레전드)");
                            Console.WriteLine($"보상 : 전설 아이템 + 10000G");
                        }
                        else if (score >= 8000)
                        {
                            rank = "SS";
                            Console.WriteLine($"등급 : {rank} (마스터)");
                            Console.WriteLine($"보상 : 영웅 아이템 + 5000G");
                        }

                        else if (score >= 6000)
                        {
                            rank = "S";
                            Console.WriteLine($"등급 : {rank} (다이아)");
                            Console.WriteLine($"보상 : 희귀 아이템 + 3000G");
                        }

                        else if (score >= 4000)
                        {
                            rank = "A";
                            Console.WriteLine($"등급 : {rank} (플래티넘)");
                            Console.WriteLine($"보상 : 고급 아이템 + 1500G");
                        }
                        else
                        {
                            rank = "B";
                            Console.WriteLine($"등급 : {rank} (골드)");
                            Console.WriteLine($"보상 : 일반 아이템 + 500G");
                        }
            */
            #endregion

            #region 캐릭터 상태 판정
            /*
                        Console.WriteLine("\n=== 캐릭터 상태 ===");
                        //int health = 50;
                        //헬스값을 입력받아서 테스트해보시오.
                        Console.Write("체력을 입력하세요 : ");
                        int health = int.Parse(Console.ReadLine());

                        if (health >= 80)
                        {
                            Console.WriteLine("💚 상태: 매우 좋음");
                        }
                        else if (health >= 60)
                        {
                            Console.WriteLine("🟢 상태: 좋음");
                        }
                        else if (health >= 40)
                        {
                            Console.WriteLine("🟡 상태: 보통");
                        }
                        else if (health >= 20)
                        {
                            Console.WriteLine("🟠 상태: 위험");
                        }
                        else
                        {
                            Console.WriteLine("🔴 상태: 매우 위험!");
                        }
            */
            #endregion

            #region 캐릭터 직업 선택
            /*
                        Console.WriteLine("=== 캐릭터 생성 ===\n");
                        Console.WriteLine("1: 전사 / 2:마법사 / 3:궁수 / 4:도적");
                        Console.Write("직업을 선택해주세요 : ");
                        int classChoice = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        switch (classChoice)
                        {
                            case 1:
                                Console.WriteLine("직업: ⚔️ 전사");
                                Console.WriteLine("특성: 높은 체력과 방어력");
                                Console.WriteLine("주 무기: 검, 도끼");
                                Console.WriteLine("스탯: HP +50, 공격력 +10");
                                break;

                            case 2:
                                Console.WriteLine("직업: 🔮 마법사");
                                Console.WriteLine("특성: 강력한 마법 공격");
                                Console.WriteLine("주 무기: 지팡이, 마법서");
                                Console.WriteLine("스탯: 마나 +100, 마법력 +20");
                                break;

                            case 3:
                                Console.WriteLine("직업: 🏹 궁수");
                                Console.WriteLine("특성: 원거리 공격 특화");
                                Console.WriteLine("주 무기: 활, 석궁");
                                Console.WriteLine("스탯: 민첩 +15, 크리티컬 +10%");
                                break;

                            case 4:
                                Console.WriteLine("직업: 🗡️ 도적");
                                Console.WriteLine("특성: 빠른 속도와 치명타");
                                Console.WriteLine("주 무기: 단검, 쌍검");
                                Console.WriteLine("스탯: 민첩 +20, 회피율 +15%");
                                break;

                            default:
                                Console.WriteLine("❌ 잘못된 선택입니다.");
                                Console.WriteLine("1~4 중에서 선택해주세요.");
                                break;
                        }
            */
            #endregion

            #region 반복문 예시
            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("천마연산신공");
            }*/
            #endregion

            #region 몬스터 웨이브
            /*
                        int enemyWaves = 0;

                        Console.WriteLine("=== 몬스터 웨이브 시작 ===");

                        for (int i = 1; i <= 5; i++)
                        {
                            Console.WriteLine($"👹 고블린 #{i} 생성!");
                            ++enemyWaves;
                        }
                        Console.WriteLine($"총 {enemyWaves}마리 생성 완료");
            */
            #endregion

            #region 게임 시작 카운트 다운
            /*
                        Console.WriteLine("=== 게임 시작 카운트 다운 ===");

                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine($"{i}...");
                            Thread.Sleep(500);
                        }
                        Console.WriteLine("🎮 게임 시작!");
            */
            #endregion

            #region 무기 뽑기
            /*
                        string sword = "무한의 대검";

                        Console.WriteLine("당신은 20번뽑기가 가능합니다. 지금 실행합니다.");

                        Random rand = new Random();

                        int random = 0;

                        for (int i = 0; i < 20; i++)
                        {
                            random = rand.Next(1, 101);

                            if (random >= 1 && random <= 10)
                            {
                                sword = " 무한의 대검";
                            }
                            else if (random >= 11 && random <= 30)
                            {
                                sword = "카타나";
                            }
                            else if (random >= 31 && random <= 60)
                            {
                                sword = "엑스칼리버";
                            }
                            else if (random >= 61 && random <= 100)
                            {
                                sword = "정기점검";
                            }

                            Console.WriteLine(sword);
                            Thread.Sleep(500);
                        }
            */
            #endregion

            #region Q1 온도에 따른 옷차림 추천
            // 오늘의 온도를 입력받아 적절한 옷차림을 추천하는 프로그램
            /*
                        Console.Write("현재 온도 : ");
                        int currentTemp = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (currentTemp >= 30)
                        {
                            Console.WriteLine("매우 더워요! 반팔과 반바지를 입으세요.");
                        }

                        else if (currentTemp >= 20)
                        {
                            Console.WriteLine("적당해요! 긴팔 티셔츠를 입으세요.");
                        }

                        else if (currentTemp >= 10)
                        {
                            Console.WriteLine("쌀쌀해요! 가디건이나 자켓을 챙기세요.");
                        }

                        else if (currentTemp >= 0)
                        {
                            Console.WriteLine("추워요! 코틀를 입으세요.");
                        }

                        else
                        {
                            Console.WriteLine("매우 추워요! 패딩과 목도리가 필요해요.");
                        }
            */
            #endregion

            #region Q2 게임 캐릭터 직업 선택
            // 사용자가 선택한 번호에 따라 게임 캐릭터의 직업 정보를 출력하는 프로그램

            Console.WriteLine("=== 캐릭터 생성 ===\n");
            Console.WriteLine("1: 전사 / 2:마법사 / 3:궁수 / 4:도적");
            Console.Write("직업을 선택해주세요 : ");
            int classChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (classChoice)
            {
                case 1:
                    Console.WriteLine("직업: ⚔️ 전사");
                    Console.WriteLine("특성: 높은 체력과 방어력");
                    Console.WriteLine("주 무기: 검, 도끼");
                    Console.WriteLine("시작 스탯: HP +50, 공격력 +10");
                    break;

                case 2:
                    Console.WriteLine("직업: 🔮 마법사");
                    Console.WriteLine("특성: 강력한 마법 공격");
                    Console.WriteLine("주 무기: 지팡이, 마법서");
                    Console.WriteLine("시작 스탯: 마나 +100, 마법력 +20");
                    break;

                case 3:
                    Console.WriteLine("직업: 🏹 궁수");
                    Console.WriteLine("특성: 원거리 공격 특화");
                    Console.WriteLine("주 무기: 활, 석궁");
                    Console.WriteLine("시작 스탯: 민첩 +15, 크리티컬 +10%");
                    break;

                case 4:
                    Console.WriteLine("직업: 🗡️ 도적");
                    Console.WriteLine("특성: 빠른 속도와 치명타");
                    Console.WriteLine("주 무기: 단검, 쌍검");
                    Console.WriteLine("시작 스탯: 민첩 +20, 회피율 +15%");
                    break;

                default:
                    Console.WriteLine("❌ 잘못된 선택입니다.");
                    Console.WriteLine("1~4 중에서 선택해주세요.");
                    break;
            }


            #endregion
        }
    }
}