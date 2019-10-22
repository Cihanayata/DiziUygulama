using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiziUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            Random rnd = new Random();
            int[] a = new int[10];          
            //1 ile 100 arasında üretilen 10 adet rastgele sayı dizi  içerisine girilecek
            for (int i = 0; i < 10; i++)
            {               
                sayi = rnd.Next(1, 100);

                a[i] = sayi;               
                Console.WriteLine(a[i]);
            }
              for (int i = 0; i < sayi.Length; i++)
            {
                for (int j  = 0; j < sayi.Length; j++)
                {
                    if (dizi[i] < sayi[a])
                    {
                        a = sayi[i];
                        sayi[i] = sayi[j];
                        sayi[j] = a;
                    }
                }

            }
            for (int k = 0; k < sayi.Length; k++)
            {
                Console.WriteLine(sayi[k]);
            }
            Console.ReadKey();
        }
    }
}
