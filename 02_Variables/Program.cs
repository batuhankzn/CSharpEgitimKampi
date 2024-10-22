using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            double applePrice, bananaPrice, watermelonPrice;

            applePrice = 15.55;
            bananaPrice = 16.75;
            watermelonPrice = 25;

            Console.WriteLine("Elma Fiyatı: " + applePrice + " TL");
            Console.WriteLine("Muz Fiyatı: " + bananaPrice + " TL");
            Console.WriteLine("Karpuz Fiyatı: " + watermelonPrice + " TL");
            Console.WriteLine();
            Console.WriteLine();

            // Ürünlerin Gram Bilgileri
            double appleGram, bananaGram, watermelonGram;

            appleGram = 4.234;
            bananaGram = 0.567;
            watermelonGram = 6.455;

            double appleTotalPrice = applePrice * appleGram;
            double bananaTotalPrice = bananaPrice * bananaGram;
            double watermelonTotalPrice = watermelonPrice * watermelonGram;

            Console.WriteLine("**** Sipariş Tutar ****");
            Console.WriteLine("--Elma= " + "Birim Fiyat " + applePrice + " TL" + " | Gram: " + appleGram + " | Toplam Fiyat: " + appleTotalPrice + " TL");
            Console.WriteLine("--Muz= " + "Birim Fiyat " + bananaPrice + " TL" + " | Gram: " + bananaGram + " | Toplam Fiyat: " + bananaTotalPrice + " TL");
            Console.WriteLine("--Karpuz= " + "Birim Fiyat " + watermelonPrice + " TL" + " | Gram: " + watermelonGram + " | Toplam Fiyat: " + watermelonTotalPrice + " TL");
            Console.WriteLine("Toplam Tutar: " + (appleTotalPrice + bananaTotalPrice + watermelonTotalPrice) + " TL");


            #endregion


            #region Char Değişkenler

            char symbol;
            symbol = 'A';
            // Console.WriteLine(symbol);

            #endregion


            #region Klavyeden Veri Girişleri String Değişkenler

            Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("Yolcu İlçe: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Yolcu Şehir: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik Numarası: ");
            passengerIdentityNumber = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("---------------------------");

            Console.WriteLine("Yolcu TC: " + passengerIdentityNumber + " İsim: " + passengerName + " " + passengerSurname + " Şehir: " + passengerDistrict + "/" + passengerCity + " Yaş: " + passengerAge);


            #endregion


            #region Klavyeden Tam Sayı Giriş ve Dönüşümleri

            int computerPrice, displayPrice, mousePrice, keyboardPrice;

            computerPrice = 2500;
            displayPrice = 1500;
            mousePrice = 50;
            keyboardPrice = 100;


            int computerCount, displayCount, mouseCount, keyboardCount;

            Console.WriteLine("**** Bilgisayar Fiyatları ****");
            Console.WriteLine("Bilgisayar " + computerPrice + " TL");
            Console.WriteLine("Monitör " + displayPrice + " TL");
            Console.WriteLine("Mouse " + mousePrice + " TL");
            Console.WriteLine("Klavye " + keyboardPrice + " TL");

            Console.WriteLine();
            Console.WriteLine("************");
            Console.WriteLine();

            Console.Write("Aldığınız Bilgisayar Adet: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Aldığınız Monitör Adet: ");
            displayCount = int.Parse(Console.ReadLine());

            Console.Write("Aldığınız Mouse Adet: ");
            mouseCount = int.Parse(Console.ReadLine());

            Console.Write("Aldığınız Klavye Adet: ");
            keyboardCount = int.Parse(Console.ReadLine());

            int orderPrice = (computerPrice * computerCount) + (displayPrice * displayCount) + (mousePrice * mouseCount) + (keyboardPrice * keyboardCount);

            Console.WriteLine("Toplam Tutar: " + orderPrice + " TL");




            #endregion


            #region Klavyeden Double Giriş ve Dönüşümleri

            double exam1, exam2, exam3, result;

            Console.Write("1. Sınav Notu: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("2. Sınav Notu: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("3. Sınav Notu: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();

            Console.WriteLine("Ortalama: " + result);


            #endregion


            #region Klavyeden Char Giriş ve Dönüşümleri

            // Bir karakter değişkeni tanımlayarak klavyeden cinsiyet bilgisini alınız.
            char gender;
            Console.Write("Cinsiyetinizi Giriniz (E/K): ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Cinsiyetiniz: " + gender);


            #endregion

            Console.Read();
        }
    }
}
