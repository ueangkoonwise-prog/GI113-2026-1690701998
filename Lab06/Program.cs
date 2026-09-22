using System.Runtime.CompilerServices;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int live = 0;
            ////if (live <= 0)
            ////{
            //    Console.WriteLine("Game Over");
            //}
            //Console.WriteLine("Continuos code");

            //int level = 7;
            //if (level >= 5)
            //{
            //    Console.WriteLine("The door opens.");
            //}
            //else
            //{
            //    Console.WriteLine("the door stays shut.");
            //}
            //Console.Write("Your level {1-99}| ");
            //bool inputLevel = int.TryParse(Console.ReadLine(), out int level);

            ////int level = 10;
            //bool hasKey = true;

            //if (!inputLevel || level < 1 || level > 99)
            //{
            //    Console.WriteLine("Invalid Level");
            //}
            //else if (level >= 10 && hasKey)
            //{
            //    Console.WriteLine("Boss floor unlocked");
            //}
            //else if (level >= 5)
            //{
            //    if (hasKey == true)
            //    {
            //        Console.WriteLine("The door opens");
            //    } 
            //    else
            //    {
            //        Console.WriteLine("Locked Find a key.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The door stays shut");
            //}

            //bool isPosioned = true;

            //if (isPosioned)
            //{
            //    Console.WriteLine("Your died");  
            //}
            //else if (isPosioned == false)
            //{
            //    Console.WriteLine("Your live");
            //}
            //
            int heroHp = 150;
            int monHp = 65;
            int heroSpeed = 60;
            int monSpeed = 50;
            int atk = 10;
            int critAtk = 25;
            int potionHeal = 35;

            Console.WriteLine("--==+ ADVENTURE TIME +==--");
            Console.WriteLine("Finn The Hero vs Monster Actions: ");
            Console.WriteLine("ACTION 1: Light Attack");
            Console.WriteLine("ACTION 2: Heavy Attack");
            Console.WriteLine("ACTION 3: Drink Hp potion");
            Console.WriteLine("ACTION 4: Quick Dodge");

            Console.WriteLine("choose your action (1-4): ");
            bool userInput = int.TryParse(Console.ReadLine(), out int pChioce);

            if (!userInput || pChioce < 1 || pChioce > 4)
            {
                if(pChioce < 1 || pChioce > 2)
                {
                    Console.WriteLine("Choose a Action number between 1-4");
                }
            }
            else if (pChioce == 1)
            {
                monHp -= atk;
                if (monHp <= 0)
                {
                    Console.WriteLine("Monster Defeated!");
                }
                else
                {
                    Console.WriteLine($"Finn the Hero lightATK the monster, Monster have {monHp} Hp Left.");
                }
            }
            else if (pChioce == 2)
            {
                monHp -= critAtk;
                if (monHp <= 0)
                {
                    Console.WriteLine("Monster Defeated!");
                }
                else
                {
                    Console.WriteLine($"Finn the Hero HeavyATK the monster, Monster have {monHp} Hp Left.");
                }
            }
            else if (pChioce == 3)
            {
                heroHp += potionHeal;
                Console.WriteLine($"Hero drank a potion, Hero now have {heroHp} Hp");
            }
            else if (pChioce == 4)
            {
                heroSpeed -= monSpeed;
                if (heroSpeed >= 10 && heroHp >= 60)
                {
                    Console.WriteLine("Hero dodge success");
                }
                else
                {
                    Console.WriteLine("Hero dodge fail!!!");
                }
            }



        }   
    }
}
