using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 1999;
        job1._endYear = 2005;

        Job job2 = new Job();
        job2._jobTitle = "Controls Engineer";
        job2._company = "Idaho Milk Product";
        job2._startYear = 2010;
        job2._endYear = 2020;

        Resume resume1 = new Resume();
        resume1.person_name = "George";
        resume1._Jobs.Add(job1);
        resume1._Jobs.Add(job2);

        resume1.Display();

    }
}