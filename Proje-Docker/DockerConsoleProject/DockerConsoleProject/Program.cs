using System;

namespace DockerConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 1000)
            {
                Console.WriteLine($"{i} - Hello World!");
                i++;
                System.Threading.Thread.Sleep( 500 );
            }
        }
    }
}
