using StockAlgorithms.Models;
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
        private const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=StockMarket;Integrated Security=true";

        public List<Stock> GetStockData(string symbol, int numDaysBack)
        {
            throw new NotImplementedException();
        }

        public List<Stock> GetStockData(List<Stock> list, string symbol, int numDaysBack)
        {
            throw new NotImplementedException();
        }

        // start Ticker table methods

        public void CreateTicker(Ticker ticker)
        {
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        conn.Open();

            //        SqlCommand cmd = new SqlCommand(SQL_AddCity, conn);
            //        cmd.Parameters.AddWithValue("@id", city.CityId);
            //        cmd.Parameters.AddWithValue("@name", city.Name);
            //        cmd.Parameters.AddWithValue("@countrycode", city.CountryCode);
            //        cmd.Parameters.AddWithValue("@district", city.District);
            //        cmd.Parameters.AddWithValue("@population", city.Population);

            //        cmd.ExecuteReader();
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    throw;
            //}
        }

        public void ListTickers()
        {
            throw new NotImplementedException();
        }

        public void ReadTicker(Ticker ticker)
        {
            throw new NotImplementedException();
        }

        public void RemoveTicker(Ticker ticker)
        {
            throw new NotImplementedException();
        }

        public void UpdateTicker(Ticker ticker)
        {
            throw new NotImplementedException();
        }

        // end Ticker table methods
        //Start Stock table methods

        public void CreateStock(Stock stock)
        {
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        conn.Open();

            //        SqlCommand cmd = new SqlCommand(SQL_AddCity, conn);
            //        cmd.Parameters.AddWithValue("@id", city.CityId);
            //        cmd.Parameters.AddWithValue("@name", city.Name);
            //        cmd.Parameters.AddWithValue("@countrycode", city.CountryCode);
            //        cmd.Parameters.AddWithValue("@district", city.District);
            //        cmd.Parameters.AddWithValue("@population", city.Population);

            //        cmd.ExecuteReader();
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    throw;
            //}

            throw new NotImplementedException();
        }

        public void ListStocks()
        {
            throw new NotImplementedException();
        }

        public void ReadStock(Stock stock)
        {
            throw new NotImplementedException();
        }

        public void RemoveStock(Stock stock)
        {
            throw new NotImplementedException();
        }

        public void UpdateStock(Stock stock)
        {
            throw new NotImplementedException();
        }

        //end stock table methods
        //Start Sector table methods

        public void CreateSector(Sector sector)
        {
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        conn.Open();

            //        SqlCommand cmd = new SqlCommand(SQL_AddCity, conn);
            //        cmd.Parameters.AddWithValue("@id", city.CityId);
            //        cmd.Parameters.AddWithValue("@name", city.Name);
            //        cmd.Parameters.AddWithValue("@countrycode", city.CountryCode);
            //        cmd.Parameters.AddWithValue("@district", city.District);
            //        cmd.Parameters.AddWithValue("@population", city.Population);

            //        cmd.ExecuteReader();
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    throw;
            //}

            throw new NotImplementedException();
        }

        public void ListSectors()
        {
            throw new NotImplementedException();
        }

        public void ReadSector(Sector sector)
        {
            throw new NotImplementedException();
        }

        public void RemoveSector(Sector sector)
        {
            throw new NotImplementedException();
        }

        public void UpdateSector(Sector sector)
        {
            throw new NotImplementedException();
        }

        //end Stock table methods
    }
}
