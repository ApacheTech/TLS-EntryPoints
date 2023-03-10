#if !IMPLICIT
using System;

namespace Net5Console
{
    public class ExplicitEntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Explicit .NET 5 Entry Point");
            Console.ReadKey();
        }
    }
}
#endif