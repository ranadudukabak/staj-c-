using System;

namespace P1Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime = "Bi3ms4er76";

            int[] tmpDeger = new int[kelime.Length];
            int[] charDeger = new int[kelime.Length];

            int sayac = 0;

            for (int i = 0; i < kelime.Length; i++)
            {
                tmpDeger[i] = Convert.ToChar(kelime[i]);

                if (tmpDeger[i] >= 48 && tmpDeger[i] <= 57)
                {
                    charDeger[sayac] = Convert.ToInt32(kelime[i]);
                    sayac++;
                }
                    
            }

            int[] sonDeger = new int[sayac];
            char[] dizi = new char[sayac];

            for (int i = 0; i < sayac; i++)
            {
                sonDeger[i] = Convert.ToInt32(charDeger[i]);
            }

            for (int i = 0; i < sayac - 1; i++)
            {
                for (int j = 0; j < sayac - i - 1; j++)
                {
                    if (sonDeger[j] > sonDeger[j + 1])
                    {
                        int tmp = sonDeger[j];
                        sonDeger[j] = sonDeger[j + 1];
                        sonDeger[j + 1] = tmp;
                    }
                }
            }

            Console.WriteLine("Kelimede bulunan rakamların küçükten büyüğe sıralanmış hali: ");
            for (int i = 0; i < sayac; i++)
            {
                dizi[i] = Convert.ToChar(sonDeger[i]);
            }
            for (int i = 0; i < sayac - 1; i++)
            {
                Console.Write(dizi[i] + ", ");
            }
            Console.Write(dizi[sayac - 1]);

            Console.ReadKey();
        }
    }
}
