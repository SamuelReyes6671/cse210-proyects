using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1=new Job();
       job1._jobTittle="Software Engineer";
       job1._company="Microsoft";
       job1._starYear=2019;
       job1._endYear=2021;

       Job job2=new Job();
       job2._jobTittle="Manager";
       job2._company="Apple"; 
       job2._starYear=2022;
       job2._endYear=2023;

       Job job3=new Job();
       job3._jobTittle="Traductor Call Center";
       job3._company="Teleperformance";
       job3._starYear=2023;
       job3._endYear=2024;

       Resume myResume=new Resume();
       myResume._name = "Allison Rose";

       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);
       myResume._jobs.Add(job3);

       myResume.Display();

    }
}