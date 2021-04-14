using System;

namespace NestedSubTask
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Number of x's");
        string X = Console.ReadLine();

        int counter = 0;
        int counter2 = 0;
        int number = int.Parse(X);

        while (counter < number) {
        counter2 = counter;
        
        while (counter2 < number) {
        System.Console.Write("x");
        counter2++;
        
        }
        System.Console.WriteLine();
        counter++;
        }



    }
    
}
}


