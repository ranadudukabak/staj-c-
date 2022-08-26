using System;

namespace P2Q1._1
{
    class Program
    {

        public static String removeDuplicate(string kelime)
        {
            int sayac = 0;
            int kont = 0;

            for (int i = 0; i < kelime.Length; i++)
            {
                for (int j = i + 1; j < kelime.Length; j++)
                {
                    kont = 0;
                    if (kelime[i] == kelime[j])
                    {
                        kont = 1;
                        break;
                    }
                }
                if (kont == 0)
                {
                    sayac++;
                }
            }

            char[] yeni = new char[sayac];


            int tmp = 0;

            for (int i = 0; i < kelime.Length; i++)
            {
                for (int j = i + 1; j < kelime.Length; j++)
                {
                    kont = 0;
                    if (kelime[i] == kelime[j])
                    {
                        kont = 1;
                        break;
                    }

                }

                if (kont == 0)
                {
                    yeni[tmp] = kelime[i];
                    tmp++;
                }

            }

            string yenikelime = new string(yeni);

            return yenikelime;
        }
        static void Main(string[] args)
        {
            string sonuc = removeDuplicate("bimserinternational");

            Console.WriteLine("Girilen kelime içerisinde tekrar eden" +
                " harflerin silinmesi sonucunda oluşan yeni kelime: ");

            for (int i = 0; i < sonuc.Length; i++)
            {
                Console.Write(sonuc[i]);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}