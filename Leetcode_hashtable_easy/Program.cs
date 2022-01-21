using System;

namespace Leetcode_hashtable_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use Main for debugging/ building initial process.
            Console.WriteLine("Process Debugger attached");
            GroupThePeople a = new GroupThePeople();
            Console.WriteLine(a.Grouping(new int[] { 3, 3, 2, 3, 3, 1, 3, 3, 2 }));

        }
    }
}
