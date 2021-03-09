using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRange(100, -100);
            Console.WriteLine();

            PrintThree(-65, 821);
            Console.WriteLine();

            TwoIntegers(8, 9);
            Console.WriteLine();

            EvenOdd(19);
            Console.WriteLine();

            EvenOdd(12);
            Console.WriteLine();

            PositiveNegative(0);
            Console.WriteLine();

            VotingAge(34);
            Console.WriteLine();

            RangeTen(7);
            Console.WriteLine();

            MultiplicationTable(45);
            Console.WriteLine();

        }

        //Write a method that will print to the console all numbers 1000 through -1000.
        public static void PrintRange(int highNumber, int lowNumber)
        {
            for (int i = highNumber; i <= lowNumber; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time.
        public static void PrintThree(int highThree, int lowThree)
        {
            for (int a = highThree; a >= lowThree; a += 3)
            {
                Console.WriteLine(a);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not.
        public static void TwoIntegers(int parameterOne, int parameterTwo)
        {
            if (parameterOne == parameterTwo)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

        }

        //Write a method to check whether a given number is even or odd.
        public static void EvenOdd(int givenNumber)
        {
            

            if (givenNumber % 2 == 0)
            {
                Console.WriteLine($"Number {givenNumber} is an even number.");
            }
            else
            {
                Console.WriteLine($"Number {givenNumber} is an odd number.");
            }
        }

        //Write a method to check whether a given number is positive or negative.

        public static void PositiveNegative(int numberPosNeg)
        {
            if (numberPosNeg > 0)
            {
                Console.WriteLine($"{numberPosNeg} is a positive number.");
            }

            else if (numberPosNeg == 0)
            {
                Console.WriteLine($"The number is zero.");
            }
            
            else
            {
                Console.WriteLine($"{numberPosNeg} is a negative number.");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: use Parse()... or the safer TryParse() for an extra challenge!!

        public static void VotingAge(int votingAge)
        {
            
            if (votingAge >= 18)
            {
                Console.WriteLine("Voter's age meets voting age requirments.");
            }
            else
            {
                Console.WriteLine("Voter's age does not meet voting age requirments.");
            }
        }

        //Write a method to check if an integer (from the user) is in the range -10 to 10.
        public static void RangeTen(int tenRange)
        {

            if (tenRange <= 10 && tenRange >= -10)
            {
                Console.WriteLine("Number is in the proper range of -10 to 10.");
            }
            else
            {
                Console.WriteLine("Number is not in the proper range of -10 to 10.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer.
        public static void MultiplicationTable(int multiNum)
        {
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{multiNum} * {i} = { multiNum* i}");
            }
        }


    }
}
