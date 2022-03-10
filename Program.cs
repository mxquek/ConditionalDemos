using System;

namespace ConditionalsLoopMethodsDemo
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int startingNum = int.Parse(Console.ReadLine());

            Console.Write("Enter a target number: ");
            int targetNum = int.Parse(Console.ReadLine());

            Console.Write("Enter a range: ");
            int range = int.Parse(Console.ReadLine());

            string output = IsWithinRange(startingNum, targetNum, range) ? "It is within range." : "It is not within range.";

            Console.WriteLine($"Given a starting num of {startingNum} and a target number of {targetNum}, {output}");
        }

        //access modifier - static - return type - name (parms in here)
        private static bool IsWithinRange(int num, int target, int range)
        {
            return (Math.Abs(num - target) < range);
        }
    }
}
