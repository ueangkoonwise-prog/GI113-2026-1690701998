/*
 * Student ID : 1690701998
 * Name       : Assignment01
 * Section    : 129c
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titleNameart = @"__| |___________________________________________________________________| |__
__   ___________________________________________________________________   __
  | |                                                                   | |  
  | |    ____                                          _   _      _ _   | |  
  | |   / ___|___  _ __ ___  _ __   __ _ _ __  _   _  | | | | ___| | |  | |  
  | |  | |   / _ \| '_ ` _ \| '_ \ / _` | '_ \| | | | | |_| |/ _ \ | |  | |  
  | |  | |__| (_) | | | | | | |_) | (_| | | | | |_| | |  _  |  __/ | |  | |  
  | |   \____\___/|_| |_| |_| .__/ \__,_|_| |_|\__, | |_| |_|\___|_|_|  | |  
  | |   __  __              |_|                |___/                    | |  
  | |  |  \/  | __ _ _ __   __ _  __ _  ___ _ __                        | |  
  | |  | |\/| |/ _` | '_ \ / _` |/ _` |/ _ \ '__|                       | |  
  | |  | |  | | (_| | | | | (_| | (_| |  __/ |                          | |  
  | |  |_|  |_|\__,_|_| |_|\__,_|\__, |\___|_|                          | |  
  | |                            |___/                                  | |  
__| |___________________________________________________________________| |__
__   ___________________________________________________________________   __
  | |                                                                   | |  ";

            string devil = @"                              .\
                        .\   / _\   .\
                       /_ \   ||   / _\
                        ||    ||    ||
                 ; ,     \`.__||__.'/
         |\     /( ;\_.;  `./|  __.'
         ' `.  _|_\/_;-'_ .' '||
          \ _/`       `.-\_ / ||      
      , _ _`; ,--.   ,--. ;'_ _|,     
      '`''\| /  ,-\ | _,-\ |/''`'  
       \ .-- \__\_/ /` )_/ --. /   
       /    .         -'  .    \ 
      |     /             \     |  
   .   .  -' `-..____...-' `-  .   
.'`'.__ `._      `-..-''    _.'|   
 \ .--.`.  `-..__    _,..-'   L|   
  '    \ \      _,| |,_      /_7)  
        \ \    /       \ _.-'/||        
         \ \  /.'|   |`.__.'` ||     
          \ `//_/     \       ||    
           `/ \|       |      ||   
            `""`'.  _  .'      ||    
                 \ | /        ||                         
                  |'|         'J        
               .-.|||.-.
              '----""----' ";

            

            var workerName = "calypso";
            var workerRank = 'B';
            int workerLevel = 10;
            const int workerIntellect = 5;
            float workerSpeed = 0.45f;
            double workerStamina = 62.6;
            bool isInwork = true;

            Console.WriteLine(titleNameart);
            Console.WriteLine();
            Console.WriteLine($"Worker Name : {workerName}");
            Console.WriteLine($"Rank : {workerRank}");
            Console.WriteLine($"Level : {workerLevel}");
            Console.WriteLine($"Intellect : {workerIntellect}");
            Console.WriteLine($"Speed : {workerSpeed}");
            Console.WriteLine($"Stamina : {workerStamina}");
            Console.WriteLine($"Inworker : {isInwork}");
            Console.WriteLine();

            double workerAsDouble = workerLevel;
            Console.WriteLine($"Level as double (implicit): {workerAsDouble}");

            int staminaTruncated = (int)workerStamina;               
            int staminaRounded = Convert.ToInt32(workerStamina);      
            Console.WriteLine($"Stamina cast (truncates)  : {staminaTruncated}");
            Console.WriteLine($"Stamina Convert (rounds)  : {staminaRounded}");
            Console.WriteLine();
            Console.WriteLine(devil);

        }
    }
}
