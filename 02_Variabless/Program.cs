using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variabless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            double sayi = 45.8;
            Console.WriteLine(sayi);

            #endregion




            int elmaFiyat = 15;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Elmanın fiyati : "+elmaFiyat+" ₺");


            #region Char Değişkenler



            #endregion

            #region Klavyeden Veri Girişler

            Console.Write("Adınızı giriniz :");
            string ad;
            ad = Console.ReadLine();

            Console.WriteLine("Merhaba "+ad+" Hoşgeldiniz...");

            #endregion



            Console.ReadLine();
        }
    }
}
