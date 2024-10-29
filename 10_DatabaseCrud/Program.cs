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
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();


            Console.WriteLine("----------------------------------------");

            #region Kategori Ekleme İşlemi
            

            Console.Write("Eklemek istediğiniz kategori adı: ");
            string categoryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1283S79;Initial Catalog=EgitimKampiDb;Integrated Security=True"); // Connection String
            connection.Open(); // Bağlantıyı açıyoruz.
            SqlCommand command = new SqlCommand("INSERT INTO TblCategory(CategoryName) VALUES(@CategoryName)", connection); // Sorgumuzu yazıyoruz.
            command.Parameters.AddWithValue("@CategoryName", categoryName); // Parametre değerimizi giriyoruz.
            command.ExecuteNonQuery(); // Sorgumuzu çalıştırıyoruz.
            connection.Close(); // Bağlantıyı kapatıyoruz.
            
            #endregion


            #region Kategori Ekleme İşlemi
            
            string productName;
            decimal productPrice;
            bool productStatus;

            Console.Write("Eklemek istediğiniz ürün adı: ");
            productName = Console.ReadLine();

            Console.Write("Eklemek istediğiniz ürün fiyatı: ");
            productPrice = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Eklemek istediğiniz ürün durumu (Aktif ise 1, Pasif ise 0): ");
            //productStatus = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));



            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1283S79;Initial Catalog=EgitimKampiDb;Integrated Security=True"); // Connection String
            connection.Open(); // Bağlantıyı açıyoruz.
            SqlCommand command = new SqlCommand("INSERT INTO TblProduct(ProductName, ProductPrice, ProductStatus) VALUES(@ProductName, @ProductPrice, @ProductStatus)", connection); // Sorgumuzu yazıyoruz.
            
            command.Parameters.AddWithValue("@ProductName", productName); // Parametre değerimizi giriyoruz.
            command.Parameters.AddWithValue("@ProductPrice", productPrice); // Parametre değerimizi giriyoruz.
            command.Parameters.AddWithValue("@ProductStatus", true); // Parametre değerimizi giriyoruz.
            command.ExecuteNonQuery(); // Sorgumuzu çalıştırıyoruz.
            connection.Close(); // Bağlantıyı kapatıyoruz.

            Console.WriteLine("Ürün başarıyla eklendi.");


            
            #endregion


            #region Ürün Listeleme İşlemi
           

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1283S79;Initial Catalog=EgitimKampiDb;Integrated Security=True"); // Connection String
            connection.Open(); // Bağlantıyı açıyoruz.
            SqlCommand command = new SqlCommand("SELECT * FROM TblProduct", connection); // Sorgumuzu yazıyoruz.
            SqlDataAdapter adapter = new SqlDataAdapter(command); // Sorgumuzu çalıştırıyoruz.
            DataTable dataTable = new DataTable(); // Verileri tutacağımız bir tablo oluşturuyoruz.
            adapter.Fill(dataTable); // Verileri tabloya dolduruyoruz.

            foreach (DataRow item in dataTable.Rows)
            {
                Console.WriteLine("Ürün Adı: " + item["ProductName"]);
                Console.WriteLine("Ürün Fiyatı: " + item["ProductPrice"]);
                Console.WriteLine("Ürün Durumu: " + item["ProductStatus"]);
                Console.WriteLine("----------------------------------------");
            }


           
            #endregion


            #region Ürün Silme İşlemi
            
            Console.Write("Silmek istediğiniz ürün id: ");
            int productId = Convert.ToInt32(Console.ReadLine());

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1283S79;Initial Catalog=EgitimKampiDb;Integrated Security=True"); // Connection String
            connection.Open(); // Bağlantıyı açıyoruz.

            SqlCommand command = new SqlCommand("DELETE FROM TblProduct WHERE ProductId = @ProductId", connection); // Sorgumuzu yazıyoruz.
            command.Parameters.AddWithValue("@ProductId", productId); // Parametre değerimizi giriyoruz.
            command.ExecuteNonQuery(); // Sorgumuzu çalıştırıyoruz.

            
            #endregion


            #region Ürün Güncelleme İşlemi
            
            Console.Write("Güncellemek istediğiniz ürün id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellemek istediğiniz ürün adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellemek istediğiniz ürün fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());


            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1283S79;Initial Catalog=EgitimKampiDb;Integrated Security=True"); // Connection String
            connection.Open(); // Bağlantıyı açıyoruz.
            SqlCommand command  = new SqlCommand("UPDATE TblProduct SET ProductName = @ProductName, ProductPrice = @ProductPrice WHERE ProductId = @ProductId", connection); // Sorgumuzu yazıyoruz.
            
            command.Parameters.AddWithValue("@ProductName", productName); // Parametre değerimizi giriyoruz.
            command.Parameters.AddWithValue("@ProductPrice", productPrice); // Parametre değerimizi giriyoruz.
            command.Parameters.AddWithValue("@ProductId", productId); // Parametre değerimizi giriyoruz.
            command.ExecuteNonQuery(); // Sorgumuzu çalıştırıyoruz.

            connection.Close(); // Bağlantıyı kapatıyoruz.

            Console.WriteLine("Ürün başarıyla güncellendi.");


            #endregion



            Console.Read();
        }
    }
}
