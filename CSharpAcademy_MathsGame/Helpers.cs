using CSharpAcademy_MathsGame.Models;

namespace CSharpAcademy_MathsGame;

public class Helpers
{
    internal static List<Game> gameScores = new();
    
    internal static void ShowScores()
    {
        Console.Clear();
        Console.WriteLine("============================================================================================");
        foreach (var game in gameScores)
        {
            Console.WriteLine($"{game.Date} - {game.Type}: Score = {game.Score}");
        }
        Console.WriteLine("============================================================================================");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
    
    internal static int[] GetDivisionNumbers()
    {
        Random random = new Random();
        int firstNumber = random.Next(1, 99);
        int secondNumber = random.Next(1, 99);
        int[] result = new int[2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
        }

        result[0] = firstNumber;
        result[1] = secondNumber;

        return result;
    }

    internal static void CaptureScore(int gameScore, GameType gameType)
    {
        gameScores.Add(new Game
        {
            Date = DateTime.Now,
            Score = gameScore,
            Type = gameType,
        });
    }
}