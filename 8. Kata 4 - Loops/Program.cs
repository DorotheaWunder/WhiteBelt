class Program
{
    static void Main()
    {
        int totalWaves = 3;
        int totalEnemies = 10;

        for (int wave = 1; wave <= totalWaves; wave++)
        {
            Console.WriteLine($"Wave {wave} begins - prepare yourself!");
            Thread.Sleep(500);
            for (int enemy = 1; enemy <= totalEnemies; enemy++)
            {
                Console.WriteLine($"Enemy #{enemy} appears");
                Thread.Sleep(300);
            }
            Console.WriteLine($"Wave {wave} completed - the next wave is approaching");
            Console.WriteLine();
            Thread.Sleep(1000);
        }
    }
}

