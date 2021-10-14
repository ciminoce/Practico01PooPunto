using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01PooPunto
{
    public class Punto
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Punto(int coordX, int coordY)
        {
            X = coordX;
            Y = coordY;
        }

        public override string ToString()
        {
            return $"({X.ToString()},{Y.ToString()})";
        }

        public double GetDistanciaAlOrigen()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }

        public string GetCuadrante()
        {
            if (X>0 && Y>0)
            {
                return ObtenerCuadrante(Cuadrante.Primer_Cuadrante);
            }else if (X>0 && Y<0)
            {
                return ObtenerCuadrante(Cuadrante.Segundo_Cuadrante);
            }else if (X<0 && Y<0)
            {
                return ObtenerCuadrante(Cuadrante.Tercer_Cuadrante);
            }
            else
            {
                return ObtenerCuadrante(Cuadrante.Cuarto_Cuadrante);
            }
        }

        private string ObtenerCuadrante(Cuadrante cuadrante)
        {
            var palabras=cuadrante.ToString().Split('_');
            return $"{palabras[0]} {palabras[1]}";
        }

        public string GetCoordenadasPolares()
        {
            var r = this.GetDistanciaAlOrigen();
            var theta = Math.Atan(Y / X);//Pronunciese tita
            return $"({r.ToString()};{theta.ToString()})";
        }
    }
}
