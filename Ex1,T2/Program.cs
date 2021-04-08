using System;

namespace Ex1_T2
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.Write("Please Enter a Name: ");
        string Name = Console.ReadLine();

        System.Console.Write("Enter how many times you want a number to repeat: ");
        string input2 = Console.ReadLine();
        int number = int.Parse(input2);


        int counter = 0;

        while (counter < number) {
        System.Console.Write(Name + " ");
        counter++;
        }

        }
    }
}
