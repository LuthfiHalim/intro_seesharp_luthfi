using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace test
{
    class Advanced
    {
        public static string palindrome(string input)
        {
            string hasil1 = Regex.Replace(input.ToLower(), @"[\W\d]", "");

            char[] balik = input.ToCharArray();
            Array.Reverse(balik);
            string kebalik = new string(balik);
            string hasil2 = Regex.Replace(kebalik.ToLower(), @"[\W\d]", "");

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
        public static void csvObject()
        {
            string data = @"NAME, CATEGORY, PRICE
Xiaomi Redmi 5A, Smartphone, 1199000
Macbook Air, Laptop, 13775000
Samsung Galaxy J7, Smartphone, 3549000
DELL XPS 13, Laptop, 26799000
Xiaomi Mi 6, Smartphone, 5399000
LG V30 Plus, Smartphone, 10499000";

            List<string> hasil = data.Split("\n").ToList();
            List<Data> hasil_akhir = new List<Data>();

            foreach (var item in hasil)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < hasil.Count - 1; i++)
            {
                string[] temp = hasil[i + 1].Split(", ");

                Data baru = new Data();

                baru.name = temp[0];
                baru.price = int.Parse(temp[2]);
                baru.category = temp[1];
                
                hasil_akhir.Add(baru);
            }
            foreach (var item in hasil_akhir)
            {
                Console.WriteLine($"Product: {item.name} adalah {item.category} dengan harga: {item.price.ToString("C")}");
            }
            IEnumerable<Data> query = hasil_akhir.OrderByDescending(hasil_akhir => hasil_akhir.price);
            Console.WriteLine("Setelah di urutan berdasarkan harga\n");
            foreach (var item in query)
            {
                Console.WriteLine($"Product: {item.name} adalah {item.category} dengan harga: {item.price.ToString("C")}");
            }
        }
        public static string censorWord()
        {
            string[] censor_word = { "dolor", "elit", "quis", "nisi", "fugiat", "proident", "laborum" };

            string input = @"Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            foreach (var item in censor_word)
            {
                List<char> bintang = new List<char>();
                for (int i = 0; i < item.Length; i++)
                {
                    bintang.Add('*');
                }
                input = input.Replace(item, string.Join("", bintang));
            }
            Console.WriteLine(input);
            return input;
        }
        public static void countWords()
        {
            string input = @"Aku ingin begini
            Aku ingin begitu
            Ingin ini itu banyak sekali

            Semua semua semua
            Dapat dikabulkan
            Dapat dikabulkan
            Dengan kantong ajaib

            Aku ingin terbang bebas
            Di angkasa
            Hei… baling baling bambu

            La... la... la...
            Aku sayang sekali
            Doraemon

            La... la... la...
            Aku sayang sekali";

            input = Regex.Replace(input.ToLower(), @"\n", " ");
            string[] split_word = input.Split(" ");

            string[] count_words = { "aku", "ingin", "dapat" };

            int[] hitung = { 0, 0, 0 };

            for (int i = 0; i < hitung.Length; i++)
            {
                foreach (var item2 in split_word)
                {
                    if (string.Compare(count_words[i], item2) == 0)
                    {
                        hitung[i]++;
                    }
                }
                Console.WriteLine($"kata '{count_words[i]}' terdapat sebanyak {hitung[i]}");
            }
        }
    }
    class Data
    {
        public string name { get; set; }
        public int price { get; set; }
        public string category { get; set; }
    }
}
