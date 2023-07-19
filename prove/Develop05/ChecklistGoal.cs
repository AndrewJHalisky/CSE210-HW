using System;

public class ChecklistGoal : Goal
{
    public int _bonusPoints;
    public int _timesCount;
    public int _targetCount;

    public override int RecordEvent()
    {
        if (_goalComplete == false)
        {
            // points += _pointValue;
            // _goalComplete = true;
            // Console.WriteLine($"You have completed the {_goalTitle} goal! You have earned {points} points!");
            Console.Write("How many times did you complete this goal? ");
            int timesCount = int.Parse(Console.ReadLine());
            _timesCount += timesCount;
            if (_timesCount < _targetCount)
            {
                Console.WriteLine($"You have completed the {_goalTitle} goal {_timesCount} / {_targetCount} times. You have currently earned {_pointValue} points! Keep up the great work!");
                return _pointValue;
            }
            else
            {
                _goalComplete = true;
                Console.WriteLine($"Congradulations! You have successfully completed the {_goalTitle} goal! As an added bonus, you have earned {_bonusPoints + _pointValue} bonus points! Well done!");
                return _pointValue + _bonusPoints;
            }
        }
        else
        {
            Console.WriteLine($"You have already completed the {_goalTitle} goal.");
            return 0;
        }
    }

    public int _type = 3;

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

    public ChecklistGoal(int points, string title, string description, bool goalComplete, int currentCount, int targetCount, int bonusPoints) : base(points, title, description, goalComplete)
    {
        _targetCount = currentCount;
        _bonusPoints = bonusPoints;
        _timesCount = currentCount;
    }

    public override string SaveGoal()
    {
        return $"{_type}, {_pointValue}, {_goalTitle}, {_goalDescription}, {_goalComplete}, {_timesCount}, {_targetCount}, {_bonusPoints}";
    }

    //override RecordEvent and impliment logic
}