using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade number: ");
        string answer = Console.ReadLine();
        int number = int.Parse(answer);

        string grade = "";
        
        if (number >= 90)
        {
            grade = "A";
        }
        else if (number >= 80)
        {
            grade = "B";
        }
        else if (number >= 70)
        {
            grade = "C";
        }
        else if (number >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        Console.WriteLine($"Your grade is a {grade}");
        
        if (number >= 70)
        {
            Console.WriteLine("Congradulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry you did not pass the course. Please retake it again.");
        }
    }
}