using System;

namespace FindStrDig
{
    public class FindLetterDigit
    {
        public static void Main()
        {
            int letter, digit;
            letter = 0;
            digit = 0;

            Console.Write("Enter the string: ");
            string str = Console.ReadLine();
          
            for(int i=0; i < str.Length; i++)
            {
                if((str[i] >= '0' && str[i] <= '9' ))
                {
                    digit++;
                }
                else if((str[i] >= 'a' && str[i] <= 'z') ||(str[i] >= 'A' && str[i] <='B' ))
                {
                    letter++;
                }
            }
            Console.WriteLine("Number of alphabet in given string is: "+letter);
            Console.WriteLine("Number of Digit in given string is: "+digit);
        }
        

    }
}
