using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 같은 데이터 타입 변수를 한번에 선언
            int x = 10, y = 20, z = 30;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            int age = 20;
            int level = 10;
            string name = "철수";
            //Console.WriteLine("나이 : {0}",age);
            //Console.WriteLine("나이 : " + age);

            //Console.WriteLine("이름 : {0}, 나이 : {1}", name, age);
            //Console.WriteLine("이름 : " + name + ", 나이 : " + age);

            //Console.WriteLine($"나이 : {age}, 레벨 : {level}");

            //3D 좌표 예시
            int posX = 0, posY = 50, posZ = 100;

            Console.WriteLine("X : {0}, Y : {1}, Z : {2}", posX, posY, posZ);
            Console.WriteLine("X : " + posX + ", Y : " + posY + ", Z : "+ posZ);
            Console.WriteLine($"X : {posX}, Y : {posY}, Z : {posZ}");

            // $" " 안에서 {변수} 사용하는 방식으로 출력

            //RGB 색상 예시 
            int red = 255, green = 128, blue = 0;

            Console.WriteLine("Red : {0}, Green : {1}, Blue : {2}", red, green, blue);
            Console.WriteLine("Red : " + red + ", Green : " + green + ", Blue : " + blue);
            Console.WriteLine($"Red : {red}, Green : {green}, Blue : {blue}");
        }
    }
}
