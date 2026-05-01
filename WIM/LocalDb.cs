using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

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
                reader => new Product
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Quantity = reader.GetInt32(2),
                    Price = reader.GetDecimal(3),
                    Category = reader.GetString(4)
                });
        }

        internal static int InsertProduct(Product p)
        {
            using var conn = new SqlConnection(ConnectionString);
            using var cmd = new SqlCommand(@"
INSERT INTO dbo.Products (Name, Quantity, Price, Category)
VALUES (@Name, @Quantity, @Price, @Category);
SELECT CAST(SCOPE_IDENTITY() AS int);", conn);

            cmd.Parameters.AddWithValue("@Name", p.Name);
            cmd.Parameters.AddWithValue("@Quantity", p.Quantity);
            cmd.Parameters.AddWithValue("@Price", p.Price);
            cmd.Parameters.AddWithValue("@Category", p.Category);

            conn.Open();
            return (int)cmd.ExecuteScalar();
        }

        internal static int Execute(string sql, params SqlParameter[] parameters)
        {
            using var conn = new SqlConnection(ConnectionString);
            using var cmd = new SqlCommand(sql, conn);
            if (parameters != null && parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
            }
            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        internal static void UpdateProduct(Product p)
        {
            Execute(
                @"UPDATE dbo.Products 
                  SET Name = @Name, 
                      Quantity = @Quantity, 
                      Price = @Price, 
                      Category = @Category 
                  WHERE Id = @Id",
                new SqlParameter("@Id", p.Id),
                new SqlParameter("@Name", p.Name),
                new SqlParameter("@Quantity", p.Quantity),
                new SqlParameter("@Price", p.Price),
                new SqlParameter("@Category", p.Category));
        }

        private static List<T> Query<T>(string sql, Func<SqlDataReader, T> map)
        {
            using var conn = new SqlConnection(ConnectionString);
            using var cmd = new SqlCommand(sql, conn);
            conn.Open();
            using var reader = cmd.ExecuteReader();

            var list = new List<T>();
            while (reader.Read())
                list.Add(map(reader));
            return list;
        }
    }
}