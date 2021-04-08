using System;

namespace Ex1T1
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Give me your name!!");
        string Name = Console.ReadLine();

        int counter0 = 0;
        int counter = 0;

        while (counter0 < 10) {
        counter0 = counter;
        
        while (counter < 10) {
        System.Console.Write(Name + " ");
        counter++;
        }

        
        }


        }
        
        
    }
}    



