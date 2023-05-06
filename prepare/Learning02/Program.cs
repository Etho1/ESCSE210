using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Microsoft","Software Engineer",2003,2020);
        Job job2 = new Job("Apple","Social Media Manager",2006,2021);
        job1.Display();
        job2.Display();

        Resume.Jobs.Add(job1);
    }
}