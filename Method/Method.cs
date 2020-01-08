using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Fungsi
{
    public class Method
    {
        public static int luthfi = 100;
        public static int JumlahKarakter(string input)
        {
            return input.Length;
        }
        public static char grade(int input)
        {
            if (input < 60)
            {
                return 'E';
            }
            else if (input < 70)
            {
                return 'D';
            }
            else if (input < 80)
            {
                return 'C';
            }
            else if (input < 90)
            {
                return 'B';
            }
            else if (input < 101)
            {
                return 'A';
            }
            else
            {
                return '?';
            }
        }
        public static string ganjilgenap(int input)
        {
            if (input % 2 == 0)
            {
                return "Genap";
            }
            else
            {
                return "Ganjil";
            }
        }
        public static string kabisat(int input)
        {
            if (input % 400 == 0)
            {
                return "Kabisat";
            }
            else if (input % 100 == 0)
            {
                return "Bukan Kabisat";
            }
            else if (input % 4 == 0)
            {
                return "Kabisat";
            }
            else
            {
                return "Bukan Kabisat";
            }
        }
        public static string filmRating(int input)
        {
            if (input < 9)
            {
                return "SEMUA UMUR";
            }
            else if (input < 13)
            {
                return "BIMBINGAN ORANG TUA";
            }
            else if (input < 21)
            {
                return "REMAJA";
            }
            else
            {
                return "DEWASA";
            }
        }
        public static List<int> loop_with_range(int input1, int input2)
        {
            if (input1 <= input2)
            {
                List<int> temp = new List<int>();
                for (int j = input1; j <= input2; j++)
                {
                    temp.Add(j);
                }
                return temp;
            }
            else
            {
                List<int> temp = new List<int>();
                for (int j = input1; j >= input2; j--)
                {
                    temp.Add(j);
                }
                return temp;
            }
        }
        public static List<int> oddinrange(int input)
        {
            //return Enumerable.Range(0, input).Where(e => e%2==0).ToList();
            List<int> temp = new List<int>();
            for (int i = 0; i < input; i++)
            {
                if (i % 2 != 0)
                {
                    temp.Add(i);
                }
            }
            return temp;
        }
        public static List<string> ganjil_genap_kelipatan(int input)
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < input; i++)
            {
                if (i == 0)
                {
                    temp.Add($"{i}. Bilangan Nol");
                }
                else if (i % 100 == 0)
                {
                    temp.Add($"{i}. Kelipatan Seratus");
                }
                else if (i % 10 == 0)
                {
                    temp.Add($"{i}. Genap Kelipatan Lima");
                }
                else if (i % 5 == 0)
                {
                    temp.Add($"{i}. Ganjil Kelipatan Lima");
                }
                else if (i % 2 == 0)
                {
                    temp.Add($"{i}. Genap");
                }
                else
                {
                    temp.Add($"{i}. Ganjil");
                }
            }
            return temp;
        }
        public static string reverse_word(string input)
        {
            string[] text = input.Split(' ');
            Array.Reverse(text);
            return String.Join(" ", text);
        }
        public static List<string> add_to_array(string inputAwal, string[] inputTengah, string inputAkhir)
        {
            var hasil = inputTengah.ToList();
            hasil.Insert(0, inputAwal);
            hasil.Add(inputAkhir);

            return hasil;
        }
    }
}
