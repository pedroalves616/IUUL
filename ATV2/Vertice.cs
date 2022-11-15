using System;

namespace ATV2
{
    public class Vertice
    {
        private double _x;
        private double _y;


        public double X
        {
            get { return _x; }
            private set { _x = value; }
        }
        public double Y
        {
            get { return _y; }
            private set { _y = value; }
        }
        public Vertice(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public double Distancia(Vertice ponto)
        {
            double xa, xb, d;

            xa = Math.Pow(ponto.X - this.X, 2);
            xb = Math.Pow(ponto.Y - this.Y, 2);

            d = Math.Sqrt(xa + xb);

            return d;
        }

        public bool Igual(Vertice ponto)
        {
            /* if (this.X == ponto.X && this.Y == ponto.Y)  return true;  return false; famosa alguma coisa que falam por ae*/
            return this.X == ponto.X && this.Y == ponto.Y ? true:false; 
        }


    }



    }

