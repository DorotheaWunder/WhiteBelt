class Program
{
    static void Main()
    {
        Random random = new Random();
        int playerLuck = random.Next(1, 11);
        
        Console.WriteLine("You find a mysterious treasure chest...");
        Console.WriteLine("What will you do?");
        Console.WriteLine();
        Console.WriteLine("1 - open the chest");
        Console.WriteLine("2 - ignore the chest");
        Console.WriteLine("3 - leave the area");

        string playerInput = Console.ReadLine();

        if (playerInput == "1")
        {
            Console.WriteLine("You decide to open the chest");

            if (playerLuck > 7)
            {
                Console.WriteLine("The chest contained a rare gem");
            }
            else if (playerLuck >= 5)
            {
                Console.WriteLine("The chest contained 100 Gold");
            }
            else
            {
                Console.WriteLine("The chest is actually a mimic and bites you in the rear");
            }
        }
        else if (playerInput == "2")
        {
            Console.WriteLine("You decide to ignore the chest");
        }
        else if (playerInput == "3")
        {
            Console.WriteLine("You decide to leave the area");
        }
        else
        {
            Console.WriteLine("Whatever you chose, it wasn't a valid choice - try again");
            Main();
        }
    }
}

