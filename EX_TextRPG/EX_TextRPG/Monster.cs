using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_TextRPG
{
    public class Monster
    {
        public Info m_tMonster;

        // 데미지
        public void SetDamage(int iAttack) { m_tMonster.iHp -= iAttack; }

        // Info클래스 타입 입자로 몬스터 데이터 넣기
        public void SetMonster(Info tMonster) { m_tMonster = tMonster; }

        // 몬스터 정보를 외부에서 볼 수 있는 함수
        public Info GetMonster() { return m_tMonster; }

        public void Render()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("몬스터 이름 : " + m_tMonster.strName);
            Console.WriteLine("체력 : " + m_tMonster.iHp + "\t공격력 : " + m_tMonster.iAttack);
        }
        public Monster() { } //기본 생성자
        ~Monster() { } //소멸자

    }
}
