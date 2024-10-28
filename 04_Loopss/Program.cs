using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loopss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            // For(x;y;z)
            // x: başlangıç
            // y: bitiş
            // z: artış-azalış

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i=1; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            // bitiş değeri kullanıcıdan alınsaydı:

            //Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finisValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finisValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion

            #region For Döngüsü İle Karar Yapıları

            //for( int i= 1; i<= 100;  i++ )
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // ardışık sayıları toplayalım

            //int totalValue = 0;

            //for (int i=1; i<=10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            // 1 ile 20 arasındaki çift sayıları toplayalım

            //int totalValue = 0;

            //for( int i = 1; i < 20; i++)
            //{ 
            //    if(i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("---------");
            //Console.WriteLine(totalValue);

            // 1 ile 50 arasında 7'ye tam bölünen kaç sayı var pna bakalım

            //int count = 0;

            //for (int i=1; i<=50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;

            //    }
            //}

            //Console.WriteLine(count);

            // her saatte ikiye bölünen bakteri sayısı hesaplayalım

            //int bacterium = 1;

            //for( int i=1; i<=24; i++ ) // burda for döngümüz saat için 
            //{
            //    bacterium *= 2;  // 2ile çarparak ilerletiyoruz
            //    Console.WriteLine( i + ".Saat Sonunda: " + bacterium);
            //}


            #endregion

            #region While Döngüsü // Şart Sağlandıysa anlamı taşıyor

            // While(Şart)
            //{
            //İşlemler
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Bir türlü öğrenemediğim Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while(i<= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            // 1 ile 10 arasındaki sayıların toplamını yazdıralım

            //int i = 1;
            //int sum = 0;

            //while (i<= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);



            #endregion

            #region ÖRNEK SINAV SORUSU

            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazalım 

            // Mesela 456 -> 4+5+6

            //klavyeden sayı girilem

            //Console.Write("Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds; // basamaklar için değer verdik
            //int sum;

            //ones = number % 10; 
            //tens = (number % 100) / 10; // çıkan sayıyı tekrar 10a bölünce iistediğimizi elde etmiş olduk
            //hundreds = number / 100; // mesela 456 yı 100e bölünce 4.56 oldu ama int kullandığımız için sadece 4 ü alacak


            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
    
            //sum=ones+tens+hundreds;

            //Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}
