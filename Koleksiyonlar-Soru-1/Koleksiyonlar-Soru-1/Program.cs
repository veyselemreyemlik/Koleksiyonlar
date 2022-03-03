using System;
using System.Collections;

namespace koleksiyonlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asal = new ArrayList();
            ArrayList noAsal = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                System.Console.Write("Lütfen " + (i + 1) + ". sayıyı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (negatifMi(sayi))
                {
                    int sayac = 0;
                    for (int k = 2; k < sayi; k++)
                    {
                        if (sayi % k == 0)
                        {
                            sayac++;
                        }

                    }
                    if (sayac == 0)
                    {
                        if (sayac == 1)
                        {
                            noAsal.Add(sayi);
                        }
                        else
                            asal.Add(sayi);
                    }
                    else
                    {
                        noAsal.Add(sayi);
                    }


                }
                else
                {
                    System.Console.WriteLine("Lütfen Pozitif ve Numeric Bir sayı Giriniz");
                }

            }
            asal.Sort();
            asal.Reverse();
            noAsal.Sort();
            noAsal.Reverse();

            System.Console.WriteLine("----------Asal Sayılar----------");

            foreach (int item in asal)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("----------Asal Olmayan Sayılar----------");

            foreach (var item in noAsal)
            {
                System.Console.WriteLine(item);
            }

            int toplam1 = 0;
            int toplam2 = 0;
            foreach (int item in asal)
            {
                toplam1 = toplam1 + item;

            }
            System.Console.WriteLine("Asal Sayıların Ortalaması=  " + toplam1 / asal.Count + "  Dizideki Eleman Sayısı= " + asal.Count);
            foreach (int item in noAsal)
            {
                toplam2 = toplam2 + item;

            }
            System.Console.WriteLine("Asal Olmayan Sayıların Ortalaması=  " + toplam1 / asal.Count + "  Dizideki Eleman Sayısı= " + noAsal.Count);
        }

        private static bool negatifMi(int s)
        {
            bool sonuc = true;
            if (s < 0)
            {
                sonuc = false;
            }

            return sonuc;

        }
    }

}