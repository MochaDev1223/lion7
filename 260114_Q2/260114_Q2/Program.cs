using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260114_Q2
{
    class Shop
    {
        public string Name;
        public int Price;

        public virtual void UseEffect()
        {
            Console.WriteLine("아이템을 사용 시 효과");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"아이템: {Name}, 가격: {Price}골드");
            Console.WriteLine($"할인 후: {GetDiscountPrice()}골드");
        }

        public virtual int GetDiscountPrice()
        {
            return Price; // 기본은 할인 없음
        }

        public virtual string GetDiscountMessage()
        {
            return "";
        }

    }

    class Weapon : Shop 
    {
        public int attack;

        public override void UseEffect()
        {
            Console.WriteLine($"⚔ 무기 장착 시 공격력 +{attack}");
        }

        public override int GetDiscountPrice()
        {
            return (int)(Price * 0.8);
        }

        public override string GetDiscountMessage()
        {
            return "🔥 현재 무기류 20% 할인 중!";
        }

        
    }

    class Armor : Shop
    {
        public int defense;

        public override void UseEffect()
        {
            Console.WriteLine($"🛡 방어구 장착 시 방어력 +{defense}");
        }
        public override int GetDiscountPrice()
        {
            return (int)(Price * 0.9);
        }
        public override string GetDiscountMessage()
        {
            return "🔥 현재 방어구류 10% 할인 중!";
        }

    }

    class Potion : Shop
    {
        public int heal;

        public override void UseEffect()
        {
            Console.WriteLine($"💊 포션 사용 시 체력 {heal} 회복");
        }
        public override int GetDiscountPrice()
        {
            return (int)(Price * 0.7);
        }

        public override string GetDiscountMessage()
        {
            return "🔥 현재 포션류 30% 할인 중!";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // 유니코드

            List<Shop> shopItems = new List<Shop>();

            shopItems.Add(new Weapon { Name = "목검", Price = 100, attack = 10 });
            shopItems.Add(new Weapon { Name = "철검", Price = 200, attack = 25 });
            shopItems.Add(new Armor { Name = "가죽 갑옷", Price = 80, defense = 5 });
            shopItems.Add(new Armor { Name = "철 갑옷", Price = 150, defense = 10 });
            shopItems.Add(new Potion { Name = "초급 체력 포션", Price = 30, heal = 20 });
            shopItems.Add(new Potion { Name = "중급 체력 포션", Price = 50, heal = 50 });

            Console.WriteLine("=== 상점 아이템 목록 ===");

            bool weaponMsgShown = false;
            bool armorMsgShown = false;
            bool potionMsgShown = false;

            foreach (Shop item in shopItems)
            {
                // 타입별 할인 문구 한 번만 출력
                if (item is Weapon && !weaponMsgShown)
                {
                    Console.WriteLine(item.GetDiscountMessage());
                    weaponMsgShown = true;
                }
                else if (item is Armor && !armorMsgShown)
                {
                    Console.WriteLine(item.GetDiscountMessage());
                    armorMsgShown = true;
                }
                else if (item is Potion && !potionMsgShown)
                {
                    Console.WriteLine(item.GetDiscountMessage());
                    potionMsgShown = true;
                }

                item.ShowInfo();
                item.UseEffect();
                Console.WriteLine();
            }

        }
    }
}
