using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maksimumminimumMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, sayi_max, sayi_min, adet;
            Console.WriteLine("Kaç adet rakam gireceksiniz");
            adet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. rakamı giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            sayi_max = sayi;
            sayi_min = sayi;
            for (int i = 2; i <= adet; i++)
            {
                Console.WriteLine("{0}. rakamı giriniz",i);
                sayi = Convert.ToInt32(Console.ReadLine());
                sayi_max = Math.Max(sayi_max, sayi);
                sayi_min = Math.Min(sayi_min, sayi);
            }
            Console.WriteLine("en büyük sayı: {0} en küçük sayı: {1}", sayi_max, sayi_min);
            Console.ReadKey();
        }
    }
}
