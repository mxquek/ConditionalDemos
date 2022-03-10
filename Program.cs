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

           
            
            Console.WriteLine($"Given a starting num of {startingNum} and a target number of {targetNum}," +
                                $"it's {IsWithinRange(startingNum, targetNum, range)}");
            
        }

        //access modifier - static - return type - name (parms in here)
        private static bool IsWithinRange(int num, int target, int range)
        {
            return ((num - target) < range);
        }
    }
}
