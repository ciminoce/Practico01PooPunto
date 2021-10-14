using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01PooPunto
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Punto(10,15);
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.GetDistanciaAlOrigen());
            Console.WriteLine(p.GetCuadrante());
            Console.WriteLine(p.GetCoordenadasPolares());
            Console.ReadLine();
        }
    }
}
