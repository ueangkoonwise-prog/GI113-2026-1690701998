/*
* Student ID : 1690701998
* Name       : Assignment02
* Section    : 129c
* No.        : 6
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titleNameart = @"++------------------------------------------------------------------------------------------------------++
++------------------------------------------------------------------------------------------------------++
||                                                                                                      ||
||  __        __   _                            _          _   _             __                         ||
||  \ \      / /__| | ___ ___  _ __ ___   ___  | |_ ___   | |_| |__   ___   / _| ___  _ __ __ _  ___    ||
||   \ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  | __| '_ \ / _ \ | |_ / _ \| '__/ _` |/ _ \   ||
||    \ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |_| | | |  __/ |  _| (_) | | | (_| |  __/   ||
||     \_/\_/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/   \__|_| |_|\___| |_|  \___/|_|  \__, |\___|   ||
||                                                                                        |___/         ||
||                                                                                                      ||
++------------------------------------------------------------------------------------------------------++
++------------------------------------------------------------------------------------------------------++";
            const double SmeltRate = 0.175 ;
            const double SalvageRate = 0.25;
            const double MaxBatch = 500;
            Console.WriteLine(titleNameart);
            Console.WriteLine("=> Fire cystal Smelting 0.175 / Salvage 0.25");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Inogt)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");
            Console.Write("Choose Menu: ");
            bool okMenu = char.TryParse(Console.ReadLine(), out char menu);
            Console.Write("How much would you like: ");
            bool okAmount = double.TryParse(Console.ReadLine(), out double amount);

            if (0 < amount && amount <= MaxBatch && okAmount)
            {
                if(menu == 's' ||  menu =='S')
                {
                    double ingot = (amount * SmeltRate);
                    Console.WriteLine($"{amount} Fire cystal Ore = {ingot} Fire cystal Ingot");
                }
                else if(menu == 'b' || menu == 'B')
                {
                    double ore = (amount / SalvageRate);
                    Console.WriteLine($"{amount} Fire cystal Ingot = {ore} Fire cystal Ore");
                }
                else
                {
                    Console.WriteLine($"error : menu.");

                }
                
            }
            else
            {
                Console.WriteLine($"error : amount.");
            }
        }
    }
}
