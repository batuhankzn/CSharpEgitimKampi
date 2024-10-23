using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else yapısı


            Console.Write("Lütfen şifrenizi giriniz: ");
            string password = Console.ReadLine();
            if (password == "1234")
            {
                Console.WriteLine("Şifre doğru. Giriş yapabilirsiniz.");
            }
            else
            {
                Console.WriteLine("Şifre yanlış. Tekrar deneyiniz.");
            }


            int exam1, exam2, average;
            string result;


            Console.Write("1. Sınav Notunuzu Giriniz: ");
            exam1 = int.Parse(Console.ReadLine());

            Console.Write("2. Sınav Notunuzu Giriniz: ");
            exam2 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2) / 2;



            if (average > 0 & average <= 50)
            {
                result = "Kötü";
            }
            if (average > 50 & average <= 70)
            {
                result = "Orta";
            }
            if (average > 70 & average <= 85)
            {
                result = "İyi";
            }
            if (average > 85 & average <= 100)
            {
                result = "Çok İyi";
            }
            else { result = "Geçersiz"; }

            Console.WriteLine("Ortalamanız " + average + ": " + result);



            string city;
            Console.Write("Şehir ismi giriniz: ");
            city = Console.ReadLine();

            if (city == "trabzon" | city == "ankara")
            {
                Console.WriteLine("Girilen şehir doğru.");
            }
            else
            {
                Console.WriteLine("Girilen şehir yanlış.");
            }

            #endregion

            #region mod işlemleri

            int number;
            Console.Write("Bir sayı giriniz: ");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Girilen sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girilen sayı tektir.");
            }

            char team;
            Console.Write("Takımınızı seçiniz: ");
            team = char.Parse(Console.ReadLine());

            if (team == 'G' | team == 'g')
            {
                Console.WriteLine("Galatasaray");
            }
            else if (team == 'T' | team == 't')
            {
                Console.WriteLine("Trabzonspor");
            }
            else if (team == 'B' | team == 'b')
            {
                Console.WriteLine("Beşiktaş");
            }
            else
            {
                Console.WriteLine("Geçersiz takım.");
            }

            #endregion

            #region Restoran Menüsü Uygulaması

            Console.WriteLine("**** C# Eğitim Kampı Restoran ****");
            Console.WriteLine();

            Console.WriteLine("Menü Seçiniz");
            Console.WriteLine("1. Yemek Menüsü");
            Console.WriteLine("2. İçecek Menüsü");
            Console.WriteLine("3. Tatlı Menüsü");
            Console.WriteLine();


            string menuItem;

            Console.Write("Menüyü Görmek İçin Numara Giriniz: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("----------Yemek Menüsü----------");
                Console.WriteLine("1. Kuru Fasulye");
                Console.WriteLine("2. İskender");
                Console.WriteLine("3. Tavuklu Pilav");
            }
            else if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("----------İçecek Menüsü----------");
                Console.WriteLine("1. Ayran");
                Console.WriteLine("2. Kola");
                Console.WriteLine("3. Limonata");
            }
            else if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("----------Tatlı Menüsü----------");
                Console.WriteLine("1. Kadayıf");
                Console.WriteLine("2. Baklava");
                Console.WriteLine("3. Sütlaç");
            }


            #endregion

            #region Switch Case Yapısı

            Console.Write("Lütfen ay numarası giriniz: ");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1: Console.WriteLine("Ocak"); break;
                case 2: Console.WriteLine("Şubat"); break;
                case 3: Console.WriteLine("Mart"); break;
                case 4: Console.WriteLine("Nisan"); break;
                case 5: Console.WriteLine("Mayıs"); break;
                case 6: Console.WriteLine("Haziran"); break;
                case 7: Console.WriteLine("Temmuz"); break;
                case 8: Console.WriteLine("Ağustos"); break;
                case 9: Console.WriteLine("Eylül"); break;
                case 10: Console.WriteLine("Ekim"); break;
                case 11: Console.WriteLine("Kasım"); break;
                case 12: Console.WriteLine("Aralık"); break;

                default: Console.WriteLine("Geçersiz ay numarası."); break;

            }



            #endregion

            #region Hesap Makinesi Uygulaması

            int number1, number2;
            char symbol;

            Console.Write("1. Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("İşlemi Seçiniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch(symbol)
            {
                case '+': Console.WriteLine(number1+" "+symbol+" "+number2+" = " + (number1 + number2) + " Toplama İşlemi "); break;
                case '-': Console.WriteLine(number1 + " " + symbol + " " + number2 + " = " + (number1 - number2) + " Çıkarma İşlemi "); break;
                case '*': Console.WriteLine(number1 + " " + symbol + " " + number2 + " = " + (number1 * number2) + " Çarpma İşlemi "); break;
                case '/': Console.WriteLine(number1 + " " + symbol + " " + number2 + " = " + (number1 / number2) + " Bölme İşlemi "); break;

                default: Console.WriteLine("Geçersiz işlem."); break;
            }

            #endregion

            Console.Read();
            }
        }
    }

