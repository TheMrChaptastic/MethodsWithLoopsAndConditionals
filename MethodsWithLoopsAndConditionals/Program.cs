using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print 1000 to -1000
            CounterDown();
            Pause();    //waits for input entered 
            //Prints by 3's up to 999
            CounterThree();
            Pause();
            //Ask for 2 numbers then check if they are the same (Defaults to 0 if not integer)
            var n1 = GetNumber();
            var n2 = GetNumber();
            Console.WriteLine(EqualChecker(n1 , n2) ? "They are Equal": "They aren't Equal");
            Pause();
            //Check if input is even or odd (Defaults to 0 if not integer)
            n1 = GetNumber();
            EvenOrOdd(n1);
            Pause();
            //Check if input is Positive or Negative (Defaults to 0 if not integer)
            n1 = GetNumber();
            PosOrNeg(n1);
            Pause();
            //Check if input age can vote (Defaults to 0 if not integer)
            n1 = GetAge();
            CanVote(n1);
            Pause();
            //Check if input is between -10 and 10
            n1 = GetNumber();
            RangeCheck(n1);
            Pause();
            //Shows mult table 1 - 12 for input number
            n1 = GetNumber();
            MultTable(n1);
            Console.WriteLine("This was fun!");
            Pause();
        }

        private static void CounterDown()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        private static void CounterThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        private static bool EqualChecker(int a, int b)
        {
            return (a == b) ? true : false; 
        }

        private static void EvenOrOdd(int num)
        {
            Console.WriteLine((num % 2 == 0) ? "Even Number!" : "Odd Number!");
        }

        private static void PosOrNeg(int num)
        {
            Console.WriteLine((num >= 0) ? "Positive Number!" : "Negative Number!");
        }

        private static void CanVote(int num)
        {
            Console.WriteLine((num >= 18) ? "You can vote!" : "Try again next time!");
        }

        private static void RangeCheck(int num)
        {
            Console.WriteLine((num >= -10 && num <= 10) ? "Its in the range!" : "Out of the range!");
        }

        private static void MultTable(int num)
        {
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }

        private static int GetNumber()
        {
            bool suc = false;
            int number = 0;
            while (suc == false)
            {
                Console.Write("Enter a number: ");
                suc = int.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

        private static int GetAge()
        {
            bool suc = false;
            int number = 0;
            while (suc == false)
            {
                Console.Write("Enter your age: ");
                suc = int.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

        private static void Pause()
        {
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
