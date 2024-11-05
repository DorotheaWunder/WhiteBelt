class Program
{
    
    static void Main()
    {
        int playerHealth = 80;
        int enemyHealth = 50;
        bool isPlayerTurn = true;
        
        void TurnOrder()
        {
            
            while (playerHealth > 0 && enemyHealth > 0)
            {
                ShowStats();
                
                if (isPlayerTurn)
                {
                    ShowMenu();
                }
                else
                {
                    Attack();
                }

                isPlayerTurn = !isPlayerTurn;
            }
            EndResult();
        }
        
        void ShowStats()
        {
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Hero HP: {playerHealth}");
            Console.WriteLine($"Goblin HP: {enemyHealth}");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }

        void ShowMenu()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Player, what do you want to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");

            string playerInput = Console.ReadLine();
            if (playerInput != "1" && playerInput != "2")
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Your choice of {playerInput} wasn't valid - choose again");
                ShowMenu();
            }
            else
            {
                int playerInputInt = Convert.ToInt32(playerInput);
                if (playerInputInt == 1)
                {
                    Attack();
                }
                else if (playerInputInt == 2)
                {
                    Heal();
                }
            }
        }
            
            
        void Attack()
        {
            Random random = new Random();
            int playerAtkDamage = random.Next(5, 10);
            int enemyAtkDamage = random.Next(4, 8);
            
            if (isPlayerTurn)
            {
                Thread.Sleep(500);
                Console.WriteLine("You attack the Goblin");
                enemyHealth -= playerAtkDamage;
                Console.WriteLine($"The Goblin lost {playerAtkDamage} HP");
            }
            else
            {
                Thread.Sleep(500);
                Console.WriteLine("The Goblin attacks attacks you");
                playerHealth -= enemyAtkDamage;
                Console.WriteLine($"You lost {enemyAtkDamage} HP");
            }
        }

        void Heal()
        {
            Random random = new Random();
            int playerHealAmount = random.Next(8, 15);
            
            Thread.Sleep(500);
            Console.WriteLine("You cast a healing spell");
            playerHealth += playerHealAmount;
            Console.WriteLine($"Your spell restored {playerHealAmount} HP");
        }

        void EndResult()
        {
            Console.WriteLine();
            if (isPlayerTurn)
            {
                Console.WriteLine("The goblin managed to defeat you");
                Console.WriteLine("-----YOU LOST THE GAME-----");
            }
            else
            {
                Console.WriteLine("You slew the Goblin");
                Console.WriteLine("-----YOU WON THE GAME------");
            }
        }
        TurnOrder();
    }
}

