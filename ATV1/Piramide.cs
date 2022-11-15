using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV1
{
    internal class Piramide
    {
        private int n;

        public Piramide(int n)
        {
            inicializar(n);
        }

        public void Desenha()
        {
            int n = this.n;
            int espaco = 50;

            for (int i = 0; i <= n; i++)
            {
                for (int j = i - espaco; j < i; j++)
                {
                    if (j > 0) Console.Write(j);
                    else Console.Write(" ");
                }
                for (int j = i; j >= 1; j--) { Console.Write(j); }
                Console.WriteLine();
            }
        }

        public void inicializar(int n)
        {
            if (n > 0) { this.n = n; }
            else throw new Exception("N não pode ser menor que 1");
        }

    }
}
