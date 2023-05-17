using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Felix inc.";
        job1._startYear = 2025;
        job1._endYear = 2065;

        Job job2 = new Job();   
        job2._jobTitle = "Troubleshooter";
        job2._company = "Wix";
        job2._startYear = 2027;
        job2._endYear = 2048;

        Resume myResume = new Resume();
        myResume._name = "Andrew Halisky";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}