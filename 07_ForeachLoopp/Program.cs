using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoopp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1: Değişken Türü
            //2: Değişken Adı
            //3: In
            //4: Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            // Çift olan sayıları ekrana yazdır
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            #endregion

            #region Listeler

            //List<int> numbers = new List<int>() //direkt atama yapabiliyoruz
            //{
            //    1,2,3,4,5,8
            //};

            /*Console.WriteLine(numbers);*/ // bunu yazdığımızda değerlerimizi ekrana yazdırmıyor bundan dolayı FOREACH KULLANIYORUUUZZZZ

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);  // foreach sadece dizilerle çalışan değil listelerle de çalışan bir yapı
            //}



            // Bir Kelimeyi Harflerine Ayıralım
            //string word = "Merhaba";

            //foreach(char  c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Soruuu (Klayveden Alınan Öğrenci Sayısı,İsim,Not --> Ortalama Bulalım)

            //Örnek Sınav Sistemi Uygulaması

            //Öğrendiklerimizi tekrar ediyoruz
            //Değişken,Döngü,Dizi,Karar Yapısı

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki Öğrenci Sayısını Kullanıcıdan Alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");


            ////Öğrenci İsmlerini ve not ortalamalarını saklayacak dizileri tanımlıyoruz burada
            //string[] studentNames = new string[studentCount]; // öğrenci sayısı ne kadarsa o kadar isim alabilsin diye 'SİZE'ı öğrenci sayısı kadar yaptık
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her öğrenci için 3 sınav notu girişi olsun

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; // NOTLARI TOPLUYORUZ

            //    }
            //    Console.WriteLine(); // notlar ve ortalama arasına boşlu koymak için

            //    studentExamAvg[i] = totalExamResult / 3; // ORTALAMASINI BULUYORUZ

            //}

            ////Öğrencilerin sınav ortalamasını bulalım

            //for (int i = 0; i < studentCount; i++)

            //{
            //    Console.WriteLine("--------------------------");

            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]} ");

            //    //Öğrencilerin geçip geçemedikleri kısım (for un içine yazdık dikkat et)

            //    if (studentExamAvg[i] > 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti. ");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı. ");
            //    }

            //    Console.WriteLine("--------------------------");

            //}





            #endregion

            Console.Read();

        }
    }
}