class Program
{
    static void Main()
    {
        Random random = new Random();
        int playerLuck = random.Next(1, 11);
        
        Console.WriteLine("Sir Robin, do you want to attack the enemy? (yes/no)");
        string playerAnswer = Console.ReadLine().ToLower();
        if (playerAnswer == "yes")
        {
            Console.WriteLine("You're trying to land a strike...");
            
            if (playerLuck > 7)
            {
                Console.WriteLine("You struck a mighty blow!");
            }
            else if (playerLuck == 7 || playerLuck == 6)
            {
                Console.WriteLine("You barely managed to hit your enemy");
            }
            else
            {
                Console.WriteLine("You didn't manage to hit your target (and probably need glasses)");
            }
        }
        else if (playerAnswer == "no")
        {
            Console.WriteLine("Brave Sir Robin ran away.");
            Console.WriteLine("Bravely ran away away.");
            Console.WriteLine("When danger reared it's ugly head,");
            Console.WriteLine("He bravely turned his tail and fled.");
        }
        else
        {
            Console.WriteLine("Whatever you entered was not a valid answer - try again");
            Main();
        }
    }
}
