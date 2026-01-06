using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260106_Q1
{
    internal class program5
    {
        public static void Run()
        {
            /*문제 5
            아이템의 원가가 5000골드입니다.
            VIP 회원이면 20% 할인
            쿠폰을 사용하면 추가로 500골드 할인

            VIP 회원이고 쿠폰이 있을 때의 최종 가격을 계산하세요.

            // 할인율 계산: 가격 * 0.8
            // 쿠폰 할인: 가격 - 500

            */


            /* 예상 출력
            원가: 5000골드
            VIP 할인 (20%): 4000골드
            쿠폰 할인 (-500): 3500골드
            최종 가격: 3500골드
            */

            int originalPrice = 5000;
            bool isVIP = true;
            bool hasCoupon = true;

            int finalPrice = originalPrice;

            Console.WriteLine("=== 가격 계산 === \n");
            Console.WriteLine($"원가: {originalPrice}골드");

            if (isVIP)
            {
                finalPrice = finalPrice * 80 / 100;
                Console.WriteLine($"VIP 할인 (20%): {finalPrice}골드");
            }

            if (hasCoupon)
            {
                finalPrice -= 500;
                Console.WriteLine($"쿠폰 할인 (-500): {finalPrice}골드");
            }

            Console.WriteLine($"최종 가격: {finalPrice}골드");

        }
    }
}
