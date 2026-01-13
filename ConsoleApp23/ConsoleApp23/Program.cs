using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Player
    {
        private string name;
        private int gold;
        private int maxHP;

        //프로퍼티
        public string Name { get { return name; } set { name = value; } }
        public int Gold
        {
            get { return gold; }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("골드가 부족합니다.");
                }
                else
                {
                    gold = value;
                }
            }
        }

        // 읽기 전용 프로퍼티
        public int MaxHP
        {
            get { return maxHP; }
            private set { maxHP = value; }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Player player = new Player();
                player.Name = "서승태";
                player.Gold = 1000;
                //player.MaxHP = 1000; 읽기 전용이라 외부에서 값 변경 불가

                Console.WriteLine($"이름 : {player.Name}");
                Console.WriteLine($"골드 : {player.Gold}G");

            }
        }
    }
