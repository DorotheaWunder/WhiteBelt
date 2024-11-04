class Program
{
    static void Main()
    {
        int enemyNumbers = 10;
        int enemiesSpawned = 0;

        Console.WriteLine("The enemies spawn using a FOR-loop:");
        for (int i = 0; i < enemyNumbers; i++)
        {
            Console.WriteLine($"Enemy #{i +1} has spawned");
        }
        
        Console.WriteLine();
        Console.WriteLine("The enemies spawn using a WHILE-loop:");
        while (enemiesSpawned < enemyNumbers)
        {
            Console.WriteLine($"Enemy #{enemiesSpawned + 1} has spawned");
            enemiesSpawned++;
        }

    }
}
