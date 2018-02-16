using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockService;

namespace UnitTestStockMarket
{
    [TestClass]
    public class UnitTest_IEXStockService
    {
        [TestMethod]
        public void TestTopsMarketAllStocks()
        {
            var svc = new IEXStockService();
            var stocks = svc.GetTopsMarketData();
            Assert.AreNotEqual(stocks.Count, 0, 0, "Expected more than zero stocks returned.");
        }

        [TestMethod]
        public void TestTopsMarketSomeStocks()
        {
            var stockSvc = new IEXStockService();
            var myList = new List<String>();
            myList.Add("DVY");
            myList.Add("SQ");
            var stocks = stockSvc.GetTopsMarketData(myList);
            Assert.AreEqual(stocks[0].Symbol, "DVY", "Expected DVY to be returned.");
            Assert.AreEqual(stocks[1].Symbol, "SQ", "Expected SQ to be returned.");
        }

        [TestMethod]
        public void TestTopsMarketOneStock()
        {
            var svc = new IEXStockService();
            var stock = svc.GetTopsMarketData("DVY");
            Assert.AreEqual(stock.Symbol, "DVY", "Expected DVY to be returned.");
        }

        [TestMethod]
        public void TestCompanyData()
        {
            var svc = new IEXStockService();
            var company = svc.GetCompanyData("aapl");
            Assert.AreEqual(company.CompanyName, "Apple Inc.", "Expected Apple Inc. to be returned.");
        }
    }
}
