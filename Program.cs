using System;

namespace P4Q2
{
    class Program
    {
        public static int hesapla(int[] rakamlar)
        {
            int boyut = rakamlar.Length;
            int tmp = boyut;

            int fakt = 1;
            int toplam = 0;

            while (tmp >= 1)
            {
                toplam = 0;
                fakt = 1;
                for (int i = boyut; i >= tmp; i--)
                {
                    fakt = fakt * i;
                    toplam += fakt;
                    //Console.WriteLine(toplam);
                }
                tmp--;
            }

            return toplam;
        }

        static void Main(string[] args)
        {
            Console.Write("Kaç rakamlı dizi girileceğini yazınız (Lütfen 1 ile 10 arasında bir sayı giriniz): ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            int[] rakamlar = new int[boyut];

            for (int i = 0; i < boyut; i++)
            {
                Console.Write("{0}. elemanı giriniz: ", i + 1);
                rakamlar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write(hesapla(rakamlar));
            Console.ReadKey();
        }
    }
}
