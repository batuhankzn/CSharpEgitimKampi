using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop

            string[] cities = { "New York", "London", "Mumbai", "Chicago" };

            foreach (string city in cities)
            {
                //Console.WriteLine(city);
            }

            int[] numbers = { 265, 235, 1122, 976, 2646, 956, 2326, 65 };
            int total = 0;

            foreach (int number in numbers)
            {
                //if (number % 2 == 0)
                //{
                //    Console.WriteLine(number);
                //}
                total += number;

            }
            // Console.WriteLine(total);

            string word = "Hello World";
            foreach (char letter in word)
            {
                //Console.WriteLine(letter);
            }

            #endregion


            #region Örnek Sınav Sistemi

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması*****");
            Console.WriteLine();
            Console.WriteLine();

            // Öğrenci Sayısını kullanıcıdan alma
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Sınıftaki Öğrenci Sayısı");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");

            // Öğrenci Adlarını ve Notlarını tutacak dizileri oluşturma
            string[] studentNames = new string[studentCount];
            double[] studenExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismi: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // her öğrenci için 3 sınav notu al
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notu: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz
                }

                Console.WriteLine();
                studenExamAvg[i] = totalExamResult / 3; //ortalama hesaplama

            }


            // öğrencilerin ortalamsı 




            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studenExamAvg[i]}");


                //öğrencilerin geçip/kalma durumu

                if (studenExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci sınavı geçti.");

                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci sınavı geçemedi.");
                }

                Console.WriteLine("---------------------------------------------");

            }



            #endregion

            Console.Read();
        }
    }
}
