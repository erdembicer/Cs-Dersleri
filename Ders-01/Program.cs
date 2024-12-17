using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler"); 
            //Console.WriteLine("3- Soğuk Başlangıçlar"); 
            //Console.WriteLine("4- Salatalar"); 
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //string name;
            //name = "Erdem";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, customerdistrict, customercity;

            //customerName = "Deniz";
            //customerSurname = "Yılmaz";
            //customerPhone = "530 111 22 33";
            //customerEmail = "denizyilmaz@gmail.com";
            //customerdistrict = "Kartal";
            //customercity = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("E-posta adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + customerdistrict + "/" + customercity);
            //Console.WriteLine("---------------");

            //Console.WriteLine();

            //customerName = "Arif";
            //customerSurname = "Işık";
            //customerPhone = "530 222 55 88";
            //customerEmail = "arifisik@gmail.com";
            //customerdistrict = "Beylikdüzü";
            //customercity = "İstanbul";

            //Console.WriteLine("---------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("E-posta adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + customerdistrict + "/" + customercity);
            //Console.WriteLine("---------------");

            #endregion

            #region Int Değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoren Menü Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice);
            Console.WriteLine("----Pizza: " + pizzaPrice);
            Console.WriteLine("----Kızartma: " + friesPrice);
            Console.WriteLine("----Kola: " + cokePrice);
            Console.WriteLine("----Limonata: " + lemonadePrice);
            Console.WriteLine("----Su: " + waterPrice);
            Console.WriteLine();

            Console.WriteLine("Sipariş Fişi");
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalPrice = 0;

            hamburgerCount = 2;
            cokeCount = 2;
            waterCount = 1;
            friesCount = 2;
            pizzaCount = 1;
            lemonadeCount = 1;

            totalPrice = (hamburgerCount * hamburgerPrice) + (cokeCount * cokePrice) + (waterCount * waterPrice) + (friesCount * friesPrice) + (pizzaCount * pizzaPrice) + (lemonadeCount * lemonadePrice);


            Console.WriteLine("Hamburger: " + hamburgerCount * hamburgerPrice);
            Console.WriteLine("Kola: " + cokeCount * cokePrice);
            Console.WriteLine("Su: " + waterCount * waterPrice);
            Console.WriteLine("Kızartma: " + friesCount * friesPrice);
            Console.WriteLine("Pizza: " + pizzaCount * pizzaPrice);
            Console.WriteLine("Limonata: " + lemonadeCount * lemonadePrice);

            Console.WriteLine(totalPrice);


            #endregion


            Console.Read();

        }
    }
}
