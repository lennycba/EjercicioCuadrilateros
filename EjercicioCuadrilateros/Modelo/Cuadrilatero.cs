using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuadrilateros.Modelo
{
    public abstract class Cuadrilatero
    {
        private double _coordXA, _coordYA, _coordXB, _coordYB, _coordXC, _coordYC, _coordXD, _coordYD;
        public double CoordXA 
        {
            get { return _coordXA; }
            set { _coordXA = value; }
        }
        public double CoordYA 
        {
            get { return _coordYA; }
            set { _coordYA = value; }
        }

        public double CoordXB 
        {
            get { return _coordXB; }
            set { _coordXB = value; }
        }

        public double CoordYB
        {
            get { return _coordYB; }
            set { _coordYB = value; }
        }

        public double CoordXC
        {
            get { return _coordXC; }
            set { _coordXC = value; }
        }
        public double CoordYC
        {
            get { return _coordYC; }
            set { _coordYC = value; }
        }
        public double CoordXD
        {
            get { return _coordXD; }
            set { _coordXD = value; }
        }
        public double CoordYD
        {
            get { return _coordYD; }
            set { _coordYD = value; }
        }


        public Cuadrilatero(double coordXA, double coordYA, double coordXB, double coordYB, double coordXC, double coordYC, double coordXD, double coordYD)
        {
            this.CoordXA = coordXA;
            this.CoordYA = coordYA;

            this.CoordXB = coordXB;
            this.CoordYB = coordYB;

            this.CoordXC = coordXC;
            this.CoordYC = coordYC;

            this.CoordXD = coordXD;
            this.CoordYD = coordYD;
        }

        public abstract double Area();

    }
}
