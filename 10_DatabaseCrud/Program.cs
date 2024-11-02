using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud--> Create-Read-Update-Delete
            //Geçtiğimiz derste veri listelemesi yapmıştık şimdi de veri eklemesi yapacağız

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("--------------------------------------");
            #region Kategori Ekleme İşlemi
            //Console.WriteLine("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName=Console.ReadLine(); //kullanıcıdan aldık kategori ismini

            ////amacımız şu veritabanımıza yeni bir kategori eklemek istiyoruz fakat sql üzerinden değil C# tarafından

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PSRDL1C\\SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true");

            //connection.Open();

            ////ekleme yapmak için ilk önce sorgulama yapıyoruz // insert into ekleme yapabilmek için
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName); // @ sembolü değişken tanımlamak için kullanılıyoruz
            //command.ExecuteNonQuery(); //koşulsuz çalıştır demek
            //connection.Close(); //bağlantıyı kapat demek

            //Console.WriteLine("Kategori başarıyla eklendi!");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName =Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine()); //dönüştürdük

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-PSRDL1C\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true ");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@ProductStatus) ", connection);
            ////birden fazla parametre olduğu için bu parametreleri aşağıda tanımlayalım

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true); // dışardan almadık direkt true yazdırdık
            //command.ExecuteNonQuery(); //değişiklikleri kaydet ve bunu veritabanına yansıt anlamına geliyor

            //connection.Close();
            //Console.WriteLine("Ürün Eklemesi Başarılı!");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-PSRDL1C\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true ");

            //connection.Open();//bağlantımızı açtık
            ////sorgumuzu yazalım
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection); //connection ile bağlantımızı kurduk
            //SqlDataAdapter adapter = new SqlDataAdapter(command); //sql den verilerimizi C# a çekecek olan köprümüzü de kurduk
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();

            //}

            //connection.Close(); 

            #endregion

            #region  Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source= DESKTOP-PSRDL1C\\SQLEXPRESS; initial Catalog= EgitimKampiDb; integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme İşlemi Tamamlandı!");

            #endregion

            #region Ürün Güncelleme İşlemi

            //ürün güncelleme işleminde dışarıdan ID ye ihtiyacımız var

            //Console.Write("Güncellenecek Ürün ID: ");
            //int productId=int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName= Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice= decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source= DESKTOP-PSRDL1C\\SQLEXPRESS; initial Catalog= EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId ", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme İşlemi Tamamlandı!");

            #endregion

            Console.Read();

        }
    }
}
