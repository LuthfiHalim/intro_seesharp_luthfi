using System;
using System.Collections;
using System.Collections.Generic; // untuk nambah List
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;


namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Carts myCarts = new Carts();
            myCarts.AddItem(5000, 3).AddItem(10000, 2).AddItem(4000, 3);

            Console.WriteLine(myCarts.totalOrder());

            myCarts.showAll();

            Console.WriteLine(myCarts.totalPrice());


            //Console.WriteLine(Hash.sha512("Hello World"));

            //List<Log> logs = new List<Log>();
            //logs.Add(LogMessage.create(0, "System unusable"));
            //logs.Add(LogMessage.create(0, "System broken"));
            //logs.Add(LogMessage.create(0, "System failure"));
            //logs.Add(LogMessage.create(1, "Action must be taken Immediately"));
            //logs.Add(LogMessage.create(1, "Do Something!"));
            //logs.Add(LogMessage.create(1, "Need immediate action"));
            //logs.Add(LogMessage.create(2, "Critical condition"));
            //logs.Add(LogMessage.create(2, "Do something"));
            //logs.Add(LogMessage.create(2, "Some system are in critical condition"));
            //logs.Add(LogMessage.create(3, "Error condition"));
            //logs.Add(LogMessage.create(3, "Error report"));
            //logs.Add(LogMessage.create(3, "We can't divide any numbers by zero"));
            //logs.Add(LogMessage.create(4, "Insufficient funds"));
            //logs.Add(LogMessage.create(4, "Warning condition"));
            //logs.Add(LogMessage.create(4, "Be prepared"));
            //logs.Add(LogMessage.create(5, "Check your code"));
            //logs.Add(LogMessage.create(5, "Somethinghappen"));
            //logs.Add(LogMessage.create(5, "Normal but significant condition"));
            //logs.Add(LogMessage.create(6, "Woww amazing"));
            //logs.Add(LogMessage.create(6, "You are doing fine"));
            //logs.Add(LogMessage.create(6, "You win"));
            //logs.Add(LogMessage.create(7, "Debug-level message"));
            //logs.Add(LogMessage.create(7, "Find the Bug"));
            //logs.Add(LogMessage.create(7, "Kill the Bug"));


            //IEnumerable<Log> newLogs = LogMessage.filterByMessage(logs, "system");

            //foreach (Log myLog in newLogs)
            //{
            //    Console.WriteLine(myLog.completeMessage);
            //}

            //Log.createFile(folderNameInCurrentDirectory: "Log", fileName: "App.log");
            //Console.WriteLine(Cipher.Decrypt("t46hUopQ+iOHsceHIWxLe8Fs45lH94/zuCqeZJFC1Xs=", "l123fi89123"));

            //byte[] bytes = { 15, 12, 122, 25 };

            //// If the system architecture is little-endian (that is, little end first),
            //// reverse the byte array.
            //if (BitConverter.IsLittleEndian)
            //    Array.Reverse(bytes);

            //int i = BitConverter.ToInt32(bytes, 0);
            //Console.WriteLine("int: {0}", i);

            //JsonData.grandTotalBelow300k();
            //DataTransaksi databaru = JsonData.findFebruary()[0];
            //Console.WriteLine($"Total belanja Annis {JsonData.findAnnis()}");
            //JsonData.findAri();
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
