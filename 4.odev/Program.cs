using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sonuc = new int[7];
            int[] tahmin = new int[7];
            Random rnd = new Random();
            int sayac = 0;

            for (int i = 0; i < tahmin.Length; i++)
            {
                Console.Write((i + 1) + ". sayı için tahmininizi giriniz:");
                tahmin[i] = Convert.ToInt32(Console.ReadLine());

                while (tahmin[i] < 1 || tahmin[i] > 49)
                {
                    Console.WriteLine("Tahminleriniz 1-49 aralığında olmalıdır. Lütfen {0}. sayı için tahmininizi tekrar giriniz.", (i + 1));
                    tahmin[i] = Convert.ToInt32(Console.ReadLine());
                }
                while (Array.IndexOf(tahmin, tahmin[i]) != -1 && Array.IndexOf(tahmin, tahmin[i]) != i)
                {
                    Console.WriteLine((i + 1) + ". tahmininiz daha önceden mevcut. Lütfen yeni bir tahmin giriniz:");
                    Console.Write("Yeni tahmin=");
                    tahmin[i] = Convert.ToInt32(Console.ReadLine());
                }


            }
            Console.WriteLine();
            for (int i = 0; i < sonuc.Length; i++)
            {
                sonuc[i] = rnd.Next(1, 49);
                Console.WriteLine((i + 1) + ". sayının lotodaki sonucu=" + sonuc[i]);
                while (Array.IndexOf(sonuc, sonuc[i]) != -1 && Array.IndexOf(sonuc, sonuc[i]) != i)
                {
                    Console.WriteLine((i + 1) + ". sayı çıktığı için tekrar çekiliyor...");
                    sonuc[i] = rnd.Next(1, 49);
                    Console.WriteLine("Yeni sayı:" + sonuc[i]);
                }

            }
            Console.WriteLine();
            for (int i = 0; i < 7; i++)
            {
                if (sonuc[i] == tahmin[i])
                {
                    sayac++;
                    Console.WriteLine((i + 1) + ". sayıyı doğru bildiniz. Tebrikler.");
                }
            }
            Console.WriteLine(sayac + " tane sayıyı doğru tahmin ettiniz.");
            Console.ReadLine();

        }
    }
}
