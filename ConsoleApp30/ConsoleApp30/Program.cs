using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    public abstract class Character
    {
        public int hp;

        public abstract void Job();
    }

    public class Mage : Character
    {
        public override void Job()
        {
            Console.WriteLine("직업 마법사");
        }
    }

    public class Archer : Character
    {
        public override void Job()
        {
            Console.WriteLine("아처선택");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Character[] ch = new Character[2]; //배열준비

            ch[0] = new Mage();
            ch[1] = new Archer();


            //수집형알피지 캐릭터 두개 뽑았다.
            //그룹화 해서 출력하기 좋음
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i].Job();
            }

        }
    }
}
