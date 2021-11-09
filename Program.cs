using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your firstname:");

            string firstname = Console.ReadLine();
            Console.WriteLine("hello, " + firstname + "!");
        }
    }

}