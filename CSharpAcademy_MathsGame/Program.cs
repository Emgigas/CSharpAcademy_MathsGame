string name = GetName();
DateTime date = DateTime.UtcNow;

Menu(name, date);

string GetName()
{
    Console.Write("Please enter your name: ");

    name = Console.ReadLine();
    return name;
}

void Menu(string? name, DateTime date)
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
}

void SubtractionGame()
{
    Console.WriteLine("Subtraction game selected");
}

void MultiplicationGame()
{
    Console.WriteLine("Multiplication game selected");
}

void DivisionGame()
{
    Console.WriteLine("Division game selected");
}

void QuitGame()
{
    Console.WriteLine("Game has ended");
    Environment.Exit(1);
}