using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WIM
{
    internal static class LocalDb
    {
        private static string ConnectionString =>
            @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;TrustServerCertificate=True;Database=WIM;";

        internal static List<Product> GetProducts()
        {
            return Query(
                @"SELECT Id, Name, Quantity, Price, Category
              FROM dbo.Products
              ORDER BY Id ASC;",
                r => new Product
                {
                    Id = r.GetInt32(0),
                    Name = r.GetString(1),
                    Quantity = r.GetInt32(2),
                    Price = r.GetDecimal(3),
                    Category = r.GetString(4)
                });
        }

        private static List<T> Query<T>(string sql, Func<SqlDataReader, T> map)
        {
            var list = new List<T>();

            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            list.Add(map(reader));
                    }
                }
            }

            return list;
        }
    }
}
