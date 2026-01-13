using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 10부터 1까지 카운트다운
            /*
                        int countDown = 10;

                        while (countDown > 0)
                        {
                            Console.WriteLine(countDown);
                            countDown--;
                        }
            */
            #endregion

            /*// 합계 구하기

            int sum = 0;
            int a = 1;

            while (a <= 5)
            {
                sum += a;
                Console.WriteLine(sum);
                
                a++;
            }*/

            /* int coin = 0;
             int target = 50;
             int day = 0;

             while (coin < target)
             {
                 day++;
                 coin = 10 * day;
                 Console.WriteLine($"{day}일차 : 코인 {coin}개");
             }

             Console.WriteLine($"목표 달성! {day}일 걸렸습니다.");*/

            /*
                        string choice;
                        int totalPrice = 0;

                        do
                        {
                            //메뉴출력
                            Console.WriteLine("메뉴판");
                            Console.WriteLine("1. 짜장면 - 5,000원");
                            Console.WriteLine("2. 짬뽕 - 6,000원");
                            Console.WriteLine("3. 탕수육 - 15,000원");
                            Console.WriteLine("4. 볶음밥 - 7,000원");
                            Console.WriteLine("0. 주문 완료");
                            Console.WriteLine("=========================");
                            Console.Write("메뉴 번호를 선택하세요: ");

                            choice = Console.ReadLine();

                            //메뉴 선택 처리
                            switch (choice)
                            {
                                case "1":
                                    Console.WriteLine("짜장면 추가! (+5,000원)");
                                    totalPrice += 5000;
                                    break;
                                case "2":
                                    Console.WriteLine("짜장면 추가! (+6,000원)");
                                    totalPrice += 6000;
                                    break;
                                case "3":
                                    Console.WriteLine("짜장면 추가! (+15,000원)");
                                    totalPrice += 15000;
                                    break;
                                case "4":
                                    Console.WriteLine("짜장면 추가! (+7,000원)");
                                    totalPrice += 7000;
                                    break;
                                case "0":
                                    Console.WriteLine("주문을 완료합니다.");
                                    break;
                                default:
                                    Console.WriteLine("잘못된 선택입니다.");
                                    break;
                            }

                            //0번 선택 전까지
                            if (choice != "0")
                            {
                                Console.WriteLine($"현재 총액: {totalPrice:N0}원");
                            }



                        } while (choice != "0"); //0을 입력할 때까지 반복
            */
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)

                    continue;
                    //break;

                Console.WriteLine(i);
            }
        }
    }
}
