using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tahmin = rnd.Next(0, 100);
            int tahminEdilenSayi = -1;
            int sayac = 1;
            while (tahminEdilenSayi != tahmin) {
                Console.Write("Tahmin Giriniz : ");
                tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
                if (tahminEdilenSayi > tahmin)
                {
                    Console.WriteLine("Tahmin ettiğiniz sayı büyüktür.");
                }
                else if (tahminEdilenSayi < tahmin)
                {
                    Console.WriteLine("Tahmin ettiğiniz sayı küçüktür.");
                }
                else if (tahminEdilenSayi == tahmin)
                {
                    Console.WriteLine("Doğru Tahmin! " + sayac + ". defada buldunuz.");
                }
                sayac++;
            };
            Console.ReadLine();
        }
    }
}
