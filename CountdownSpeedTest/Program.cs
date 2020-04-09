using System;
using static System.DateTime;

namespace CountdownSpeedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Countdown Speed Test. dotNET Core Compiled Edition\nBy Cain Atkinson\nPress enter to run test. Big O calculated by me to be roughly O(0.3n)");
            Console.ReadLine();
            Console.WriteLine();
            // Tests down here
            Console.Write("Running 80 thousand test...");
            double _80k = CountDownTime(80000);
            Console.WriteLine("Done.");
            Console.Write("Running 800 thousand test...");
            double _800k = CountDownTime(800000);
            Console.WriteLine("Done.");
            Console.Write("Running 8 million test...");
            double _8m = CountDownTime(8000000);
            Console.WriteLine("Done.");
            Console.Write("Running 80 million test...");
            double _80m = CountDownTime(80000000);
            Console.WriteLine("Done.");
            Console.Write("Running 150 million test...");
            double _150m = CountDownTime(150000000);
            Console.WriteLine("Done.");
            Console.Write("Running 300 million test...");
            double _300m = CountDownTime(300000000);
            Console.WriteLine("Done.");
            Console.Write("Running 1 billion test...");
            double _1b = CountDownTime(1000000000);
            Console.WriteLine("Done.");
            Console.Write("Running 10 billion test...");
            double _10b = CountDownTime(10000000000);
            Console.WriteLine("Done.");
            // Tests up there
            Console.WriteLine($@"
80 thousand test:  {_80k.ToString()} seconds
800 thousand test: {_800k.ToString()} seconds
8 million test:    {_8m.ToString()} seconds
80 million test:   {_80m.ToString()} seconds
150 million test:  {_150m.ToString()} seconds
300 million test:  {_300m.ToString()} seconds
1 billion test:    {_1b.ToString()} seconds
10 billion test:   {_10b.ToString()} seconds
");
        }

        static double CountDownTime(long n)
        {
            double start = GetRawSeconds(UtcNow);
            CountDown(n);
            double end = GetRawSeconds(UtcNow);
            return end - start;
        }

        static void CountDown(long n)
        { for (long i = n; i > 0; i--) { } }

        static double GetRawSeconds(DateTime dateTime) => (double)(dateTime.Ticks / (double)10000000);
    }
}
