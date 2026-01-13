using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            /*
                        for (int i = 1; i<=3; i++)
                        {
                            for(int j = 1; j<=3;  j++)
                            {
                                Console.WriteLine($"i:{i} j:{j}");
                            }
                            Console.WriteLine();
                        }
            */
            #region 예제 1: 사각형 그리기
            /*
                        for (int i = 1; i <= 3; i++)
                        {
                            for (int j = 1; j <= 3; j++)
                            {
                                Console.Write("⬜");
                            }
                            Console.WriteLine();
                        }
            */
            #endregion

            #region 예제 3: 좌표 찍기
            /*
                        for (int y = 0; y < 3; y++)
                        {
                            for (int x = 0; x < 3; x++) 
                            {
                                Console.Write($"({x}, {y})");

                            }
                            Console.WriteLine();
                        }
            */
            #endregion

            #region 예제 6: 곱셈표
            /*
                        for (int x = 1;  x <= 3; x++)
                        {
                            for (int y = 1; y <= 3; y++)
                            {
                                Console.Write($"{x} x {y} = {x * y}");
                            }
                            Console.WriteLine();
                        }

            */
            #endregion

            #region 예제 9: 미니 게임 맵
/*
            Console.WriteLine("\n=== 예제 9: 미니 게임 맵 ===");

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (x == 0 && y == 0)
                        Console.Write("🏠 ");  // 시작점
                    else if (x == 3 && y == 3)
                        Console.Write("🎯 ");  // 목표
                    else
                        Console.Write("🟩 ");  // 길
                }
                Console.WriteLine();
            }
*/
            #endregion


        }
    }
}
