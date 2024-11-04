class Program
{
    static void Main()
    {
        string playerName = "Horst-Dieter";
        int playerLevel = 5;
        float playerHealth = 75.5f;
        double playerExp = 1025.75;
        bool playerHasMagic = true;
        char playerRank = 'A';

        double nextLvlTreshold = 10000.5000;
        double toNextLvl = nextLvlTreshold - playerExp;
        
        
        Console.WriteLine($"Character Name: {playerName}");
        Console.WriteLine($"Level: {playerLevel}");
        Console.WriteLine($"Health Points: {playerHealth}");
        Console.WriteLine($"Experience Points: {playerExp}");
        Console.WriteLine($"Has Magic Ability: {playerHasMagic}");
        Console.WriteLine($"Rank: {playerRank}");
        
        Console.WriteLine($"Points needed to reach next level: {toNextLvl}");
    }
}

