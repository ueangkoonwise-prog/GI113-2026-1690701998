/*
 * Student ID : 1690701998
 * Name       : Lab02
 * Section    : 129c
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

using System;
using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Hp: {currentHp} / {maxHp}");
            Console.WriteLine($"AttackPower: {attackPower}");
            Console.WriteLine($"CritMultiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp; 

            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            string heroName = "Aiden";
            char heroTier = 'A';
            int maxHp = 250;
            float attackPower = 55.5f;
            double defense = 15.25;
            bool isHumen = true;

            string hero2Name = "eve";
            char heroTier = 'B';
            int maxHp = 150;
            float attackPower = 25.6f;
            double defense = 5.5;
            bool isHumen = false;

            string hero3Name = "issac";
            char heroTier = 'A';
            int maxHp = 225;
            float attackPower = 46.5f;
            double defense = 7.5;
            bool isHumen = true;

            string hero4Name = "elton";
            char heroTier = 'S';
            int maxHp = 325;
            float attackPower = 20.9f;
            double defense = 26.25;
            bool isHumen = false;

            Console.WriteLine("====== HERO 1 ======");
            Console.WriteLine($"NAME : {heroName}");
            Console.WriteLine($"HERO TIER : {heroTier}");
            Console.WriteLine($"MAX HP : {maxHp}");
            Console.WriteLine($"ATTACKPOWER : {attackPower}";
            Console.WriteLine($"DEFENSE : {defense}";
            Console.WriteLine($"ISHUMEN : {isHumen}");

        }
    }
}
