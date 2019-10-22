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
            for (int i = 0; i < a.Length; i++)
            {
                for (int b = 0; b < a.Length; b++)
                {
                    if (a[i] < a[b])
                    {
                        cihan = a[i];
                        a[i] = a[b];
                        a[b] = cihan;
                    }
                }

            }
            for (int k = 0; k < a.Length; k++)
            {
                Console.WriteLine(a[k]);
            }
            Console.ReadKey();
        }
    }
}
