using System;

namespace ATV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice(1, -5);
            Vertice v2 = new Vertice(-2, 4);
            Vertice v3 = new Vertice(3, -4);


            Console.WriteLine(v1.Igual(v3));
            Console.WriteLine(v1.Distancia(v2));
            

        }
    }
}
