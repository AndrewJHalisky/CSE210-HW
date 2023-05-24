using System;

class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What is the greatest thing I have acheived in my life?",
        "If I could go back and do something over again, what would it be?",
        "If I could go anywhere in the world, where would it be?",
        "What is something I should be more involved in?",
        "What are some things I feel like I can do to be more independent?"
    };

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
}