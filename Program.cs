using System;

namespace FloatPointDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse("-0.41404453737343927");
            var i = double.Parse("-0.11823238255337409");

            Console.WriteLine("Atan2 {0:R}", Math.Atan2(i, r));
            Console.WriteLine("Atan {0:R}", Math.Atan(i / r));
            Console.WriteLine("Atan-Pi {0:R}", Math.Atan(i / r) - Math.PI);
            Console.ReadLine();
        }
    }
}
