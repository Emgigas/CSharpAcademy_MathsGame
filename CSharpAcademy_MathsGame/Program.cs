Console.Write("Please enter your name: ");

string? name = Console.ReadLine();
DateTime date = DateTime.UtcNow;
string linebreak = "============================================================================================";

Console.WriteLine(linebreak);
Console.WriteLine($"Hello {name}. It's {date}. This is the CSharpAcademy Maths game challenge.\n");
Console.WriteLine($@"Which game would you like to play. Select from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
Console.WriteLine(linebreak);