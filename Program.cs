using System;
using System.Diagnostics;

namespace MathCompute
{
    class Program
    {
        static void Main(string[] args)
        {
	        Stopwatch timePerCompute;
            double result = 0;
	        int inputNum = 25;   

            Console.WriteLine("Starting MathCompute");
            while(true) {
                timePerCompute = Stopwatch.StartNew();
                for (var i = Math.Pow(inputNum, 6); i >= 0; i--) {    
                    result += Math.Atan(i) * Math.Tan(i);
                };            
                timePerCompute.Stop();
                Console.WriteLine("Elapsed milliseconds : {0}ms", timePerCompute.ElapsedMilliseconds);
            }
        }
    }
}
