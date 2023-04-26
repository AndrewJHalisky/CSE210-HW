using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when complete.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);

            if (number != 0)
            {
                numbers.Add(number);
            }  

            else for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            } 
        }

        int sum = 0;
        foreach (int count in numbers)
        {
            sum += count;
        }
        Console.WriteLine($"The sum is {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is {average}");

        int maxValue = numbers.Max();
        Console.WriteLine($"The largest number is {maxValue}");
    }
}   