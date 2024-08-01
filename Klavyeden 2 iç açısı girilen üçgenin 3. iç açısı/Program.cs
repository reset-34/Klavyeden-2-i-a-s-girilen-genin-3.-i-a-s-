using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_2_iç_açısı_girilen_üçgenin_3.iç_açısı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. iç açıyı girin");
            int aci1 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("2. iç açıyı girin");
            int aci2 = Int32.Parse(Console.ReadLine());

            int toplam = aci1 + aci2;
            int bilinmeyenaci = 180 - toplam;

            Console.WriteLine("Bilinmeyen Üçüncü açı=" + bilinmeyenaci);

            Console.ReadLine();
        }
    }
}
