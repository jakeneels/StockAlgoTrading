using StockService;
using StockService.Models;
using DatabaseService.Services; 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
         
           var stockSvc = new IEXStockService();
            // var stock = stockSvc.GetTopsMarketDataHist("aapl",20171015 ); //yyyymmdd
            StockHistoryService stockHist = new StockHistoryService();

            stockHist.ParseHistMarketDataString("ssw,ssy,st,spxe,spyd,pq,srax,sqzz,spn,spne,spns,spro,sptl,sprt,sph,spke,spil,sph,rmp,rmr,rng,rnn,rnr,re,redu,reed,reem,tmus,tnav,tnh,tntr,toca,tol,ths,tho,thrm,tik,til,ssy,ssys,staf,tpl,tpr,tpre,tpx,tpvy,tpic,ttm,ttd,ttai,ttac,tsu,a,aapl,abr,abmd,abio,abev,abx,ac,aple,apog,jbl,jce,jbr,jax,trx,trvn,trt,tsco");

            stockHist.PrintMarketData();
            //stockSvc.GetCompanyData("aapl");
            //Console.WriteLine($" aks price {stock.AskPrice} bid price  {stock.BidPrice}   bid size{stock.BidSize}  ask size {stock.AskSize}");
            Console.ReadKey();
        }
    }
}
