using System;

namespace Experiment.ConsoleClearNotClearingConsoleBuffer.Experiment01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (var count = 0; count < 100; count++)
                Console.WriteLine($"#{count}: This line should be cleared.");
            Console.Clear();
            Console.WriteLine("Check if all lines have been deleted by manipulating the console scroll bar.");
            Console.WriteLine("And compare it with the result of running the cls command.");
        }
    }
}
