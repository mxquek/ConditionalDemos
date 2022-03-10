using System;

namespace ConditionalsLoopMethodsDemo
{
    class MainClass
    {
        static void Main()
        {
            
        }

        //access modifier - static - return type - name (parms in here)
        private static bool IsWithinRange(int num, int target, int range)
        {
            return ((num - target) < range);
        }
    }
}
