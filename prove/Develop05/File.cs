using System;

public class File
{
    public string _fileName;
    // public List<Goal> goals = new List<Goal>();

    public void SaveFile(List<Goal> goals, int totalPoints)
    {
        Console.Write("Please give this file a name: ");
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(totalPoints);
            foreach (Goal g in goals)
            {
                outputFile.WriteLine(g.SaveGoal());
            }
            Console.WriteLine("Goal successfully saved! ");
        }
    }

    public List<Goal> LoadFile(ref int totalPoints)
    {
        Console.Write("What is the name of the file? ");
        _fileName = Console.ReadLine();
        List<Goal> goals = new List<Goal>();
        int points;
        int bonusPoints;
        string title;
        string descrpt;
        int count;
        bool complete;
        int target;
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        if (lines != null)
        {
            totalPoints = int.Parse(lines[0]);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                int type = int.Parse(parts[0]);
                if (type == 1)
                {
                    points = int.Parse(parts[1]);
                    title = parts[2];
                    descrpt = parts[3];
                    complete = bool.Parse(parts[4]);
                    SimpleGoal simpleGoal = new SimpleGoal(points, title, descrpt, complete);
                    goals.Add(simpleGoal);
                }
                else if (type == 2)
                {
                    points = int.Parse(parts[1]);
                    title = parts[2];
                    descrpt = parts[3];
                    complete = bool.Parse(parts[4]);
                    count = int.Parse(parts[5]);
                    EternalGoal eternalGoal = new EternalGoal(points, title, descrpt, complete, count);
                    goals.Add(eternalGoal);
                }
                else if (type == 3)
                {
                    points = int.Parse(parts[1]);
                    bonusPoints = int.Parse(parts[7]);
                    title = parts[2];
                    descrpt = parts[3];
                    complete = bool.Parse(parts[4]);
                    count = int.Parse(parts[5]);
                    target = int.Parse(parts[6]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(points, title, descrpt, complete, count, target, bonusPoints);
                    goals.Add(checklistGoal);
                }
            }
            Console.WriteLine("Goals successfully loaded! ");
            return goals;
        }
        else
        {
            //Console.WriteLine("That file does not exist! "); No data to read
            return new List<Goal>();
        }
    }
}