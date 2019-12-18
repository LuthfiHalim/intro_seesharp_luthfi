using System;
using System.Collections.Generic; // untuk nambah List
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;


namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonData.findAri();
            //string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            //Console.WriteLine(Str.trim(text));

            /*Count Words*/
            //advanced.countWords();

            /*Censoring Word*/
            //Console.WriteLine(advanced.censorWord());

            /*CSV Object*/
            //advanced.csvObject();

            /*List Gabung*/
            //advanced.listGabung();

            /*Palindrome*/
            //string input = Console.ReadLine();
            //Console.WriteLine(advanced.palindrome(input));

            // add function here
        }
    }
}
