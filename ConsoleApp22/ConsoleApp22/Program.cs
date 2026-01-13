using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Character
    {
        private string name;
        private int level;
        private int hp;
        private int maxHP;
        private int mp;
        private int maxMP;

        // 이름 프로퍼티
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // 레벨 프로퍼티
        public int Level
        {
            get { return level; }
            set
            {
                if (value < 1) level = 1;   // 최소 레벨 제한 예시
                else level = value;
            }
        }

        public int HP
        {
            get { return hp; }
            set
            {
                hp = value;
                if (hp < 0) hp = 0;
                if (hp > maxHP) hp = maxHP;
            }
        }

        public int MaxHP
        {
            get { return maxHP; }
            set { maxHP = value; }
        }

        public int MP
        {
            get { return mp; }
            set
            {
                mp = value;
                if (mp < 0) mp = 0;
                if (mp > maxMP) mp = maxMP;
            }
        }

        public int MaxMP
        {
            get { return maxMP; }
            set { maxMP = value; }
        }
        public Character(string _name , int _level , int _hp,int _maxHP, int _mp, int _maxMP) { name = _name; level = _level; hp = _hp; maxHP = _maxHP; mp = _mp; maxMP = _maxMP; }

        public void ShowInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"MP: {mp}/{maxMP}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━ \n");
        }

        public void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp < 0) hp = 0;

            Console.WriteLine($"⚔️ {name}이(가) {damage} 데미지를 받았습니다!");
            Console.WriteLine($"   남은 HP: {hp}/{maxHP} \n");
        }

        public void Heal(int amount)
        {
            hp += amount;
            if (hp > maxHP) hp = maxHP;

            Console.WriteLine($"💚 {name}의 HP가 {amount} 회복되었습니다!");
            Console.WriteLine($"   현재 HP: {hp}/{maxHP} \n");
        }

    }

    class Monster
    {
        // 필드
        public string name;
        public int level;
        public int hp;
        public int attack;
        public int defense;
        public int expReward;

        public Monster()
        {
            // 기본 생성자
            name = "슬라임";
            level = 2;
            hp = 50;
            attack = 10;
            defense = 5;
            expReward = 10;
        }

        // 매개변수가 있는 생성자
        public Monster(string monsterName, int monsterLevel)
        {
            name = monsterName;
            level = monsterLevel;
            hp = 50 * level;
            attack = 10 * level;
            defense = 5 * level;
            expReward = 10 * level;
        }

        public void ShowStats()
        {
            Console.WriteLine($"👾 {name} (Lv.{level})");
            Console.WriteLine($"   HP: {hp}");
            Console.WriteLine($"   공격력: {attack}");
            Console.WriteLine($"   방어력: {defense}");
            Console.WriteLine($"   경험치: {expReward}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // 유니코드

            Character player1 = new Character("홍길동", 10, 150, 150, 80, 80);
            //player1.Name = "홍길동";
            //player1.Level = 10;
            //player1.HP = 150;
            //player1.MaxHP = 150;
            //player1.MP = 80;
            //player1.MaxMP = 80;
            player1.ShowInfo();

            player1.TakeDamage(50);

            player1.Heal(30);

            Character player2 = new Character("서승태", 27, 180, 200, 142, 175);
            //player2.Name = "서승태";
            //player2.Level = 27;
            //player2.HP = 180;
            //player2.MaxHP = 200;
            //player2.MP = 142;
            //player2.MaxMP = 175;
            
            player2.ShowInfo();

            player2.TakeDamage(40);

            player2.Heal(10);

            /////////////////////////////////////////////////

            Monster slime = new Monster();
            slime.ShowStats();

            Monster goblin = new Monster("고블린", 5);
            goblin.ShowStats();

            Console.WriteLine("=== 필드 몬스터 ===\n");
            Monster[] monsters = new Monster[3];
            monsters[0] = new Monster("늑대",3);
            monsters[1] = new Monster("오크",7);
            monsters[2] = new Monster("트롤",10);

            for (int i = 0; i < monsters.Length; i++)
            {
                monsters[i].ShowStats();
                Console.WriteLine();
            }

        }
    }
}
