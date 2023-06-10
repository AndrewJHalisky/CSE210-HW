using System;

public class ListActivity : Activity
{
    public string _descriptionLst = "";
    
    public ListActivity(string startMessage, string descriptionLst, string endMessage) : base(startMessage, endMessage)
    {
        _descriptionLst = descriptionLst;
    }

    public string GetListDscrpt()
    {
        return $"{_descriptionLst}";
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

    List<string> _listingList = new List<string>()
    {
        "When was a time where you felt the Holy Ghost?",
        "What have been some accomplishments in your life?",
        "Who are some people that have helped you the most?",
        "Who are some of your idols or personal heroes?",
        "Where are some places where you feel the most happy?",
        "What are some of your most favorite hobbies?",
        "What are some of your personal strengths?",
        "Where are some places you have been that are far away?"
    };

    private Random rnd = new Random();
    public string _prompt;
    private string _custom;

    public string GenerateListing()
    {
        int index = rnd.Next(_listingList.Count);
        _prompt = _listingList[index];

        return $"{_prompt}";
    }

    public string Listing()
    {
        do
        {
            Console.Write("How many seconds would you like this session to be?");
            _duration = int.Parse(Console.ReadLine());
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);
            Console.WriteLine("List as many responses as you can to the following prompt: ");
            Console.WriteLine(GenerateListing());
            Console.WriteLine("Get ready in...");
            GetCountdown();
            int count = 0;
            while (DateTime.Now < futureTime)
            {
                
                Console.Write("> ");
                _custom = Console.ReadLine();
                count++;
            }
            Console.WriteLine($"You listed {count} repsonses!");
        }
        while(Ending());
        return "Thank you for listing those responses! ";
    }

}