using System;


namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many days have you lived?");
            var days = Convert.ToInt32(Console.ReadLine());
            double years = days / 365;
            double mounths = days % 365 / 30;
            Console.WriteLine($"You have lived for {years} years and {mounths} mounths");
            Console.ReadLine();  
        }
    }
}
