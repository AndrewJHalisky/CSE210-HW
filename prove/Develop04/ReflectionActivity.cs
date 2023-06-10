using System;

public class ReflectActivity : Activity
{
    public string _descrptline1 = "";
    public string _descrptline2 = "";

    public ReflectActivity(string startMessage, string descrptline1, string descrptline2, string endMessage) : base(startMessage, endMessage)
    {
        _descrptline1 = descrptline1;
        _descrptline2 = descrptline2;
    }

    public string GetReflectDescrpt1()
    {
        return $"{_descrptline1}";
    }

    public string GetReflectDescrpt2()
    {
        return $"{_descrptline2}";
    }

    List<string> _reflectList = new List<string>()
    {
        "What was the most difficult or challenging time in your life?",
        "When was a time where you felt like you were not included as much?",
        "What was the hardest thing you achieved in your life?",
        "When is a time where you did something nice for someone?",
        "What was the greatest milestone in your life?",
        "When was a time where you stood up for someone?"
    };

    List<string> _qstnList = new List<string>()
    {
        "How did this experience help you in your life?",
        "How did you feel after this event happened?",
        "How would you feel if something like this never happened?",
        "How can you apply this experience to your everyday life?",
        "What did you learn from this experience?",
        "How did you change from this experience?",
        "What was different about this event than usual?",
        "Who did you look up to during this event?",
        "What caused this experience to happen?",
        "What would you do if this happened again?"
    };

    private Random rnd = new Random();
    private string _reflection;
    private string _question;

    public string GenerateReflect()
    {
        int index = rnd.Next(_reflectList.Count);
        _reflection = _reflectList[index];

        return $"{_reflection}";
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

    public string GenerateQstn()
    {
        int index = rnd.Next(_qstnList.Count);
        _question = _qstnList[index];

        return $"{_question}";
    }

    public string Reflect()
    {
        do
        {
            Console.Write("How many seconds would you like this session to be?");
            _duration = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine(GenerateReflect());
            Console.WriteLine();
            Console.Write("Press enter if you have something in mind.");
            Console.ReadLine();
            Console.WriteLine("Get ready in...");
            GetCountdown();
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);
            while (DateTime.Now < futureTime)
            {
                Console.WriteLine(GenerateQstn());
                Console.WriteLine();
                GetAnimation();
            }
        }
        while(Ending());
        return "Thanks for taking the time to reflect on those events! ";

    }


}