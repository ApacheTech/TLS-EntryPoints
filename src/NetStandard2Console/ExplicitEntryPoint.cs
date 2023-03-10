#if !IMPLICIT
using System;

namespace Net5Console
{
    public class ExplicitEntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Explicit .NET Standard 2.0 Entry Point");
            Console.ReadKey();
        }
    }
}
#endif