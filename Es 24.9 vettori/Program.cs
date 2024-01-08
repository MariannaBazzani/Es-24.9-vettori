using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_24._9_vettori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(2, 2);
            Vector v2 = new Vector(3, 3);

            //Vector v3 = new Vector();
            //Console.WriteLine("inserisci le coordinata di un terzo vettore: ");
            //v3 = Vector.Parse(Console.ReadLine());

            Vector vectorR = v1.Somma(v2);
            Console.WriteLine($"\nSomma del primo e del secondo vettore: {vectorR.Xvector};{vectorR.Yvector}");
        }
    }
}
