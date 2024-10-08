using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision  // Karar Yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi Giriniz: ");

            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //----------------------------------------------------

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Yazınız: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country== "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}

            //---------------------------------------------

            //int number;
            //Console.WriteLine("Sayıyı Giriniz: ");
            //number=int.Parse(Console.ReadLine());

            //if (number==5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //-------------------------------------------------------

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav1: ");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average >0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average >50 & average<= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average >70 & average <= 85)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average >85)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);  // result'ın altı kırmızı çizgili oldu. Bu önemli. Şu demek: Ya bu if lerin dışında bir değer yazılırsa ben napıcam?
            //                            // Yani iki seçenek sunuyor: ya else ile değer ataması yap ya da result'a ilk değer ataması yap!
            //                            // değer ataması yapalım ===> string result = "Hata!" diyelim 

            //--------------------------------------------------------------

            //string city;
            //Console.WriteLine("Lütfen Şehir Girişi Yapınız: ");
            //city= Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "kayseri" | city == "yozgat")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Bulunamadı");
            //}

            //---------------------------------------------------------------

            //Console.WriteLine("Lütfen Kullanıcı Adı Giriniz: ");
            //    string username = Console.ReadLine();
            //if (username != "admin")  // != eşit değilse demek
            //{
            //    Console.Write("Bu Kullanıcı Kabul Edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş Geldiniz");
            //}

            //--------------------------------------------------------------

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            // Console.Write("Lütfen 1.sayıyı giriniz: ");
            // int number1 = int.Parse(Console.ReadLine());

            // Console.Write("Lütfen 2.sayıyı giriniz: ");
            // int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            // Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);

            //--------------------------------------------------------
            // tek mi çift mi 

            //Console.WriteLine("Lütfen Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number%2==0)
            //{
            //    Console.WriteLine("Sayımız Çift :) ");
            //}
            //else
            //{
            //    Console.WriteLine("Sayımız Tek :) ");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //-----------------------------------------------------------
            // klayveden gelen harfe göre takım bilme uygulaması

            //char team;
            //Console.WriteLine("Lütfen Takım Sembolünü Giriniz: ");
            //team= char.Parse(Console.ReadLine());

            //if(team == 'g' | team== 'G')
            //{
            //    Console.WriteLine("Takımınız Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Takımınız ŞANLI FENERBAHÇE :) ");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Takımınız Beşiktaş");
            //}
            #endregion

            #region ÖRNEK PROJE UYGULAMASI

            //---------------------------------------------------------------
            // YEMEK SEÇİM EKRANI

            //Console.WriteLine("******* C# Eğitim Kampı Restoranı ********");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("1-ANA YEMEKLER");
            //Console.WriteLine("2-ÇORBALAR");
            //Console.WriteLine("3-PİZZALAR");
            //Console.WriteLine("4-İÇECEKLER");
            //Console.WriteLine("5-TATLILAR");
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını Görmek İstediğiniz Menüyü Seçiniz: ");
            //menuItem = Console.ReadLine();

            //if(menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------ANA YEMEKLER-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-----------ANA YEMEKLER-----------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------ÇORBALAR-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("-----------ÇORBALAR-----------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------PİZZALAR-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("-----------PİZZALAR-----------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------İÇECEKLER-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("-----------İÇECEKLER-----------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------TATLILAR-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("-----------TATLILAR-----------");

            //    Console.WriteLine();

            //}

            #endregion

            #region SWİTCH CASE

            // Klavyeden Girilen Sayıya Göre Yılın Kaçıncı Ayı 

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber= int.Parse(Console.ReadLine());

            //switch(monthNumber) // aynı case ler birden fazla kez kullanılamaz
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break ;
            //    case 3: Console.WriteLine("Mart"); break ;
            //    case 4: Console.WriteLine("Nisan"); break ;
            //    case 5: Console.WriteLine("Mayıs"); break ;
            //    case 6: Console.WriteLine("Haziran"); break ;
            //    case 7: Console.WriteLine("Temmuz"); break ;
            //    case 8: Console.WriteLine("Ağustos"); break ;
            //    case 9: Console.WriteLine("Eylül"); break ;
            //    case 10: Console.WriteLine("Ekimt"); break ;
            //    case 11: Console.WriteLine("Kasım"); break ;
            //    case 12: Console.WriteLine("Aralık"); break ;
            //    default: Console.WriteLine("Hatalı Veri Girişi"); break;
            //}



            #endregion

            #region Switch Case ile Hesap Makinesi Yapımı

            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("1.sayıyı giriniz: ");
            //number1= int.Parse(Console.ReadLine());

            //Console.WriteLine("2.sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol= char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //     case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //}




            #endregion

            Console.Read();
        }
    }
}
