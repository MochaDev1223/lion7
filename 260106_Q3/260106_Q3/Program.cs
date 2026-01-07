using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260106_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //### 도전 문제 2: 시간 변환기
            // 게임 플레이 시간이 3725초일 때:
            //-몇 시간인가요 ?
            //-몇 분인가요 ?
            //-몇 초인가요 ?
            //(예: 1시간 2분 5초)

            int playTime = 3725;
            int hour = playTime / 3600;
            int remainSec = playTime % 3600;

            int min = remainSec / 60;
            int sec = remainSec % 60;

            Console.WriteLine($"{hour}시간 {min}분 {sec}초");

        }
    }
}
