#if !IMPLICIT
using System;

namespace Net7Console
{
    public class ExplicitEntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Explicit .NET 7 Entry Point");
            Console.ReadKey();
        }
    }
}
#endif