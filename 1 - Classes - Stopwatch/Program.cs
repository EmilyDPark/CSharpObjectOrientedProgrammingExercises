using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            Console.WriteLine("Stopwatch has started.\nPress enter to stop.");
            stopwatch.Start();
            Console.ReadLine();

            Console.WriteLine("Stopwatch has stopped.");
            stopwatch.Stop();
            Console.WriteLine($"Duration: {stopwatch.Duration}\n");


            Console.WriteLine("Press enter to run the stopwatch again.");
            Console.ReadLine();

            Console.WriteLine("Stopwatch has started.\nPress enter to stop.");
            stopwatch.Start();
            Console.ReadLine();

            Console.WriteLine("Stopwatch has stopped.");
            stopwatch.Stop();
            Console.WriteLine($"Duration: {stopwatch.Duration}\n");


            Console.WriteLine("Press enter to run the stopwatch again.");
            Console.ReadLine();

            Console.WriteLine("Stopwatch has started.\nPress enter to stop.");
            stopwatch.Start();
            Console.ReadLine();

            Console.WriteLine("Stopwatch has stopped.");
            stopwatch.Stop();
            Console.WriteLine($"Duration: {stopwatch.Duration}\n");


            //stopwatch.Start();
            //stopwatch.Start(); 

        } // Main method

    } // Program class

} // Exercise1_Stopwatch namespace
