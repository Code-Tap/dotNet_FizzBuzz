using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string Buzzer(int i) {
                string msg = "";
                if ( i % 3 == 0) { msg += "Fizz"; }
                if ( i % 5 == 0) { msg += "Buzz"; }
                return (msg);
            }

            for ( int i = 0; i < 20; i++)
                Console.WriteLine($"{i} :: {Buzzer(i)}");
        }
    }
}