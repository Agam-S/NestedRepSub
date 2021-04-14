using System;

namespace NestedSubTask
{
    class Program
    {
        static void Main(string[] args)
        {
        int counter = 0;
        int counter2 = 0;

        while (counter < 5) {
        counter2 = counter;
        
        while (counter2 < 5) {
        System.Console.Write("x");
        counter2++;
        
        }
        System.Console.WriteLine();
        counter++;
        }



    }
    
}
}


