using System;

public class Activity
{
    protected string _startMessage = "";
    protected string _endMessage = "";
    protected int _duration;

    public Activity(string startMessage, string endMessage)
    {
        _startMessage = startMessage;
        _endMessage = endMessage;
    }

    public string GetAnimation()
    {
        // __/|\__/|\__
        List<string> animationStrings = new List<string>();
        animationStrings.Add("___");
        animationStrings.Add("_/");
        animationStrings.Add("/|");
        animationStrings.Add("|\\");
        animationStrings.Add("\\_");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        int i = 0;

        while (DateTime.Now < endTime)    
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b \b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        return "Done!";
    }

    public bool Ending()
    {
        Console.WriteLine("Would you like to do this activity again?");
        Console.Write("Type 1 - Yes or 2 - No");
        string user = Console.ReadLine();
        if (user == "1")
            return true;
        else
            return false;
    }

    public string GetStartMessage()
    {
        return $"{_startMessage}";
    }

    public string GetEndMessage()
    {
        return $"{_endMessage}";
    }

}