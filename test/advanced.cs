using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace test
{
    class advanced
    {
        public static string palindrome(string input)
        {
            string hasil1 = Regex.Replace(Regex.Replace(input.ToLower(), @"\W", ""), @"\d", "");

            char[] balik = input.ToCharArray();
            Array.Reverse(balik);
            string kebalik = new string(balik);
            string hasil2 = Regex.Replace(Regex.Replace(kebalik.ToLower(), @"\W", ""), @"\d", "");

            Console.WriteLine(hasil1);
            Console.WriteLine(hasil2);
            if (string.Compare(hasil1, hasil2) == 0)
            {
                return "palindrome";
            }
            else
            {
                return "bukan palindrome";
            }
        }
        public static void listGabung()
        {
            List<string> first = new List<string>() { "Behind", "every", "great", "man" };
            List<string> second = new List<string>() { "is", "a", "woman" };
            List<string> third = new List<string>() { "rolling", "her", "eyes" };

            List<string> gabung = new List<string>() { string.Join(" ", first.ToArray()), string.Join(" ", second.ToArray()), string.Join(" ", third.ToArray()) };
            string hasil = String.Join(" ", gabung.ToArray());
            Console.WriteLine(hasil);
        }
    }
}
