using System;

namespace basicProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number: ");
            int val = Convert.ToInt32(Console.ReadLine());
            if (val % 2 == 0)
            {
                Console.WriteLine(val + " is Even number");
            }
            else
            {
                Console.WriteLine(val + " is Odd number");
            }
        }
    }
}

