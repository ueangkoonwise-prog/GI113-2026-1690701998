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
            int maxHp1 = 250;
            float attackPower1 = 55.5f;
            double defense = 15.25;
            bool isHumen = true;

            string hero2Name = "eve";
            char hero2Tier = 'B';
            int maxHp2 = 150;
            float attackPower2 = 25.6f;
            double defense2 = 5.5;
            bool isHumen2 = false;

            string hero3Name = "issac";
            char hero3Tier = 'A';
            int maxHp3 = 225;
            float attackPower3 = 46.5f;
            double defense3 = 7.5;
            bool isHumen3 = true;

            string hero4Name = "elton";
            char hero4Tier = 'S';
            int maxHp4 = 325;
            float attackPower4 = 20.9f;
            double defense4 = 26.25;
            bool isHumen4 = false;

            Console.WriteLine("====== HERO 1 ======");
            Console.WriteLine($"NAME : {heroName}");
            Console.WriteLine($"HERO TIER : {heroTier}");
            Console.WriteLine($"MAX HP : {maxHp}");
            Console.WriteLine($"ATTACKPOWER : {attackPower}");
            Console.WriteLine($"DEFENSE : {defense}");
            Console.WriteLine($"ISHUMEN : {isHumen}");

            Console.WriteLine("====== HERO 2 ======");
            Console.WriteLine($"NAME : {hero2Name}");
            Console.WriteLine($"HERO TIER : {hero2Tier}");
            Console.WriteLine($"MAX HP : {maxHp2}");
            Console.WriteLine($"ATTACKPOWER : {attackPower2}");
            Console.WriteLine($"DEFENSE : {defense2}");
            Console.WriteLine($"ISHUMEN : {isHumen2}");

            Console.WriteLine("====== HERO 3 ======");
            Console.WriteLine($"NAME : {hero3Name}");
            Console.WriteLine($"HERO TIER : {hero3Tier}");
            Console.WriteLine($"MAX HP : {maxHp3}");
            Console.WriteLine($"ATTACKPOWER : {attackPower3}");
            Console.WriteLine($"DEFENSE : {defense3}");
            Console.WriteLine($"ISHUMEN : {isHumen3}");

            Console.WriteLine("====== HERO 4 ======");
            Console.WriteLine($"NAME : {hero4Name}");
            Console.WriteLine($"HERO TIER : {hero4Tier}");
            Console.WriteLine($"MAX HP : {maxHp4}");
            Console.WriteLine($"ATTACKPOWER : {attackPower4}");
            Console.WriteLine($"DEFENSE : {defense4}");
            Console.WriteLine($"ISHUMEN : {isHumen4}");

        }
    }
}
