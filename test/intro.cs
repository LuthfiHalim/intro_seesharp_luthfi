using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace test
{
    class Intro
    {
        public static int luthfi = 100;
        public static void JumlahKarakter()
        {
            Console.Write("Input:");
            String input = Console.ReadLine();
            Console.WriteLine($"Output: {input.Length}");
            Console.Write("Input:");
            input = Console.ReadLine();
            Console.WriteLine($"Output: {input.Length}");
        }
        public static void grade()
        {
            Console.Write("Input:");
            int input = Int32.Parse(Console.ReadLine());
            if (input < 60)
            {
                Console.WriteLine("Output: E");
            }
            else if (input < 70)
            {
                Console.WriteLine("Output: D");
            }
            else if (input < 80)
            {
                Console.WriteLine("Output: C");
            }
            else if (input < 90)
            {
                Console.WriteLine("Output: B");
            }
            else if (input < 101)
            {
                Console.WriteLine("Output: A");
            }
            else
            {
                Console.WriteLine("Salah Input Nilai");
            }
        }
        public static void ganjilgenap()
        {
            Console.Write("Input:");
            int input = Int32.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("Output: Genap");
            }
            else
            {
                Console.WriteLine("Output: Ganjil");
            }
        }
        public static void kabisat()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Input:");
                int input = Int32.Parse(Console.ReadLine());

                if (input % 400 == 0)
                {
                    Console.WriteLine("Output: Kabisat");
                }
                else if (input % 100 == 0)
                {
                    Console.WriteLine("Output: Bukan Kabisat");
                }
                else if (input % 4 == 0)
                {
                    Console.WriteLine("Output: Kabisat");
                }
                else
                {
                    Console.WriteLine("Output: Bukan Kabisat");
                }
            }
        }
        public static void filmRating()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Masukan Umur: ");
                int input = Int32.Parse(Console.ReadLine());
                if (input < 9)
                {
                    Console.WriteLine("Output: SEMUA UMUR");
                }
                else if (input < 13)
                {
                    Console.WriteLine("Output: BIMBINGAN ORANG TUA");
                }
                else if (input < 21)
                {
                    Console.WriteLine("Output: REMAJA");
                }
                else
                {
                    Console.WriteLine("Output: DEWASA");
                }
            }
        }
        public static void loop_with_range()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Input 1: ");
                int input1 = Int32.Parse(Console.ReadLine());
                Console.Write("Input 2: ");
                int input2 = Int32.Parse(Console.ReadLine());

                if (input1 <= input2)
                {
                    Console.Write("Output: ");
                    for (int j = input1; j <= input2; j++)
                    {
                        Console.Write($"{j} ");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write("Output: ");
                    for (int j = input1; j >= input2; j--)
                    {
                        Console.Write($"{j} ");
                    }
                    Console.WriteLine("");
                }
            }
        }
        public static void oddinrange()
        {
            Console.Write("Input:");
            int input = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i},");
                }
            }
        }
        public static void ganjil_genap_kelipatan()
        {
            Console.Write("Masukan Input: ");
            int input = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"{i}. Bilangan Nol");
                }
                else if (i % 100 == 0)
                {
                    Console.WriteLine($"{i}. Kelipatan Seratus");
                }
                else if (i % 10 == 0)
                {
                    Console.WriteLine($"{i}. Genap Kelipatan Lima");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i}. Ganjil Kelipatan Lima");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}. Genap");
                }
                else
                {
                    Console.WriteLine($"{i}. Ganjil");
                }
            }
        }
        public static void reverse_word()
        {
            Console.Write("Input:");
            string input = Console.ReadLine();

            string[] text = input.Split(" ");
            Array.Reverse(text);
            input = String.Join(" ", text);
            Console.Write(input);


        }
        public static void add_to_array()
        {
            string[] awal = { "meja", "buku", "topi", "baju", "kayu" };
            List<string> simpan = awal.ToList();

            foreach (var item in simpan)
            {
                Console.Write($"{item},");
            }
            Console.WriteLine("");
            Console.Write("Input:");
            string input1 = Console.ReadLine();

            Console.Write("Input:");
            string input2 = Console.ReadLine();

            simpan.Insert(0, input1);
            simpan.Add(input2);

            foreach (var item in simpan)
            {
                Console.Write($"{item},");
            }
        }
    }
}
