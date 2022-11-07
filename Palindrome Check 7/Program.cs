using System;

namespace Palindrome_Check_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to check palindrome : \n");
            string word = Console.ReadLine();
            palindrome(word);
        }
        public static bool palindrome(string word)
        {
            string first = word.Substring(0, word.Length / 2);
            char[] arr = word.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);


            var status = first.Equals(second);

            if (status == true)
            {
                Console.WriteLine(word + " : is a palindrome word \n");
            }
            else
            {
                Console.WriteLine(word + " : is a not palindrome word \n");
            }
            return status;
        }

        //public static string palindrome(string word)
        //{
        //    string first = word.Substring(0, word.Length / 2);
        //    char[] arr = word.ToCharArray();

        //    Array.Reverse(arr);

        //    string temp = new string(arr);
        //    string second = temp.Substring(0, temp.Length / 2);


        //    var status = first.Equals(second);

        //    if (status == true)
        //    {
        //        Console.WriteLine("true");
        //    }
        //    else
        //    {
        //        Console.WriteLine("false");
        //    }
        //    return word;
        //}


    }
}
