using System;

class Program
{
    static void Main(string[] args)
    {
        File IO = new File();
        List<Goal> _goalsList = new List<Goal>();
        int _totalPoints = 0;
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Goal tracker program!");
            Console.WriteLine("Here you can track and set all of your goals for points!");
            Console.WriteLine();
            Console.WriteLine($"You have {_totalPoints} total points.");
            Console.WriteLine();
            Console.WriteLine("Select one of the choices below:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    // print goal options
                    // get user input
                    Console.WriteLine("What type of goal would you like to create?");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Select a choice from the menu: ");
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            Console.Write("What is the name of your goal? ");
                            string _goalTitle = Console.ReadLine();
                            Console.Write("What is a short description of your goal? ");
                            string _goalDescription = Console.ReadLine();
                            Console.Write("How many points will you give this goal? ");
                            int _pointValue = int.Parse(Console.ReadLine());
                            SimpleGoal simpleGoal = new SimpleGoal(_pointValue, _goalTitle, _goalDescription, false);
                            _goalsList.Add(simpleGoal);
                            break;

                        case "2":
                            Console.Write("What is the name of your goal? ");
                            _goalTitle = Console.ReadLine();
                            Console.Write("What is a short description of your goal? ");
                            _goalDescription = Console.ReadLine();
                            Console.Write("How many points will you give this goal? ");
                            _pointValue = int.Parse(Console.ReadLine());
                            EternalGoal eternalGoal = new EternalGoal(_pointValue, _goalTitle, _goalDescription, false, 0);
                            _goalsList.Add(eternalGoal);
                            break;
                        case "3":
                            Console.Write("What is the name of your goal? ");
                            _goalTitle = Console.ReadLine();
                            Console.Write("What is a short description of your goal? ");
                            _goalDescription = Console.ReadLine();
                            Console.Write("How many points will you give this goal? ");
                            _pointValue = int.Parse(Console.ReadLine());
                            Console.Write("How many times do you need to complete this goal for bonus points?");
                            int _targetCount = int.Parse(Console.ReadLine());
                            Console.Write("How many bonus points will you give for the last time the goal is complete?");
                            int _bonusPoints = int.Parse(Console.ReadLine());
                            ChecklistGoal checklistGoal = new ChecklistGoal(_pointValue, _goalTitle, _goalDescription, false, 0, _targetCount, _bonusPoints);
                            _goalsList.Add(checklistGoal);
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("The goals listed are: ");
                    foreach (Goal goal in _goalsList)
                    {
                        goal.DisplayCheckbox();
                    }
                    break;
                case "3":
                    // prompt the user for the filename
                    // get filename
                    // call save method and pass in the filename
                    IO.SaveFile(_goalsList, _totalPoints);
                    break;
                case "4":
                    // prompt the user for the filename
                    // get filename
                    // call load method and pass in the filename
                    _goalsList = IO.LoadFile(ref _totalPoints);
                    break;
                case "5":
                    // loop through the goals list and only display non completed goals
                    // user selects goal
                    // execute goal.recordevent ( totalPoints += goal.recordevent() )
                    //
                    Console.WriteLine("The list of goals are: ");
                    Console.WriteLine();
                    foreach (Goal goal in _goalsList)
                    {
                        for (int i=0; i<_goalsList.Count; i++)
                        {
                            goal.DisplayCheckbox();
                        }
                        Console.WriteLine();
                        Console.Write("Which goal did you complete? ");
                        int _completeChoice = Convert.ToInt16(Console.ReadLine());
                        _goalsList[_completeChoice - 1].RecordEvent();
                        _totalPoints += goal.RecordEvent();
                    }
                    break;
                case "6":
                    Console.WriteLine("Thank you for using the Goal tracker program! Goodbye for now!");
                    exit = true;
                    break;
            }
        }
    }
}