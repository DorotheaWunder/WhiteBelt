namespace Kata3;

class Program
{
    static void Main()
    {
        void ProgramKata3()
        {
            string playerName = "Hans-Peter";

            int playerHealth = 100;
            double playerHealthConv = playerHealth;

            float playerAttack = 15.5f;
            int playerAttackConv = (int)playerAttack;

            double playerExperience = 250;
            int playerExperienceConv = Convert.ToInt32(playerExperience);

            string playerGold = "150.3333333";
            double playerGoldConv = double.Parse(playerGold);

            string playerInvalid = "invalid";
            int playerInvalidConv;
            bool CanBeParsed = int.TryParse(playerInvalid, out playerInvalidConv);


            Console.WriteLine($"Player Name: {playerName}");
            Console.WriteLine($"Health Points - as double - (implicit conversion): {playerHealthConv}");
            Console.WriteLine($"Attack Power - as int - (explicit conversion): {playerAttackConv}");
            Console.WriteLine($"Experience- as int - (converted from double): {playerExperienceConv}");
            Console.WriteLine($"Gold Coins - as double - (parsed from string): {playerGoldConv}");
            Console.WriteLine($"Number '{playerInvalid}' can be parsed to int: {CanBeParsed} "); 
        }
        ProgramKata3();
    }
}

    
    
    
    



