using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Character
    {
        public string name;
        public int level;
        public int hp;
        public int maxHp;
        public int mp;
        public int maxMp;

        // 메서드 (Method): 클래스의 기능
        public void ShowInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"HP: {hp}/{maxHp}");
            Console.WriteLine($"MP: {mp}/{maxMp}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        }

        public void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp < 0) hp = 0;

            Console.WriteLine($"⚔️ {name}이(가) {damage} 데미지를 받았습니다!");
            Console.WriteLine($"   남은 HP: {hp}/{maxHp}");
        }

        public void Heal(int amount)
        {
            hp += amount;
            hp += amount;
            if (hp > maxHp) hp = maxHp;

            Console.WriteLine($"💚 {name}의 HP가 {amount} 회복되었습니다!");
            Console.WriteLine($"   현재 HP: {hp}/{maxHp}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Character player1 = new Character();

            player1.name = "홍길동";
            player1.level = 1;
            player1.hp = 100;
            player1.maxHp = 150;
            player1.mp = 80;
            player1.maxMp = 100;

            //Console.WriteLine("이름 : " + player1.name);
            //Console.WriteLine("레벨 : " + player1.level);
            //Console.WriteLine("hp : " + player1.hp);
            //Console.WriteLine("maxHp : " + player1.maxHp);
            //Console.WriteLine("mp : " + player1.mp);
            //Console.WriteLine("maxMp : " + player1.maxMp);
            //Console.WriteLine();

            player1.ShowInfo();

            Character player2 = new Character();

            player2.name = "김철수";
            player2.level = 3;
            player2.hp = 120;
            player2.maxHp = 170;
            player2.mp = 100;
            player2.maxMp = 130;

            player2.ShowInfo();

            //Console.WriteLine("이름 : " + player2.name);
            //Console.WriteLine("레벨 : " + player2.level);
            //Console.WriteLine("hp : " + player2.hp);
            //Console.WriteLine("maxHp : " + player2.maxHp);
            //Console.WriteLine("mp : " + player2.mp);
            //Console.WriteLine("maxMp : " + player2.maxMp);
            //Console.WriteLine();

        }
    }
}
