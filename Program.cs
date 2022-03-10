using System;

namespace ConditionalsLoopMethodsDemo
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("Do we have power? [y/n]");
            bool hasPower = Console.ReadLine().ToLower() == "y";

            Console.Write("Do we have paper? [y/n]");
            bool hasPaper = Console.ReadLine().ToLower() == "y";

            Console.Write("What is the ink level?");
            int inkLevel = int.Parse(Console.ReadLine());

            PrintDoc(hasPower, hasPaper, inkLevel);
        }

        //access modifier - static - return type - name (parms in here)

        private static void PrintDoc(bool hasPower, bool hasPaper, int inkLevel)
        {
            Console.WriteLine(hasPaper && hasPower && inkLevel >= 10 ? "Printing" : "Unable to print");
        }
    }
}
