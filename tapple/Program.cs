using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Vücut Kilo Endeksi hesaplama
namespace tı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kilonuzu girin");
            double deger1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("lütfen boyunuzu girin");
            double deger2 = Convert.ToDouble(Console.ReadLine());

            Tuple<double, double> bilgi = Tuple.Create(deger1,deger2);
            double deger3 = (bilgi.Item1) / (bilgi.Item2 * bilgi.Item2);
            Console.WriteLine($"Endeksiniz:  {deger3}");
            
            
        }
    }
}
