using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuadrilateros.Modelo
{
    internal class Trapecio : Cuadrilatero
    {
        public Trapecio(
            double coordXA, double coordYA,
            double coordXB, double coordYB,
            double coordXC, double coordYC,
            double coordXD, double coordYD) : base(coordXA, coordYA, coordXB, coordYB, coordXC, coordYC, coordXD, coordYD)
        {
        }

        public override double Area()
        {
            var diagonal1 = (CoordXD * CoordYC) + (CoordXC * CoordYB) + (CoordXB * CoordYA) + (CoordXA * CoordYD);
            var diagonal2 = (CoordYD * CoordXC) + (CoordYC * CoordXB) + (CoordYB * CoordXA) + (CoordYA * CoordXD);

            var preResultado = diagonal1 - diagonal2;


            if (preResultado < 0)
            {
                return (preResultado * -1) / 2;
            }
            else
            {
                return preResultado / 2;
            }
        }
    }
    
}
