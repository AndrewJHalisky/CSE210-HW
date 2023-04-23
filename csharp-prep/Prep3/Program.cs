using System;

class Program
{
    static void Main(string[] args)
    {
        // This is for Step 2:
        // Console.Write("What is the magic number? ");
        // string answer1 = Console.ReadLine();
        // int magicnumber = int.Parse(answer1);

        // This is for step 3:
        int guessnumber = -1;
        Random randomNumber = new Random();
        int magicnumber = randomNumber.Next(1, 101);
    
        while (guessnumber != magicnumber)
        {
            Console.Write("What is your guess? ");
            string answer2 = Console.ReadLine();
            guessnumber = int.Parse(answer2);

            if (guessnumber == magicnumber)
            {
                Console.WriteLine("Congradulations! You guessed it correctly");
                break;
            }
            else if (guessnumber > magicnumber)
            {
                Console.WriteLine("Guess lower!");
            }
            else
            {
                Console.WriteLine("Guess higher!");
            }
        }
    }
}