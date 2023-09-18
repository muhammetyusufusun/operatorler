using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oparatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region aritmetiksel oparatörler


            int sayi1 = 500;
            int sayi2 = 45;
            int toplam = sayi1 + sayi2;
            Console.Write("toplam = ");
            Console.WriteLine(toplam);

            int fark = sayi1 - sayi2;
            Console.Write("fark = ");
            Console.WriteLine(fark);

            int carpim = sayi1 * sayi2;
            Console.Write("çarpım = ");
            Console.WriteLine(carpim);

            int bolum = sayi1 / sayi2;
            Console.Write("bölüm = ");
            Console.WriteLine(bolum);

            //mod = iki sayının birbirine bölümünden kalan  
            int mod = sayi1 % sayi2;
            Console.Write("mod =");
            Console.WriteLine(mod);

            #endregion



        }
    }
}
