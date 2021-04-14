using System;

namespace Ex2_T2
{
    class Program
    {
        static void Main(string[] args)
        {
        int counter = 0;
        int counter2 = 0;
        
        while (counter < 5) {
        counter++;
        
        while (counter2 < counter) {
        System.Console.Write("x");
        counter2++;
        }
        
        System.Console.WriteLine();
       
        }


        }
    
    }
}


