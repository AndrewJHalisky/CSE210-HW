using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(int points, string title, string description, bool goalComplete) : base(points, title, description, goalComplete)
    {
    }

    public int _type = 1;

    //override RecordEvent and impliment logic
    public override int RecordEvent()
    {
        if (_goalComplete == false)
        {
            _goalComplete = true;
            Console.WriteLine($"You have completed the {_goalTitle} goal! You have earned {_pointValue} points!");
        }
        else
        {
            Console.WriteLine($"You have already completed the {_goalTitle} goal.");
        }
        return _pointValue;
    }
    public override void DisplayCheckbox()
    {
        if (_goalComplete == true)
        {
            Console.WriteLine($"[X] {_goalTitle} - {_goalDescription}");
        }
        else
        {
            Console.WriteLine($"[ ] {_goalTitle} - {_goalDescription}");
        }
    }

    public override string SaveGoal()
    {
        return $"{_type}, {_pointValue}, {_goalTitle}, {_goalDescription}, {_goalComplete}";
    }
}