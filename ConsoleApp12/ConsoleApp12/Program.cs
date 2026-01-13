using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); //콘솔 창 크기 설정 (가능 80, 세로 25)
            Console.SetBufferSize(80, 25); //버퍼 크기도 동일하게 설정 (스크롤 방지)

            int x = 10, y = 10;

            ConsoleKeyInfo keyInfo; //키관련된 정보

            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();  //화면지우기

                Console.SetCursorPosition(x, y); //좌표

                Console.Write("●"); //현재 위치 출력

                keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 x)

                //방향키 입력에 따른 좌표 변경
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (y > 0) y--; break;
                    case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
                    case ConsoleKey.LeftArrow: if (x > 0) x--; break;
                    case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
                    case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                    case ConsoleKey.Escape: break; //ESC키로 탈출

                }


            }

        }
    }
}
