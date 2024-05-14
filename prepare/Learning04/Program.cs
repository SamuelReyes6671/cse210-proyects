class Program
{
    static void Main(string[] args)
    {
        Assignment tarea1=new Assignment("Samuel Reyes","Multiplication");
        Console.WriteLine(tarea1.GetSummary());

        MathAssignment tarea2=new MathAssignment("Samuel Reyes","fractions","7.3","8-19");
        Console.WriteLine(tarea2.GetSummary());

        WritingAssignment tarea3 = new WritingAssignment("Mary Waters","European","The Causes of World Was II");
        Console.WriteLine(tarea3.GetSummary());
        Console.WriteLine(tarea3.GetWritingInformation());
    
        
    }
}