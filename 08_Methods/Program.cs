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
            #region Void Metotlar

            //() Bir yapıyı metot yapan şey () bu parantezimiz
            // Geriye Değer Döndürmeyen Metotlar
            // Customer---> Listele, ekle, sil, güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //} // Çalıştırdığımda ekrana hiçbir isim yazılmadı çünkü bu yapıyı tekrar çağırmamız lazım
            ////şöyle çağırıyoruz

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();// 16 satır yazmak yerine dört kere çağırdık kolaylık oldu



            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);

            //}
            ////şimdi yapıyı tekrar çağırmamız lazım
            //Sum();




            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod( string customerName) // dışardan kullanıcıcdan almak istediğim için string customerName yazdık
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);

            //}

            //CustomerCard("Mehmet","Yıldız");
            //CustomerCard("Ayşegül","Kaya");
            //CustomerCard("Meral","Dere");

            #endregion

            #region Geriye Değer Döndürmeyen İnt Parametreli Metotlar

            //Dışardan alınan üç sayıyı toplayalım

            //void Sum(int number1,int number2, int number3)
            //{
            //    int result= number1+number2+number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 93, 2);


            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız"; //geriye döndürme return ile oluyor
            //}

            //CustomerName();


            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name+ " "+ surname;

            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo= "Ülke: " + countryName+ "- Başkent: " + capital+ " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y= Console.ReadLine();

            //Console.Write("Bayrak Rengi Giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));



            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int nummber2)
            //{
            //    int reault = number1 + nummber2;
            //    return reault;

            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " İsimli Öğrenci Sınavı Geçti " + "Ortalama: " + result;

                }
                else
                {
                    return student + " İsimli Öğrenci Sınavda Başarısız Oldu " + "Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 25, 41, 68));
            Console.WriteLine(ExamResult("Ayşe", 36, 83, 33));

            #endregion

            Console.Read();
        }
    }
}