using System;

public abstract class Goal
{
    //public string _goalType;
    public bool _goalComplete;
    public string _goalTitle;
    public string _goalDescription;
    public int _pointValue;
    public bool _checklist;
    
    public Goal(int points, string title, string description, bool goalComplete)
    {
        _pointValue = points;
        _goalTitle = title;
        _goalDescription = description;
        _goalComplete = goalComplete;
    }

    public abstract void DisplayCheckbox();

    public bool DisplayCompleted()
    {
        return _goalComplete;
    }

    public abstract int RecordEvent();

    public abstract string SaveGoal();
}