using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            Console.WriteLine("Choose your battle name!");
            string yourName = Console.ReadLine();

            //All HP
            int playerHP = randomizer.Next(15, 60);
            int enemyHP = randomizer.Next(10, 45);

            // All Damage
            int playerDamage;
            int enemyDamage;

            string[] enemyNames=
            {
                "Boddy",
                "kää",
                "boi",
                "Niklas",
                "Leif GW",
                "Samson",
                "Rick",
                "Mr.Meeseeks",
                "Putte"
            };
            string enemyName =
               enemyNames[randomizer.Next(0, enemyNames.Length)];
            while (enemyHP > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(yourName + ":\nHealth: " + playerHP + "\n\n");
                Thread.Sleep(700);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("VS\n");
                Thread.Sleep(700);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(enemyName + "\nHealth: " + enemyHP + "\n");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(700);
                Console.WriteLine("\n1:Attack!\n2:Heal up!\n");
                if (playerHP < 7)
                {

                }
                string val1 = Console.ReadLine();
                if (val1 == "1")
                {
                    Console.Clear();
                    playerDamage = randomizer.Next(2, 10);
                    if (playerHP <7)
                    {
                        playerDamage = playerDamage + 5;
                        Console.WriteLine("You are low on healt!\n You now have attack boost!");
                        Thread.Sleep(1500);
                    }
                    enemyHP = enemyHP - playerDamage;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You attacked!");
                    Console.WriteLine("-" + playerDamage);
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(600);
                    Console.Clear();
                    Thread.Sleep(600);
                    Console.WriteLine("Enemy turn!");
                    Thread.Sleep(600);
                    Console.Clear();
                    if (enemyHP < 0)
                    {
                        break;
                    }
                    else if (playerHP < 0)
                    {
                        break;
                    }
                }
                else if (val1 == "2")
                {
                    Console.Clear();
                    playerHP = playerHP + 5;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("+5");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Enemy turn!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    if (enemyHP < 1)
                    {
                        break;
                    }
                }
                if (playerHP < 1)
                {
                    break;
                }
                enemyDamage = randomizer.Next(2, 10);
                playerHP = playerHP - enemyDamage;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enemy attacked you!\n" + "-" + enemyDamage);
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                if (playerHP < 1)
                {
                    break;
                }


            }

            if (playerHP > 0)
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("YOU WIN!!");
                }
            }
            else
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("YOU LOSE");
                }
            }
        }
    }
}

