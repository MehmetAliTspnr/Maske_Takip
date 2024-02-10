using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maske_Takip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Selamver("Ahmet");
            Selamver("mehmet");
            Selamver();
            int sonuc = Topla(6,66);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
        static void Selamver(string isim="isimsiz")
        { Console.WriteLine("Hoşgeldin"+" "+isim); }

        static int Topla(int sayi1=10, int sayi2=1)
        { int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplamın sonucu:");
            return sonuc;
            }
    }
}
