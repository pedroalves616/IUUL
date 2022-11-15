using System;
using ATV2;

namespace ATV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice(2, 2);
            Vertice v2 = new Vertice(2, 8);
            Vertice v3 = new Vertice(7, 2);

            Triangulo p1 = new Triangulo(v1, v2, v3);
            Triangulo p2 = new Triangulo(v1, v2, v3);
        }
    }
}
