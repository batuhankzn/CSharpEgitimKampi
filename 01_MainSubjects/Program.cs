using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Müşteri Bilgileri
            string customerName;
            string customerSurname;
            string customerEmail;
            string customerPhone;
            string customerDistrict;
            string customerCity;

            customerName = "John";
            customerSurname = "Doe";
            customerEmail = "john@mail.com";
            customerPhone = "0501 234 56 78";
            customerDistrict = "Kadıköy";
            customerCity = "İstanbul";


            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine();

            Console.WriteLine("*****************************");
            Console.WriteLine("Müşteri Adı: " + customerName + " " + customerSurname);
            Console.WriteLine("Müşteri E-Posta: " + customerEmail);
            Console.WriteLine("Müşteri Telefon: " + customerPhone);
            Console.WriteLine("Müşteri İlçe: " + customerDistrict + "/" + customerCity);
            Console.WriteLine("*****************************");

            Console.WriteLine();
            Console.WriteLine();


            customerName = "Jane";
            customerSurname = "Doe";
            customerEmail = "jane@mail.com";
            customerPhone = "0501 234 56 79";
            customerDistrict = "Tuzla";
            customerCity = "İstanbul";

            Console.WriteLine("*****************************");
            Console.WriteLine("Müşteri Adı: " + customerName + " " + customerSurname);
            Console.WriteLine("Müşteri E-Posta: " + customerEmail);
            Console.WriteLine("Müşteri Telefon: " + customerPhone);
            Console.WriteLine("Müşteri İlçe: " + customerDistrict + "/" + customerCity);
            Console.WriteLine("*****************************");

            /*********************************************************************/

            // Sipariş Detayı

            int hamburgerPrice = 20;
            int colaPrice = 5;
            int frenchFriesPrice = 10;
            int pizzaPrice = 25;


            Console.WriteLine("***** Menü Fiyatları *****");

            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("Kola: " + colaPrice + " TL");
            Console.WriteLine("Patates Kızartması: " + frenchFriesPrice + " TL");
            Console.WriteLine("Pizza: " + pizzaPrice + " TL");
            Console.WriteLine();


            int hamburgerCount = 2;
            int colaCount = 1;
            int frenchFriesCount = 1;
            int pizzaCount = 3;

            int totalPrice = 0
                + (hamburgerPrice * hamburgerCount)
                + (colaPrice * colaCount)
                + (frenchFriesPrice * frenchFriesCount)
                + (pizzaPrice * pizzaCount);

            Console.WriteLine("***** Sipariş Detayı *****");
            Console.WriteLine();
            Console.WriteLine("Hamburger Adet: " + hamburgerCount + " Adet");
            Console.WriteLine("Kola Adet: " + colaCount + " Adet");
            Console.WriteLine("Patates Kızartması Adet: " + frenchFriesCount + " Adet");
            Console.WriteLine("Pizza Adet: " + pizzaCount + " Adet");
            Console.WriteLine();
            Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");

            Console.Read();
        }
    }
}
