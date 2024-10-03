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

            ////double number;

            ////number = 4.85;
            ////Console.WriteLine(number);

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("₺");

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " ₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " ₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " ₺");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " ₺");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " ₺");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice= strawberryGram * strawberryPrice;
            //double potatoTotalPrice= potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma  " + " - Birim Fiyat: " + applePrice + "-Gramaj: " + appleGram + " - Toplam Ödenecek Tutar: " + appleTotalPrice);

            //Console.WriteLine("Elmanın Toplam Fiyatı: " + appleTotalPrice);

            //Console.WriteLine();
            //Console.WriteLine();

            //double shoppingAllPrice = appleTotalPrice + orangeTotalPrice + tomatoTotalPrice + potatoTotalPrice + strawberryTotalPrice;

            //Console.WriteLine("Ödenecek Toplam Tutar : " + shoppingAllPrice + "₺");

            #endregion

            #region Char Değişkenler

            // Stringler " ile gösterilirken Char lar ' ile gösteriliyor.

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName=Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname=Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict=Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity=Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge=Console.ReadLine();

            //Console.Write("Yolcu Kimlik Numarası: ");
            //passengerIdentityNumber=Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("---------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " " + "Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge + " " );


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 2000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse( Console.ReadLine()); // Parse dönüştürmek için kullandığımız metot

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz ");
            //computerCount= int.Parse( Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount= int.Parse( Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount= int.Parse( Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice);



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.sınav notunu giriniz: ");
            //exam1= double.Parse(Console.ReadLine());


            //Console.Write("Lütfen 2.sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());


            //Console.Write("Lütfen 3.sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion

            #region Klayveden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender= char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);



            #endregion


            Console.Read();

           
        }
    }
}
