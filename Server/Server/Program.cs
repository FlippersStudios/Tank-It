using System;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "null - Server";
            Server.Start(50, 26950);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
