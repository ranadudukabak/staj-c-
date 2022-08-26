using System;

namespace P4Q1
{
    class Program
    {
        public static void sirala(int[] dizi)
        {
            for(int i = 0; i < dizi.Length - 1; i++)
            {
                for(int j = 0; j < dizi.Length - i - 1; j++)
                {
                    if(dizi[j] > dizi[j + 1])
                    {
                        int tmp = dizi[j];
                        dizi[j] = dizi[j + 1];
                        dizi[j + 1] = tmp;
                    }
                }
            }

            for(int i = 0; i < dizi.Length - 1; i++)
            {
                Console.Write(dizi[i] + ", ");
            }
            Console.Write(dizi[dizi.Length - 1]);
        }

        static void Main(string[] args)
        {
            Console.Write("Kaç elemanlı dizi gireceğinizi yazınız: ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[boyut];

            for(int i = 0; i < boyut; i++)
            {
                Console.Write("{0}. elemanı giriniz: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            sirala(arr);
        }
    }
}
