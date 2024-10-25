using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Methods

            void CustomerList() // Method Signature
            {
                List<string> customers = new List<string>();
                customers.Add("Ali");
                customers.Add("Veli");
                customers.Add("Deli");

                int customerCount = 0;
                foreach (string customer in customers)
                {
                    customerCount++;
                    Console.WriteLine($"{customerCount}. Müşteri: {customer}");
                }
            }

            #endregion


            #region Geriye String Değer Döndürmeyen Metotlar

            void CustomerName(string name)
            {
                Console.WriteLine($"Müşteri Adı: {name}");
            }



            #endregion


            #region Geriye Int Değer Döndürmeyen Metotlar

            void Sum(int number1, int number2)
            {
                int result = number1 + number2;
                Console.WriteLine($"Toplam: {result}");
            }

            #endregion


            #region Geriye Değer Döndüren Metotlar

            string StudentCard()
            {
                string name = "Ali";
                string surname = "Veli";

                return $"{name} {surname}";

            }

            #endregion


            #region Geriye Değer Döndüren String Parametreli Metotlar

            string CountryCard(string countryName, string capital, string flagColor)
            {
                string cardInfo = $"Ülke: {countryName} Başkent: {capital} Bayrak Rengi: {flagColor}";

                return cardInfo ;
            }

            string a, b, c;

            //Console.Write("Ülke Adı: ");
            // a = Console.ReadLine();
            //Console.Write("Başkent: ");
            // b = Console.ReadLine();
            //Console.Write("Bayrak Rengi: ");
            // c = Console.ReadLine();


            #endregion


            #region Geriye Değer Döndüren Int Parametleri Metotlar

            int Sum2
                (int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }
            #endregion


            #region Örnek
                
            string ExamResult(string studentName, int exam1, int exam2, int exam3)
            {
               int result = (exam1 + exam2 + exam3) / 3;
                if (result > 50)
                {
                    return $"{studentName} isimli öğrenci sınıfı geçti";
                }
                else
                {
                    return $"{studentName} isimli öğrenci sınıfta kaldı";
                }

            }


            #endregion


            // CustomerList(); 
            // CustomerName("Ali");
            // Sum(5, 10);
            // Console.WriteLine(StudentCard());
            // Console.WriteLine(CountryCard(a, b, c));
            // Console.WriteLine(Sum2(5, 10));
            // Console.WriteLine(ExamResult("Ali", 50, 60, 70));


            Console.Read();
        }
    }
}
