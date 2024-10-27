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

            Console.WriteLine("***** C# Veri Tabanılı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();



            // Veritabanı bağlantısı
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1283S79; initial Catalog=EgitimKampiDb; integrated security=true"); // Veritabanı bağlantısını sağlar.
            connection.Open(); // Veritabanı bağlantısını açar.
            SqlCommand command = new SqlCommand("Select * From TblCategory",connection); // Veritabanı sorgusu yapmak için kullanılır.
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command); // Verileri okumak için kullanılır.
            DataTable dataTable = new DataTable(); // Verileri ramde tablo şeklinde tutar.
            dataAdapter.Fill(dataTable); // Verileri ramde tabloya doldurur.
            connection.Close(); // Veritabanı bağlantısını kapatır.

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Console.WriteLine(dataRow["CategoryName"]); // CategoryName sütunundaki verileri ekrana yazdırır.
            }


            Console.Read();
        }
    }
}
