using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuadrilateros.Modelo
{
    internal class Cuadrado : Cuadrilatero
    {
        public Cuadrado(
            double coordXA, double coordYA,
            double coordXB, double coordYB,
            double coordXC, double coordYC,
            double coordXD, double coordYD) : base(coordXA, coordYA, coordXB, coordYB,coordXC,coordYC, coordXD, coordYD)
        {
        }

        public override double Area()
        {
            var lado = Math.Sqrt(Math.Pow(CoordXB - CoordXA, 2) + Math.Pow(CoordYB - CoordYA, 2));
            return lado * lado;
        }
    }
    
}
