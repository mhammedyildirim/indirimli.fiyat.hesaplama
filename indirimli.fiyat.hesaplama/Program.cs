using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indirimli.fiyat.hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double asil_fiyat = 0;
            double ind_fiyat = 0;
            double ind_miktar = 0;
            double ind_yuzdesi = 0;

            Console.WriteLine("Urunun fiyatini giriniz: ");
            asil_fiyat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indirim yuzdesini giriniz: ");
            ind_yuzdesi = Convert.ToDouble(Console.ReadLine());

            ind_miktar = asil_fiyat * (ind_yuzdesi / 100);
            ind_fiyat = asil_fiyat - ind_miktar;

            Console.WriteLine("Urunun indirimli fiyati {0} tldir.", ind_fiyat);

            Console.ReadKey();
        }
    }
}
