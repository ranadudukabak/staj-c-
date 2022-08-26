using System;

namespace P1Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç sayı girmek istediğiniz sorulduktan sonra " +
                "girdiğiniz sayı kadar değer girmeniz istenecek ve bu değerler büyükten küçüğe sıralanacaktır.");
            
            Console.Write("\nKaç sayı girmek istediğinizi yazınız: ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[boyut];

            Console.WriteLine("");
            for(int i = 0; i < boyut; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < boyut - 1; i++)
            {
                for(int j = 0; j < boyut - i - 1; j++)
                {
                    if(sayilar[j] < sayilar[j + 1])
                    {
                        int tmp = sayilar[j];
                        sayilar[j] = sayilar[j + 1];
                        sayilar[j + 1] = tmp;
                    }
                }
            }

            Console.WriteLine("\nGirdiğiniz sayıların büyükten küçüğe sıralanmış hali: ");

            for(int i = 0; i < boyut - 1; i++)
            {
                Console.Write(sayilar[i] + ", ");
            }
            Console.Write(sayilar[boyut - 1]);

            Console.ReadKey();
        }
    }
}
