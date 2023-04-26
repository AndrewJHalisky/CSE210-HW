using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqroot = SquareNumber(number);
    
        DisplayResult(name, sqroot);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name:");
        string yourName = Console.ReadLine();
        return yourName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        string numAnswer = Console.ReadLine();
        int favNumber = int.Parse(numAnswer);
        return favNumber;
    }

    static int SquareNumber(int number)
    {
        int sqrtAnswer = number * number;
        return sqrtAnswer;
    }

    static void DisplayResult(string name, int sqroot)
    {
        Console.WriteLine($"Hello {name}, the square root of your number is {sqroot}!");
    }
}