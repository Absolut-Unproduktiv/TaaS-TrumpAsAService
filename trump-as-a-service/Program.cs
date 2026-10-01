
namespace trump_as_a_service;

public class Program()
{
    public static void Main()
    {
        HelloThere();
        var userQuestion = Console.ReadLine();
        Console.WriteLine("Trumps terrific, truly terrific response.");
        Console.WriteLine(userQuestion);
    }

    private static void HelloThere()
    {
        Console.WriteLine("Welcome to the greatest american speech of all time! The newest MAGA rally is open and beautiful.");
        Console.WriteLine("You from the Media, the terrible Media can ask me one question, only one though only one question.");
    }
    
}