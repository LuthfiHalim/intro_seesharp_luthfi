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
            string data = @"NAME, CATEGORY, PRICE
Xiaomi Redmi 5A, Smartphone, 1199000
Macbook Air, Laptop, 13775000
Samsung Galaxy J7, Smartphone, 3549000
DELL XPS 13, Laptop, 26799000
Xiaomi Mi 6, Smartphone, 5399000
LG V30 Plus, Smartphone, 10499000";

            List<string> hasil = data.Split("\n").ToList();
            List<Dictionary<string, string>> hasil_akhir = new List<Dictionary<string, string>>();

            foreach (var item in hasil)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < hasil.Count - 1; i++)
            {
                string[] temp = hasil[i + 1].Split(", ");
                Dictionary<string, string> tampung = new Dictionary<string, string>();
                tampung.Add("name", temp[0]);
                tampung.Add("price", $"Rp {temp[2]}");
                tampung.Add("category", temp[1]);
                hasil_akhir.Add(tampung);
            }
            Console.WriteLine(hasil_akhir);

            /*List Gabung*/
            //advanced.listGabung();

            /*Palindrome*/
            //string input = Console.ReadLine();
            //Console.WriteLine(advanced.palindrome(input));

            // add function here
        }
    }
}
