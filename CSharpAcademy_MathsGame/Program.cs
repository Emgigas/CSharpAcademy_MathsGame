Console.Write("Please enter your name: ");

string? name = Console.ReadLine();
DateTime date = DateTime.UtcNow;
string linebreak = "============================================================================================";

Console.WriteLine(linebreak);
Console.WriteLine($"Hello {name}. It's {date}. This is the CSharpAcademy Maths game challenge.");
Console.WriteLine($@"Which game would you like to play. Select from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
Console.WriteLine(linebreak);

string? gameSelected = Console.ReadLine();

switch (gameSelected?.Trim().ToLower())
{
    case "a": AdditionGame(); break;
    case "s": SubtractionGame(); break;
    case "m": MultiplicationGame(); break;
    case "d": DivisionGame(); break;
    case "q": QuitGame(); break;
    default: Console.WriteLine("Invalid response"); break;
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
}