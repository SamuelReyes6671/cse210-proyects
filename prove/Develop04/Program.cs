using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        List<string> signos=new List<string>();
        signos.Add("|");
        signos.Add("/");
        signos.Add("-");
        signos.Add("\\");
        signos.Add("|");
        signos.Add("/");
        signos.Add("-");
        signos.Add("\\");

        Activity b=new Activity("Samuel","un nuevo programa",30);
        Console.WriteLine(b.ToString());


        DateTime startTime=DateTime.Now;
        DateTime endTime=startTime.AddSeconds(10);
        int i =0;
        while (DateTime.Now<endTime){
            string a = signos[i];
            Console.Write(a);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
            if (i>= signos.Count){
                i=0;
            }

        }
        
    }
}