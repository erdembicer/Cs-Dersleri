﻿using System;
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

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859; 
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine();
            //Console.WriteLine("Alınan ürün: Elma - " + "Birim fiyat: " + applePrice + " - Miktar: " + appleGram + " - Toplam tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan ürün: Portakal - " + "Birim fiyat: " + orangePrice + " - Miktar: " + orangeGram + " - Toplam tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan ürün: Çilek - " + "Birim fiyat: " + strawberryPrice + " - Miktar: " + strawberryGram + " - Toplam tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan ürün: Patates - " + "Birim fiyat: " + potatoPrice + " - Miktar: " + potatoGram + " - Toplam tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan ürün: Domates - " + "Birim fiyat: " + tomatoPrice + " - Miktar: " + tomatoGram + " - Toplam tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Genel toplam: " + shoppingTotalPrice + " TL");
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerCity, passengerAge, passengerIDNumber;

            //Console.Write("Yolcu adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu Adresi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu Kimlik No: ");
            //passengerIDNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("------------");
            //Console.WriteLine("Yolcu Kimlik No " + passengerIDNumber + " Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerAge + " " + passengerCity);


            #endregion

            #region Klaveyden Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;

            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoeCount * shoePrice) + (computerCount * computerPrice) + (chairCount * chairPrice) + (tvCount * tvPrice);

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);

            #endregion

            #region Klavyeden ondalıklı sayı işlemleri
            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen birinci sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen üçüncü sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.Write("Dönem sonu notu: " + result);


            #endregion

            #region Klavyeden karakter girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);


            #endregion

            Console.Read();
        }
    }
}
