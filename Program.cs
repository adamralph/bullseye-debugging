using System;
using static Bullseye.Targets;

namespace bullseye_debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += (s, e) =>
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            };

            Target("default", () => Console.WriteLine("Hello World!"));

            RunTargetsAndExit(args);
        }
    }
}
