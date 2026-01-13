using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;

            int playerX = 40, playerY = 12;
            int score = 0;
            int level = 1;
            int timeLimit = 30; // 30초 제한

            Random rand = new Random();

            // 사과와 폭탄 위치 저장
            List<int> appleX = new List<int>();
            List<int> appleY = new List<int>();
            int bombX = -1, bombY = -1;

            DateTime startTime = DateTime.Now;

            // 초기 사과 3개 생성
            for (int i = 0; i < 3; i++)
            {
                appleX.Add(rand.Next(5, 75));
                appleY.Add(rand.Next(3, 22));
            }

            int oldPlayerX = playerX, oldPlayerY = playerY;
            bool needRedraw = true;

            while (true)
            {
                // 남은 시간 계산
                int elapsedSeconds = (int)(DateTime.Now - startTime).TotalSeconds;
                int remainingTime = timeLimit - elapsedSeconds;

                // 시간 초과 체크
                if (remainingTime <= 0)
                {
                    Console.Clear();
                    Console.SetCursorPosition(30, 10);
                    Console.WriteLine("게임 오버!");
                    Console.SetCursorPosition(25, 12);
                    Console.WriteLine("최종 점수: " + score);
                    Console.SetCursorPosition(25, 14);
                    Console.WriteLine("아무 키나 눌러 종료...");
                    Console.ReadKey();
                    break;
                }

                // 처음 또는 필요할 때만 전체 화면 그리기
                if (needRedraw)
                {
                    Console.Clear();

                    // 구분선
                    Console.SetCursorPosition(0, 1);
                    Console.Write(new string('─', 80));

                    // 사과들 출력
                    for (int i = 0; i < appleX.Count; i++)
                    {
                        Console.SetCursorPosition(appleX[i], appleY[i]);
                        Console.Write("🍎");
                    }

                    // 폭탄 출력
                    if (bombX != -1 && bombY != -1)
                    {
                        Console.SetCursorPosition(bombX, bombY);
                        Console.Write("💣");
                    }

                    // 하단 안내
                    Console.SetCursorPosition(2, 23);
                    Console.Write("방향키: 이동 | ESC: 종료");

                    needRedraw = false;
                }

                // 상단 정보만 업데이트
                Console.SetCursorPosition(2, 0);
                Console.Write("레벨: " + level + " ");
                Console.SetCursorPosition(15, 0);
                Console.Write("점수: " + score + "  ");
                Console.SetCursorPosition(30, 0);
                Console.Write("남은 시간: " + remainingTime + "초 ");
                Console.SetCursorPosition(50, 0);
                Console.Write("목표: " + (level * 50) + "점 ");

                // 이전 플레이어 위치 지우기
                Console.SetCursorPosition(oldPlayerX, oldPlayerY);
                Console.Write("  ");

                // 새 플레이어 위치 그리기
                Console.SetCursorPosition(playerX, playerY);
                Console.Write("😊");

                oldPlayerX = playerX;
                oldPlayerY = playerY;

                // 키 입력 (논블로킹)
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (playerY > 3) playerY--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (playerY < 22) playerY++;
                            break;
                        case ConsoleKey.LeftArrow:
                            if (playerX > 0) playerX--;
                            break;
                        case ConsoleKey.RightArrow:
                            if (playerX < 78) playerX++;
                            break;
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                    }
                }

                // 사과 먹기 체크
                for (int i = appleX.Count - 1; i >= 0; i--)
                {
                    if (playerX == appleX[i] && playerY == appleY[i])
                    {
                        score += 10;
                        appleX.RemoveAt(i);
                        appleY.RemoveAt(i);

                        // 새 사과 생성
                        appleX.Add(rand.Next(5, 75));
                        appleY.Add(rand.Next(3, 22));

                        needRedraw = true; // 화면 다시 그리기
                    }
                }

                // 폭탄과 충돌 체크
                if (playerX == bombX && playerY == bombY)
                {
                    score -= 20;
                    if (score < 0) score = 0;
                    bombX = -1;
                    bombY = -1;
                    needRedraw = true;
                }

                // 레벨업 체크
                if (score >= level * 50)
                {
                    level++;
                    timeLimit += 10;

                    // 사과 1개 추가
                    appleX.Add(rand.Next(5, 75));
                    appleY.Add(rand.Next(3, 22));

                    needRedraw = true;
                }

                // 폭탄 랜덤 생성 (2% 확률로 낮춤)
                if (bombX == -1 && rand.Next(1, 101) <= 2)
                {
                    bombX = rand.Next(5, 75);
                    bombY = rand.Next(3, 22);
                    needRedraw = true;
                }

                Thread.Sleep(50); // 0.05초로 더 빠르게
            }
        }
    }
}