using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // 유니코드


            #region 좌석 배치도
            /*
                        string[,] numbers = new string[3, 3]
                        {
                            { "[A1]", "[A2]", "[A3]" },
                            { "[B1]", "[B2]", "[B3]" },
                            { "[C1]", "[C2]", "[C3]" },
                        };

                        Console.WriteLine(" === 좌석 배치도 ===");

                        for (int i = 0; i < 3; i++)      // 행
                        {
                            for (int j = 0; j < 3; j++)  // 열
                            {
                                Console.Write(numbers[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
            */
            #endregion

            //2D 게임맵
            /*
                        int[,] map = new int[5, 5]
                        {
                          { 0,0,1,0,0},
                          { 0,2,1,0,3},
                          { 0,0,1,0,0},
                          { 1,1,1,0,0},
                          { 0,0,0,0,9},
                        };

                        Console.WriteLine("==던전맵==");
                        Console.WriteLine("0: 통로 1: 벽 2: 몬스터 3: 보물 9: 출구\n");
                        Console.OutputEncoding = Encoding.UTF8;

                        //맵 출력
                        for (int y = 0; y < map.GetLength(0); y++)
                        {
                            for (int x = 0; x < map.GetLength(1); x++)
                            {
                                switch (map[y, x])
                                {
                                    case 0:
                                        Console.Write("⬜ ");
                                        break;
                                    case 1:
                                        Console.Write("⬛ ");
                                        break;
                                    case 2:
                                        Console.Write("👹 ");
                                        break;
                                    case 3:
                                        Console.Write("💎 ");
                                        break;
                                    case 9:
                                        Console.Write("🚪 ");
                                        break;
                                }

                            }
                            Console.WriteLine();
                        }
            */


            #region 💻 예제: 성적표 만들기


            // 학생 3명, 과목 4개 (국어, 영어, 수학, 과학)
            int[,] scores = new int[3, 4]
            {
            { 85, 90, 88, 92 },  // 학생 1
            { 78, 85, 90, 87 },  // 학생 2
            { 92, 88, 95, 90 }   // 학생 3
            };

            string[] students = { "김철수", "이영희", "박민수" };
            string[] subjects = { "국어", "영어", "수학", "과학" };

            Console.WriteLine("=== 성적표 ===\n");

            // 헤더 출력
            Console.Write("이름\t");
            foreach (string subject in subjects)
            {
                Console.Write($"{subject}\t");
            }
            Console.WriteLine("평균");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            // 학생별 성적 출력
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                Console.Write($"{students[i]}\t");

                int sum = 0;
                for (int j = 0; j < scores.GetLength(1); j++)
                {
                    Console.Write($"{scores[i, j]}\t");
                    sum += scores[i, j];
                }

                double average = (double)sum / scores.GetLength(1);
                Console.WriteLine($"{average:F1}");
            }

            // 과목별 평균
            Console.WriteLine("\n=== 과목별 평균 ===");
            for (int subject = 0; subject < scores.GetLength(1); subject++)
            {
                int sum = 0;
                for (int student = 0; student < scores.GetLength(0); student++)
                {
                    sum += scores[student, subject];
                }
                double avg = (double)sum / scores.GetLength(0);
                Console.WriteLine($"{subjects[subject]}: {avg:F1}점");
            }

            #endregion
        }
    }
}
