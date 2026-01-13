using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Attack(string skillName, string target, int damage)
        {
            Console.WriteLine($"✨ 스킬 발동: {skillName}");
            Console.WriteLine($"⚔️ {target}에게 {damage} 데미지!");
        }

        // 데미지를 생략한 버전
        static void Attack(string skillName, string target)
        {
            Console.WriteLine($"✨ 스킬 발동: {skillName}");
            Console.WriteLine($"⚔️ {target}에게 기본 공격!");
        }

        // 대상 없이 쓰는 광역기
        static void Attack(string skillName, int damage)
        {
            Console.WriteLine($"✨ 스킬 발동: {skillName}");
            Console.WriteLine($"💥 전체에게 {damage} 데미지!");
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Attack("아이언헤드", "몬스터", 120);
            Attack("지진", 90);
            Attack("발버둥", "몬스터");
        }
    }
}
