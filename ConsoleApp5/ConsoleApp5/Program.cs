using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 문자열 입출력
            //Console.WriteLine("이름을 입력하세요 : ");
            //string userName = Console.ReadLine();
            //Console.WriteLine($"안녕하세요, {userName}님!");

            // 정수형 입출력
            //Console.WriteLine("나이를 입력하세요: ");
            //string input = Console.ReadLine(); //사용자로부터 입력 받기
            //int age = int.Parse(input); //문자열을 정수로 변환
            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");

            //// 2진수를 정수로 변환
            //Console.WriteLine("2진수 입력하세요.");
            //string binaryInput = Console.ReadLine();
            //int decimaValue = Convert.ToInt32(binaryInput, 2);
            //Console.WriteLine($"입력한 이진수 : {binaryInput}");
            //Console.WriteLine($"10진수로 변환 : {decimaValue}");

            //// 정수를 이진수로 변환
            //string binaryOutput = Convert.ToString(decimaValue, 2);
            //Console.WriteLine($"이진수로 변환 : {binaryOutput}");


            //// 미션
            //Console.WriteLine("=== 캐릭터 생성 ===");
            //Console.Write("캐릭터 이름을 입력하세요 : ");
            //string charaName = Console.ReadLine();
            //Console.WriteLine($"안녕하세요, {charaName}님!");

            //Console.Write("시작 레벨을 입력하세요: ");
            //string input = Console.ReadLine();
            //int charaLv = int.Parse(input);
            //Console.WriteLine($"{charaName}님의 시작 레벨은 {charaLv}입니다.");

            // var를 사용한 변수 선언
            //var name = "Alice";
            //var age = 25;
            //var isStudent = true;

            //Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생여부 : {isStudent}");

            // 문자열을 숫자열로 변환
            string scoreText = "95";
            int score = int.Parse(scoreText); //문자열 -> 정수

            string priceText = "19.99";
            double price = double.Parse(priceText);  //문자열 -> 실수

            Console.WriteLine("\n=== 문자열 변환 ===");
            Console.WriteLine($"점수(문자열) : {scoreText} -> 숫자: {score}");
            Console.WriteLine($"가격(문자열) : {priceText} -> 숫자: {price}");

            // 숫자를 문자열로 변환
            int playerLevel = 50;
            string levelText = playerLevel.ToString();

            Console.WriteLine("==== 숫자를 문자열로");
            Console.WriteLine($"레벨(숫자): {playerLevel} -> 문자열 : {levelText}");

        }

    }
}
