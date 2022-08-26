using System;

namespace P3Q1
{
    class Program
    {       
        static string EnKisaKelime (params string[] kelimeler)
        {
            int boyut = kelimeler.Length;
            int enkisa = kelimeler[0].Length;
            int tut = 0;

            for(int i = 0; i < boyut; i++)
            {
                if(kelimeler[i].Length < enkisa)
                {
                    enkisa = kelimeler[i].Length;
                    tut = i;
                }
            }

            return kelimeler[tut];
        }

        static void Main(string[] args)
        {
            Console.Write("Girdiğiniz kelimeler arasında uzunluğu en kısa olan kelime: ");
            Console.WriteLine(EnKisaKelime("osman", "lelele", "barcelonaaaa", "sişarp", "rana"));
        }
    }
}
