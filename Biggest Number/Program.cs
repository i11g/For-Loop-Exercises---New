﻿namespace Biggest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0; 

            for (int i = 0; i <num; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum+=numbers;

            }
            Console.WriteLine(sum); 
        }
    }
}