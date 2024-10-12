using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKampi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam"); // Line ekleyince imleç alt satıra iniyor

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Şule";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Mustafa";
            //customerSurname = "Almış";
            //customerPhone = "0553 000 00 00";
            //customerEmail = "deneme@gmail.com";
            //district = "İzmit";
            //city = "Kocaeli";

            //Console.WriteLine("***** Rezervsyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);

            //customerName = "Şule";
            //customerSurname = "Yolalan";
            //customerPhone = "0551 000 00 00";
            //customerEmail = "deneme2@gmail.com";
            //district = "İzmit";
            //city = "Kocaeli";

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);



            #endregion

            #region Int Değişkenler

            ////int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoren Menü Fiyat Listesi *****");
            Console.WriteLine();
            Console.WriteLine("-----Kola: " + cokePrice + "TL");
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + "TL");
            Console.WriteLine("-----Su: " + waterPrice + "TL");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount=3;
            waterCount=3;
            friesCount=1;
            pizzaCount=1;
            lemonadeCount=0;

            totalPrice = hamburgerCount * hamburgerPrice + cokeCount * cokePrice + waterCount * waterPrice + friesCount * friesPrice + pizzaCount * pizzaPrice + lemonadeCount * lemonadePrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice);


            #endregion

            Console.Read();
        }
    }
}



// Yazdırma Komutları
