using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Michael", "Geometry");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment mathassign1 = new MathAssignment("Joshua", "Algebra 2", "Section 6.2", "Problems 8-16");
        Console.WriteLine(mathassign1.GetSummary());
        Console.WriteLine(mathassign1.GetHomeworkList());

        WritingAssignment writingassign1 = new WritingAssignment("Abigail", "American History", "The Boston Massacure");
        Console.WriteLine(writingassign1.GetSummary());
        Console.WriteLine(writingassign1.GetWritingInformation());
    }
}