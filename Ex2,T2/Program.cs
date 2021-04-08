using System;

namespace Ex2_T2
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Give me your name!!");
        string Name = Console.ReadLine();

        int counter = 0;
        int counter2 = 0;

        while (counter < 10) {
        counter2 = counter;
        
        while (counter2 < 10) {
        System.Console.Write(Name + " ");
        counter2++;
        
        }
        System.Console.WriteLine();
        counter++;
        }



    }
    
}
}


