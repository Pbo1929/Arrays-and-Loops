using System;

namespace Arrays_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Question1();
            Question2();
            int[] numbers = { 7, 8, 9, 10, 11 };
            PrintFirstAndLast(numbers);
            PrintAllNumbers(numbers);
            PrintAverage(numbers);
            PrintHighestAndLowest(numbers);
        }

        static void Question1() //tick
        { // SB - for i = 1 to 10, but C# we create i
            for(int i = 1; i <= 10; i += 1)
            {
                Console.WriteLine(i);
            }
        }

        static void Question2()
        {
            for(int i = 100; i>=1; i -= 1)
            {
                Console.WriteLine(i);
            }
        }

        //THIS METHOD PRINTS THE FIRST AND LAST INTS IN AN ARRAY
        static void PrintFirstAndLast(int[] numbers)
        {
            int first = 0;
            int last = numbers.Length - 1;
            Console.WriteLine(numbers[first]);
            Console.WriteLine(numbers[last]);
        }
        //THIS IS A METHOD, NOT A FUNCTION
        //THIS IS OOP OBJECT ORIENTED PROGRAMMING
        //USE THE CORRECT LANGUAGE WHEN CODING
        static void PrintAllNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i + " : " + numbers[i]);
            }
        }

        static void PrintAverage(int[] numbers)
        {
            int Total = 0;
            double Average = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Total = Total + numbers[i];
                Average = Total / 5;
                Console.WriteLine(Average);
            }
        }
    }

    static void PrintHighestAndLowest(int[] numbers)
    {
        int highest = numbers[0];
        int lowest = numbers[0];

        for(int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > highest)
            {
                highest = numbers[i];
            }
            else if(numbers[i] < lowest)
            {
                lowest = numbers[i];
            }
        }
    }
}
