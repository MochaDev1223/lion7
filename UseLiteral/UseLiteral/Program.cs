using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseLiteral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health;
            health = 80;

            int maxHealth = 100;
            int damage = 15;

            Console.WriteLine("체력 : " + health + "/" + maxHealth);
            Console.WriteLine("데미지수치 " + damage);
        }
    }
}
