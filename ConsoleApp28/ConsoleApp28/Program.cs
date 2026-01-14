using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{

    // 부모클래스 : 기본 캐릭터
    class Character
    {
        // public, private, protected // 상속이 되어있는 자식이 사용 가능
        protected string name;
        protected int level;
        protected int hp;
        protected int maxHP;
        protected int attack;
        protected int defense;

        public Character(string characterName)
        {
            name = characterName;
            //name = "기본 캐릭터";
            level = 1;
            maxHP = 100;
            hp = maxHP;
            attack = 30;
            defense = 20;

            Console.WriteLine($"캐릭터 {name} 생성!");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"HP : {hp} / {maxHP}");
            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"방어력 : {defense}");
        }

    }

    class Warrior : Character
    {
        private int rage; // 전사 고유 속성

        public Warrior(string name) : base(name)
        {
            //name = _name;
            //name = "서승태";
            attack = 30;
            defense = 20;
            maxHP = 150;
            hp = maxHP;
            rage = 0;

            Console.WriteLine("직업 : 전사");
        }

        public void ShowInfo2()
        {
            base.ShowInfo();
            Console.WriteLine($"분노 : {rage}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("서승태");

            warrior.ShowInfo2();

        }
    }
}
