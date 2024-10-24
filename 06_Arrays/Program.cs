using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            string[] colors = new string[4];
            colors[0] = "Red";
            colors[1] = "Blue";
            colors[2] = "Green";
            colors[3] = "Yellow";

            //Console.Write(colors[2]);

            int[] number = new int[10];
            number[0] = 17;
            number[3] = 25;
            number[6] = 97;
            number[9] = 45;


            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            #endregion


            #region Dizideki Tüm Elemanları Listeleme

            string[] colors2 = { "Red", "Blue", "Green", "Yellow", "Black", "White" };

            for (int i = 0; i < colors2.Length; i++)
            {
                Console.WriteLine(colors2[i]);
            }


            //Liste elemenlarının 3e tam bölünenleri yazdırma
            int[] numbers = { 17, 25, 97, 45, 12, 34, 56, 78, 90, 100 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            int[] myArray = { 79,65,22,1,654,321,361,1967 };
            int maxNumber = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNumber)
                {
                    maxNumber = myArray[i];
                }

                
            }
           // Console.WriteLine("Max Number: " + maxNumber);

            Array.Sort(myArray);
            for (int i = 0; i < myArray.Length; i++)
            {
                //Console.WriteLine(myArray[i]);
            }


            #endregion


            #region Dizi Metotlar

            string[] customers = { "Ali", "Veli", "Deli", "Mehmet", "Ahmet", "Ayşe", "Fatma", "Zeynep" };
            int index = Array.IndexOf(customers, "Mehmet");
            Console.WriteLine("Index: " + index);

            #endregion


            #region Kullanıcıdan Değer Alarak Dizi Oluşturma

            string[] cities = new string[5];

            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"Lütfen {i + 1}. Şehir Giriniz: ");
                cities[i] = Console.ReadLine();
            }

            Console.WriteLine("Şehirler Listesi");
            Console.WriteLine();
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            #endregion


            #region Dizi içindeki tek ve çift ayrı listeleme
            int[] numbers2 = { 32, 42, 53, 89, 12, 45, 78, 96, 100, 1 };

            Console.WriteLine("Tek Sayılar");

            for (int i = 0; i < numbers2.Length; i++)
            {
                if (numbers2[i] % 2 != 0)
                {
                    Console.WriteLine(numbers2[i]);
                }
            }

            Console.WriteLine("-----------------");


            Console.WriteLine("Çift Sayılar");

            for (int k = 0; k < numbers2.Length; k++)
            {
                if (numbers2[k] % 2 == 0)
                {
                    Console.WriteLine(numbers2[k]);
                }
            }

            #endregion


            Console.Read();
        }
    }
}
