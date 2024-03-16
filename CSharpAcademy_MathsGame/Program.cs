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

string? response = gameSelected.Trim().ToLower() switch
{
    "a" => "Addition game selected",
    "s" => "Subtraction game selected",
    "m" => "Multiplication game selected",
    "d" => "Division game selected",
    "q" => "Game has ended",
    _ => "Incorrect response given",
};

Console.WriteLine(response);

