using System;

namespace P1Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girdiğiniz iki sayı arasındaki asal sayılar listelenecektir.");

            Console.Write("Aralığın başlangıç değerini giriniz: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());

            if (baslangic < 2)
            {
                baslangic = 2;
            }

            Console.Write("Aralığın bitiş değerini giriniz: ");

            int bitis = Convert.ToInt32(Console.ReadLine());

            int kontrol = 0;

            for (int i = baslangic; i < bitis; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    kontrol = 0;
                    if (i % j == 0)
                    {
                        kontrol = 1;
                        break;
                    }
                }
                if (kontrol == 0)
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
