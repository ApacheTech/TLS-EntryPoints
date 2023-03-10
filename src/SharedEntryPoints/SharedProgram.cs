using System;
using System.Reflection;

namespace SharedEntryPoints
{
    public class SharedProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Shared Entry Point");
            Console.WriteLine("Calling Assembly: {0}", Assembly.GetCallingAssembly());
            Console.WriteLine("Executing Assembly: {0}", Assembly.GetExecutingAssembly());
            Console.WriteLine("Entry Assembly: {0}", Assembly.GetEntryAssembly());
            Console.ReadKey();
        }
    }
}