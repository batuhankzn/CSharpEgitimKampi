using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loop

            int i;

            for (i = 0; i <= 5; i++)
            {
                Console.WriteLine("C# Eğitim Kampı");
            }

            for (int i = 3; i <= 30; i += 3)
            {
                Console.WriteLine(i);
            }

            int fisinhValue;
            Console.Write("Kaç defa Türkiye yazsın: ");
            fisinhValue = int.Parse(Console.ReadLine());

            for (int i = 0; i < fisinhValue; i++)
            {
                Console.WriteLine("Türkiye");
            }

            #endregion

            #region For Döngüsü ile Karar Yapıları

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " Çift Sayıdır.");
                }
                else
                {
                    Console.WriteLine(i + " Tek Sayıdır.");
                }
            }


            int totalValue = 0;

            for (int i = 1; i <= 10; i++)
            {
                totalValue += i;

            }

            Console.WriteLine(totalValue);


            int count = 0;

            for (int i = 1; i < 50; i++)
            {
                if (i % 7 == 0)
                {

                    count++;

                }
            }

            Console.WriteLine(count);


            int bacterium = 1;

            for (int i = 1; i <= 24; i++)
            {

                bacterium *= 2;
                Console.WriteLine(i + " Saat Sonunda Toplam Bakteri Sayısı: " + bacterium);
            }


            #endregion

            #region While Loop

            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            int i = 1;

            while (i <= 10)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);

                }
                i++;
            }

            int i = 1;

            while (i < 10)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + i * j);
                }
                i++;
            }



            #endregion

            #region Örnek Sınav Sorusu
            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını ekrana yazdıran programı yazınız.

            Console.Write("Sayı Giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = (number / 100);


            Console.WriteLine(hundreds+" + "+ tens + " + " + ones);
            Console.WriteLine("----------------------");
            Console.WriteLine("Birler Basamağı: " + ones);
            Console.WriteLine("Onlar Basamağı: " + tens);
            Console.WriteLine("Yüzler Basamağı: " + hundreds);
            Console.WriteLine("----------------------");

            sum = ones + tens + hundreds;
            Console.WriteLine("Basamakların Toplamı: " + sum);

            #endregion

            Console.Read();
        }
    }
}
