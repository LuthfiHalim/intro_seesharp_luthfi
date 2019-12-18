using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace test
{
    class Str
    {
        public static string lower(string input)
        {
            return input.ToLower();
        }
        public static string upper(string input)
        {
            return input.ToUpper();
        }
        public static string capitalize(string input)
        { 
            string[] split;
            split = input.ToLower().Split(" ");
            for (int i = 0; i < split.Length; i++)
            {
                split[0].Substring(0).ToUpper();
            }
            input = string.Join(" ", split);
            return input;
        }
        public static string reverse(string input)
        {
            string[] split;
            split = input.ToLower().Split(" ");
            Array.Reverse(split);
            input = string.Join(" ", split);
            return input;
        }
        public static bool contains(string input1,string input2)
        {
            string[] split_input1 = input1.Split(" ");
            string[] split_input2 = input2.Split(" ");

            foreach (var item1 in split_input1)
            {
                foreach (var item2 in split_input2)
                {
                    if(string.Compare(item1,item2) == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static string random(int input = 16)
        {
            string daftar_char = "abcdefghijklmnopqrstuvwxyz123456789";
            Random hasil = new Random();
            List<char> rand = new List<char>();
            for(int i = 0; i < input; i++)
            {
                rand.Add(daftar_char[hasil.Next(daftar_char.Length)]);
            }
            return rand.ToArray().ToString();
        }
        public static int count(string input)
        {
            return input.Length;
        }
        public static int countWords(string input)
        {
            List<string> hasil = input.Split(" ").ToList();
            return hasil.Count;
        }
        public static string trim (string input, int batas = 20, string over = "...")
        {
            if (input.Length <= batas)
            {
                List<char> hasil = new List<char>();
                for (int i = 0; i < input.Length; i++)
                {
                    hasil.Add(input[i]);
                }
                return String.Join("",hasil.ToArray());
            }
            else
            {
                List<char> hasil = new List<char>();
                for (int i = 0; i < batas; i++)
                {
                    hasil.Add(input[i]);
                }
                return String.Join("", hasil.ToArray()) + over;
            }
        }
        public static string trimWords(string input, int batas = 20, string over = "...")
        {
            string[] input_split = input.Split(" ");
            if (input_split.Length <= batas)
            {
                List<string> hasil = new List<string>();
                for (int i = 0; i < input_split.Length; i++)
                {
                    hasil.Add(input_split[i]);
                }
                return String.Join(" ",hasil.ToArray());
            }
            else
            {
                List<string> hasil = new List<string>();
                for (int i = 0; i < batas; i++)
                {
                    hasil.Add(input_split[i]);
                }
                return String.Join(" ", hasil.ToArray()) + over;
            }
        }
    }
}
