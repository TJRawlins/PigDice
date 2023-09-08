
int gamesPlayed = 0;
int highestScore = 0;
int score  = 0;
var random = new Random();
int die = 0;

while (true)
{
    Console.Write("Press ENTER to roll the die or ESC to exit.");
    var roll = Console.ReadKey();
    Console.WriteLine();

   if (roll.Key == ConsoleKey.Enter)
    {
        int newRoll = random.Next(1, 6);
        if (newRoll == 1)
        {
            if (score > highestScore)
            {
                highestScore = score;
            }
            Console.WriteLine($"GAME OVER! You rolled a 1! Final Score: {score} | Highest Score: {highestScore}");
            score = 0;
            gamesPlayed++;
        } else
        {
            score += newRoll;
            Console.WriteLine($"You rolled a {newRoll}. Score: {score}");
        }
    } else if (roll.Key == ConsoleKey.Escape)
    {
        Console.WriteLine($"Games Played: {gamesPlayed}");
        break;
    }
}

/*
while (true)
{

    if (score < 500)
    {
        int newRoll = random.Next(1, 6);
        if (newRoll == 1)
        {
            if (score > highestScore)
            {
                highestScore = score;
            }
            Console.WriteLine($"GAME OVER! You rolled a 1! Final Score: {score} | Highest Score: {highestScore}");
            score = 0;
            gamesPlayed++;
        }
        else
        {
            score += newRoll;
            Console.WriteLine($"You rolled a {newRoll}. Score: {score}");
        }
    }
    else
    {
        Console.WriteLine($"Games Played: {gamesPlayed}");
        break;
    }
}
*/