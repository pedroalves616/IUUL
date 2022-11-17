using System;
using ATV2;

namespace ATV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice(2, 7);
            Vertice v2 = new Vertice(8, 5);
            Vertice v3 = new Vertice(1, 1);

            Triangulo p1 = new Triangulo(v1, v2, v3);
            Triangulo p2 = new Triangulo(v1, v2, v3);

            Console.WriteLine(p1.Igual(p2));
            Console.WriteLine(p1.Perimetro);
            Console.WriteLine(p1.Area);
            Console.WriteLine(p1.Tipo);
        }
    }
}
