public class EternalGoal : Goal
{
    public int _currentCount;
    public int _type = 2;

    public EternalGoal(int points, string title, string description, bool goalComplete, int currentCount) : base(points, title, description, goalComplete)
    {
        _currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        Console.Write("How many times did you complete this goal? ");
        int _timesCount = Convert.ToInt16(Console.ReadLine());
        _currentCount += _timesCount;
        Console.WriteLine($"You have completed the {_goalTitle} goal {_currentCount} times. Keep working on it!");
        return _pointValue;
    }

    public override void DisplayCheckbox()
    {
        Console.WriteLine($"[ ] {_goalTitle} - {_goalDescription}");
    }

    public override string SaveGoal()
    {
        return $"{_type}, {_pointValue}, {_goalTitle}, {_goalDescription}, {_goalComplete}, {_currentCount}";
    }

    //override RecordEvent and impliment logic

}