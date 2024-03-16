﻿string name = GetName();
DateTime date = DateTime.UtcNow;

Menu(name);

string GetName()
{
    Console.Write("Please enter your name: ");

    name = Console.ReadLine();
    return name;
}

void Menu(string? name)
{
    Console.WriteLine("============================================================================================");
    Console.WriteLine($"Hello {name}. It's {date}. This is the CSharpAcademy Maths game challenge.");
    Console.WriteLine($"""
                       Which game would you like to play. Select from the options below:
                       A - Addition
                       S - Subtraction
                       M - Multiplication
                       D - Division
                       Q - Quit the program
                       """);
    Console.WriteLine("============================================================================================");

    string? gameSelected = Console.ReadLine();

    switch (gameSelected?.Trim().ToLower())
    {
        case "a": AdditionGame(); break;
        case "s": SubtractionGame(); break;
        case "m": MultiplicationGame(); break;
        case "d": DivisionGame(); break;
        case "q": QuitGame(); break;
        default: Console.WriteLine("Invalid response"); Environment.Exit(1);
            break;
    }
}

void AdditionGame()
{
    Console.WriteLine("Addition game selected");

    Random random = new Random();

    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        var firstNumber = random.Next(1, 9);
        var secondNumber = random.Next(1, 9);
        
        Console.Write($"\n{firstNumber} + {secondNumber} = ");
        var result = Console.ReadLine();

        bool checkResult = int.TryParse(result, out var parseResult);
        if (checkResult)
        {
            if (parseResult == firstNumber + secondNumber)
            {
                Console.WriteLine("Your answer was correct!");
                score++;
            }
            else Console.WriteLine($"Incorrect answer. The correct answer was {firstNumber + secondNumber}.");
        }
        else Console.WriteLine("Your answer was not a valid number.");
    }
    Console.WriteLine($"\nGame over. Your final score was: {score}");
}

void SubtractionGame()
{
    Console.WriteLine("Subtraction game selected");
    Random random = new Random();

    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        var firstNumber = random.Next(1, 9);
        var secondNumber = random.Next(1, 9);
        
        Console.Write($"\n{firstNumber} - {secondNumber} = ");
        var result = Console.ReadLine();

        bool checkResult = int.TryParse(result, out var parseResult);
        if (checkResult)
        {
            if (parseResult == firstNumber - secondNumber)
            {
                Console.WriteLine("Your answer was correct!");
                score++;
            }
            else Console.WriteLine($"Incorrect answer. The correct answer was {firstNumber - secondNumber}.");
        }
        else Console.WriteLine("Your answer was not a valid number.");
    }
    Console.WriteLine($"\nGame over. Your final score was: {score}");
}

void MultiplicationGame()
{
    Console.WriteLine("Multiplication game selected");
    Random random = new Random();

    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        var firstNumber = random.Next(1, 9);
        var secondNumber = random.Next(1, 9);
        
        Console.Write($"\n{firstNumber} * {secondNumber} = ");
        var result = Console.ReadLine();

        bool checkResult = int.TryParse(result, out var parseResult);
        if (checkResult)
        {
            if (parseResult == firstNumber * secondNumber)
            {
                Console.WriteLine("Your answer was correct!");
                score++;
            }
            else Console.WriteLine($"Incorrect answer. The correct answer was {firstNumber * secondNumber}.");
        }
        else Console.WriteLine("Your answer was not a valid number.");
    }

    Console.WriteLine($"\nGame over. Your final score was: {score}");
}

void DivisionGame()
{
    Console.WriteLine("Division game selected");
    
    Random random = new Random();

    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        int[] divisionNumbers = GetDivisionNumbers();
        int firstNumber = divisionNumbers[0];
        int secondNumber = divisionNumbers[1];
        
        Console.Write($"\n{firstNumber} / {secondNumber} = ");
        var result = Console.ReadLine();

        bool checkResult = int.TryParse(result, out var parseResult);
        if (checkResult)
        {
            if (parseResult == firstNumber / secondNumber)
            {
                Console.WriteLine("Your answer was correct!");
                score++;
            }
            else Console.WriteLine($"Incorrect answer. The correct answer was {firstNumber / secondNumber}.");
        }
        else Console.WriteLine("Your answer was not a valid number.");
    }

    Console.WriteLine($"\nGame over. Your final score was: {score}");
}

int[] GetDivisionNumbers()
{
    Random random = new Random();
    int firstNumber = random.Next(0, 99);
    int secondNumber = random.Next(0, 99);
    int[] result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(0, 99);
        secondNumber = random.Next(0, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}

void QuitGame()
{
    Console.WriteLine("Game has ended");
    Environment.Exit(1);
}