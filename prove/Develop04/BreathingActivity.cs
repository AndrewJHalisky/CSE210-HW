using System;

public class BreathActivity : Activity
{
    public int _seconds;
    public string _descriptionBrth = "";

    public BreathActivity(string startMessage, string descriptionBrth, string endMessage) : base(startMessage, endMessage)
    {
        _descriptionBrth = descriptionBrth;
    }

    public void GetCountdown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public string GetBreathDescrpt()
    {
        return $"{_descriptionBrth}";
    }

    public string Breathe()
    {
        do
        {
            Console.Write("How many seconds would you like this session to be?");
            _duration = int.Parse(Console.ReadLine());
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);
            while (DateTime.Now < futureTime)
            {
                Console.WriteLine("Breathe in.... ");
                GetCountdown();
                Console.WriteLine("And breathe out.... ");
                GetCountdown();
            }
            Console.WriteLine($"Congradulations! You have completed this activity in {_duration} seconds! ");
        }
        while(Ending());       
        return "Thank you for taking the time to meditate through these breathing exercisese!";
    }
}