using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuadrilateros.Modelo
{
    internal class Rectangulo : Cuadrilatero
    {
        public Rectangulo(
            double coordXA, double coordYA,
            double coordXB, double coordYB,
            double coordXC, double coordYC,
            double coordXD, double coordYD) : base(coordXA, coordYA, coordXB, coordYB, coordXC, coordYC, coordXD, coordYD)
        {
        }

        public override double Area()
        {
            var ladoA = Math.Sqrt(Math.Pow(CoordXB - CoordXA, 2) + Math.Pow(CoordYB - CoordYA, 2));
            var ladoB = Math.Sqrt(Math.Pow(CoordXC - CoordXB, 2) + Math.Pow(CoordYC - CoordYB, 2));
            var baseMayor = Math.Max (ladoA, ladoB);
            var baseMenor = Math.Min (ladoA, ladoB);
            return baseMayor * baseMenor;
        }
    }
}
