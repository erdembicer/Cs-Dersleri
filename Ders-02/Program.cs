using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859; 
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoPrice * potatoGram;
            double tomatoTotalPrice = tomatoPrice * tomatoGram;

            Console.WriteLine();
            Console.WriteLine("Elmanın toplam fiyatı: " + appleTotalPrice);
            Console.WriteLine("Portakalın toplam fiyatı: " + orangeTotalPrice);
            Console.WriteLine("Çileğin toplam fiyatı: " + strawberryTotalPrice);
            Console.WriteLine("Patatesin toplam fiyatı: " + potatoTotalPrice);
            Console.WriteLine("Domatesin toplam fiyatı: " + tomatoTotalPrice);

            double total = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine();
            Console.WriteLine("Genel toplam: " + total);
            #endregion

            Console.Read();
        }
    }
}
