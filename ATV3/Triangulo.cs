using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATV2;


namespace ATV3
{
    public enum TiposTriangulo
    {
        Isoseles,
        Escaleno,
        Equilatero
    }

        private Vertice _v1, _v2, _v3;

        public Vertice V1
        {
            get { return _v1; }

            private set { _v1 = value; }
        }
        public Vertice V2
        {
            get { return _v2; }

            private set { _v2 = value; }
        }
        public Vertice V3
        {
            get { return _v3; }

            private set { _v3 = value; }
        }
 
        private Double A { get { return _v1.Distancia(_v2); } }
        private Double B { get { return _v2.Distancia(_v3); } }
        private Double C { get { return _v3.Distancia(_v1); } }

        public double Area
        {
            get { return Math.Sqrt(Perimetro / 2 * (Perimetro / 2 - A) * (Perimetro / 2 - B) * (Perimetro / 2 - C)); }
        }
        public double Perimetro
        {
            get { return A + B + C; }
        }

        public Enum Tipo
        {
            get
            {
                if (A == B && B == C) return TiposTriangulo.Equilatero;
                else if (A == B || B == C || C == A) return TiposTriangulo.Isoseles;
                else return TiposTriangulo.Escaleno;
            }
        }
        public Triangulo(Vertice v1, Vertice v2, Vertice v3)
        {
            _v1 = v1;
            _v2 = v2;
            _v3 = v3;

            verificarTriangulo();
        }
        public bool EIgual(Triangulo trianguloB)
        {
            if (_v1.Igual(trianguloB.V1) && _v2.Igual(trianguloB.V2) && _v3.Igual(trianguloB.V3)) return true;
            return false;
        }
        private void verificarTriangulo()
        {
            if (!(A < B + C) || !(B < A + C) || !(C < A + B))
            {
                throw new Exception("Não forma um triângulo");
            }
        }






    }
}
