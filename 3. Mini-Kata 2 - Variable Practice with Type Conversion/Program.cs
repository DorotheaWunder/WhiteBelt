void ProgramKata3()
{
    string playerName = "Hans-Peter";
    int playerHealth = 100;
    float playerAttack = 15.5f;
    //xp
    bool playerIsParalyzed = true;
    double playerGold = 100.500;
    
    
    
    
    Console.WriteLine($"Player Name: {playerName}");
    Console.WriteLine($"Health Points - as double - (implicit conversion): {playerHealth}");
    Console.WriteLine($"Attack Power - as int - (explicit conversion): {playerAttack}");
    Console.WriteLine($"Is Paralyzed: {playerIsParalyzed}");
    Console.WriteLine($"Gold Coins: {playerGold}");
}

ProgramKata3();