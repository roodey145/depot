using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace Depot
{
    public class SqliteDataAccess
    {

        public static void AddItem(string productId, string productName, string bundlePiecesText, string numberOfBundlesText, string piecesText, string priceText)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = "INSERT INTO Products (ProductId, ProductName, BundlePieces, NumberOfBundles, Pieces, Price) " +
                             "VALUES (@ProductId, @ProductName, @BundlePieces, @NumberOfBundles, @Pieces, @Price)";

                cnn.Execute(sql, new
                {
                    ProductId = productId,
                    ProductName = productName,
                    BundlePieces = bundlePiecesText,
                    NumberOfBundles = numberOfBundlesText,
                    Pieces = piecesText,
                    Price = priceText
                });
            }
        }


        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
