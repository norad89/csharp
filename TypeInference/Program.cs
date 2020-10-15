using System;

namespace TypeInference
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 12.5f;
            double d = 130.78;
            decimal dm = 1500.456m;
            double ne = 5e-7;
            var s = "type inference";
            var b = false;
            Console.WriteLine($"{f}, {d}, {dm}, {ne}, {s}, {b}");
        }
    }
}
