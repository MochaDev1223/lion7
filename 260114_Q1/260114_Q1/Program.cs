using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260114_Q1
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    class Lion : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("🦁 사자: 어흥!");
        }

    }
        class Dog : Animal 
    {
        public override void Speak()
        {
            Console.WriteLine("🐰 토끼: 깡총!");
        }
    }

    class Rabbit : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("🐰 토끼: 깡총!");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // 유니코드

            List<Animal> zoo = new List<Animal>();

            zoo.Add(new Lion());
            zoo.Add(new Dog());
            zoo.Add(new Rabbit());



            Console.WriteLine("=== 동물원 소리 듣기 ===");

            foreach (Animal animal in zoo)
            {
                animal.Speak();   // 같은 메서드, 다른 동작
            }
        }
    }
}
