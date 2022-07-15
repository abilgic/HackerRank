using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortPalindrome
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string myString)
        {
            var counter=0;
            int length = myString.Length;
            
            for (int i = 0; i < length/2-1; i++)
            {
                if(i+1<length)
                {
                    var a = myString[i];
                    var b = myString[i + 1];
                    var c = myString[length - i - 1 - 1];
                    var d = myString[length - i - 1];

                    if (a == d && b == c)
                    {
                        counter++;
                        Console.WriteLine($"a={a}||b={b}||c={c}||d={d}");
                    }
                }               
            }
            Console.WriteLine($"counter:{counter}");

            //for (int i = 0; i < length / 2; i++)
            //{
            //    if (myString[i] != myString[length - i - 1])
            //        return false;
            //}
            return true;
        }
    }
}
