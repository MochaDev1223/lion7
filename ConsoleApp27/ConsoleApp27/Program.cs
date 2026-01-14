using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }

    class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //c언어 함수 가져옴

        public int playerX;
        public int playerY;

        // 20개 먼저 생성 후 준비된 미사일을 활용
        public BULLET[] playerBullet = new BULLET[20];
        public BULLET[] playerBullet2 = new BULLET[20];
        public BULLET[] playerBullet3 = new BULLET[20];
        public int Score = 100;

        // 아이템
        public Item item = new Item();
        public int itemCount = 0;


        public Player()
        {
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++)
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new BULLET();
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new BULLET();
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;
            }

        }

        public void GameMain()
        {
            KeyControl();
            PlayerDraw(); ;
            UIscore();

            if (item.ItemLife)
            {
                //item.ItemMove();
                item.ItemDraw();

                // 아이템 충돌
                CrashItem();

            }

        }


        // 아이템 충돌이 일어나면 양쪽 미사일 발사
        public void CrashItem()
        {
            if (playerY+1 == item.itemY)
            {
                if(playerX >= item.itemX - 2 && playerX <= item.itemX + 2)
                {
                    item.ItemLife = false;

                    if (itemCount < 3)
                    {
                        itemCount++;

                        for (int i = 0; i < 20; i++)
                        {
                            playerBullet[i] = new BULLET();
                            playerBullet[i].x = 0;
                            playerBullet[i].y = 0;
                            playerBullet[i].fire = false;

                            playerBullet2[i] = new BULLET();
                            playerBullet2[i].x = 0;
                            playerBullet2[i].y = 0;
                            playerBullet2[i].fire = false;

                            playerBullet3[i] = new BULLET();
                            playerBullet3[i].x = 0;
                            playerBullet3[i].y = 0;
                            playerBullet3[i].fire = false;
                        }
                    }
                }
            }
        }


        public void KeyControl()
        {
            int pressKey;

            if (Console.KeyAvailable)
            {
                pressKey = _getch();

                if (pressKey == 224 || pressKey == 0)
                {
                    pressKey = _getch(); // 실제 키 값 다시 받기
                }

                switch (pressKey)
                {
                    case 72: // 위쪽 아스키코드
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;

                        break;
                    case 75: // 왼쪽
                        playerX--;
                        if (playerX < 1)
                            playerX = 1;

                        break;
                    case 77: // 오른쪽
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;

                    case 80:
                        playerY++;
                        if (playerY > 21)
                            playerY = 21;
                        break;

                    case 32: // 스페이스바
                        for (int i = 0; i < 20; i++)
                        {
                            // 미사일이 false 발사가능
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;
                                // 플레이어 좌표에서 쏘기 +5 / +1
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1;
                                break;
                            }
                        }

                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerBullet2[i].fire == false)
                            {
                                playerBullet2[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerBullet2[i].x = playerX + 5;
                                playerBullet2[i].y = playerY;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }

                        //총알3 발사
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerBullet3[i].fire == false)
                            {
                                playerBullet3[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerBullet3[i].x = playerX + 5;
                                playerBullet3[i].y = playerY + 2;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        break;
                }
            }
        }

        public void BulletDraw()
        {
            string bullet = "->"; // 미사일 모습

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    // 좌표 설정 , 중간 위치를 위해 보정
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);
                    // 총알 출력
                    Console.Write(bullet);

                    playerBullet[i].x++; // 미사일이 오른쪽으로 날아감

                    if (playerBullet[i].x > 78)
                    {
                        playerBullet[i].fire = false; // 미사일 false 다시 준비
                    }

                }
            }
        }

        public void BulletDraw2()
        {
            string bullet = "->"; //미사일모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet2[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet2[i].x - 1, playerBullet2[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet2[i].x++; //미사일 오른쪽으로 날라가기

                    if (playerBullet2[i].x > 78)
                    {
                        playerBullet2[i].fire = false;  //미사일 false 다시 준비상태
                    }
                }
            }
        }

        public void BulletDraw3()
        {
            string bullet = "->"; //미사일모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet3[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet3[i].x - 1, playerBullet3[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet3[i].x++; //미사일 오른쪽으로 날라가기

                    if (playerBullet3[i].x > 78)
                    {
                        playerBullet3[i].fire = false;  //미사일 false 다시 준비상태
                    }
                }
            }
        }

        public void PlayerDraw()
        {
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; // 배열 문자열로 그리기

            for (int i = 0; i < player.Length; i++)
            {
                Console.SetCursorPosition(playerX, playerY + i);
                Console.WriteLine(player[i]);
            }
        }

        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        // 충돌처리
        public void ClashEnemyAndBullet(Enemy enemy)
        {
            for (int i = 0; i < 20; i++)
            {
                // 살아있는 미사일
                if (playerBullet[i].fire == true)
                {
                    // 미사일과 적의 y값이 같을 때
                    if (playerBullet[i].y == enemy.enemyY)
                    {
                        if (playerBullet[i].x >= (enemy.enemyX - 1) 
                            && playerBullet[i].x <= (enemy.enemyX + 1))
                        {
                            //아이템
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            // 충돌
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet[i].fire = false;

                            Score += 100;

                        }
                    }
                }
            }

            //미사일2 20
            for (int i = 0; i < 20; i++)
            {
                //살아있는 미사일
                if (playerBullet2[i].fire == true)
                {
                    //미사일과 적의 y값이 같을때 
                    if (playerBullet2[i].y == enemy.enemyY)
                    {
                        if (playerBullet2[i].x >= (enemy.enemyX - 1)
                            && playerBullet2[i].x <= (enemy.enemyX + 1)) //충돌
                        {
                            //충돌

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet2[i].fire = false; //미사일도 준비상태로 만들어주기

                            //스코어
                            Score += 100;

                        }
                    }

                }
            }
            //미사일3 20
            for (int i = 0; i < 20; i++)
            {
                //살아있는 미사일
                if (playerBullet3[i].fire == true)
                {
                    //미사일과 적의 y값이 같을때 
                    if (playerBullet3[i].y == enemy.enemyY)
                    {
                        if (playerBullet3[i].x >= (enemy.enemyX - 1)
                            && playerBullet3[i].x <= (enemy.enemyX + 1)) //충돌
                        {
                            //충돌

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet3[i].fire = false; //미사일도 준비상태로 만들어주기

                            //스코어
                            Score += 100;

                        }
                    }

                }
            }


        }

    }

    public class Enemy
    {
        public int enemyX;
        public int enemyY;

        public Enemy()
        {
            enemyX = 77;
            enemyY = 12;
        }

        public void EnemyDraw()
        {
            string enemy = "<-0->";
            Console.SetCursorPosition(enemyX, enemyY);
            Console.Write(enemy); // 출력
        }

        public void EnemyMove()
        {
            Random rand = new Random();
            enemyX--;
            
            if(enemyX < 2) // 화면 왼쪽 넘어가면 새로 좌표
            {
                enemyX = 75;
                enemyY = rand.Next(2, 22); // Y 좌표 랜덤
            }

        }

    }

    // 아이템 클래스
    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "Item★";
            Console.Write(ItemSprite);
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            // 플레이어, 적 생성
            Player player = new Player();
            Enemy enemy = new Enemy();

            // 콘솔 속도 만들기 frame , 60fps

            int dwTime = Environment.TickCount; // 1/1000초가 흐름

            while(true)
            {
                // 0.05초 지연
                if (dwTime + 50 < Environment.TickCount)
                {
                    // 현재 시간
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    // 플레이어
                    player.GameMain();

                    // 총알
                    if (player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if (player.itemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }

                    // 적
                    enemy.EnemyDraw();
                    enemy.EnemyMove();

                    // 충돌 처리
                    player.ClashEnemyAndBullet(enemy);

                }
            }


        }
    }
}

