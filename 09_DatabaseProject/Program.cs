using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ado.net : C# dilinde SQL yapılarını kullanabilmemize olanak sağlayan bir çerçeve.

            Console.WriteLine("***** C# Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;


            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz: ");
            tableNumber=Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");

            //SQL Bağlantısına İhtiyacımız var bunun için:

            SqlConnection connection= new SqlConnection("Data Source= DESKTOP-PSRDL1C\\SQLEXPRESS; initial Catalog= EgitimKampiDb; integrated security=true");
            // önce sunucu adını yazdık daha sonra veritabanına verdiğimiz ismi yazdık

            connection.Open(); //bağlantımızı açtık
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection); //bu tablonun hangi veritabanında olduğunu belirtmek için yanına connection verdik
            SqlDataAdapter adapter = new SqlDataAdapter(command); // SglDataAdapter adlı sınıftan adapter adında nesne örneği oluşturduk ve 
            //SqlDataAdapter ---> C# kodlarımla Sql sunucum arasında köprü görevi görüyor

            DataTable dataTable = new DataTable();
            //Verilerimi geçici belleğe almamı sağlayan kısım
            adapter.Fill(dataTable);

            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }



            Console.Read();
        }
    }
}
