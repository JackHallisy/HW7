
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                // Create entry loop
                Console.WriteLine("Enter text to see if it's a palindrome:");
                string input = Console.ReadLine().ToUpper();
                do
                {
                    //write isPalindrome to return always true;
                    if (IsPalindrome(input))
                    {
                        Console.WriteLine("{0} is a Palindrome.", input);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a Palindrome.", input);
                    }

                    Console.Write("Enter another word or exit to quit");
                    input = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                }
                while (input != "EXIT");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }

        private static bool IsPalindrome(string input)
        {
            if (input == new string(input.Reverse().ToArray()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPalendrome2(string input)
        {

            try
            {
                int length = input.Length;

                for (int wrd = 0; wrd < length / 2; wrd++)
                {
                    input = "";
                    if (input[wrd] != input[length - wrd - 1])
                    {
                        return false;
                    }
                    return true;
                }
                // zero length string 
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


