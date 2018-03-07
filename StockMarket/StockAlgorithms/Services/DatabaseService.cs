using StockAnalyzer;
using StockAnalyzer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAlgorithms.Services
{
    public class DatabaseService : IDatabaseService
    {
        private const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ProjectDB;Integrated Security=true";

        public List<Stock> GetStockData(string symbol, int numDaysBack)
        {
            throw new NotImplementedException();
        }


        public List<Stock> GetStockData(List<Stock> list, string symbol, int numDaysBack)
        {
            throw new NotImplementedException();
        }

    public void AddTicker()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SQL_AddCity, conn);
                cmd.Parameters.AddWithValue("@id", city.CityId);
                cmd.Parameters.AddWithValue("@name", city.Name);
                cmd.Parameters.AddWithValue("@countrycode", city.CountryCode);
                cmd.Parameters.AddWithValue("@district", city.District);
                cmd.Parameters.AddWithValue("@population", city.Population);

                cmd.ExecuteReader();
            }
        }
        catch (SqlException ex)
        {
            throw;
        }
    }


    }
}
