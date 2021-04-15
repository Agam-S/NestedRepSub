using System;

namespace Ex2_T2
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Enter the amount of lines: ");
        string Lines = Console.ReadLine();
        int number = int.Parse(Lines);

        int counter1 = 0;
        
        while (counter1 < number) {
        int counter2 = 0;
        while (counter2++ < counter1)
        System.Console.Write("x");
        System.Console.WriteLine();
        counter1++;
        
        }  

        }
    
    }
}


