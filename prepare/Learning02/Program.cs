using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "The Big Microsifit";
        job1._startYear = 1966;
        job1._endYear = 2000;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Marine Biologist";
        job2._company = "Big Ocean";
        job2._startYear = 2000;
        job2._endYear = 2014;
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Jotaro Kujo";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}