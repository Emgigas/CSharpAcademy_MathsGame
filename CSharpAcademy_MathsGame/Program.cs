using CSharpAcademy_MathsGame;

string? name = GetName();
DateTime date = DateTime.UtcNow;
var menu = new Menu();

menu.ShowMenu(name, date);

string? GetName()
{
    Console.Write("Please enter your name: ");

    name = Console.ReadLine();
    return name;
}