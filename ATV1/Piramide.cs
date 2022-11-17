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

        public  int N
        { 
            get { return n; }
            set
            {
                if  (value <=0)
                    throw new ArgumentOutOfRangeException("valor menor que 1");
                n = value;
            }
    
        
        }
        
        public Piramide(int n)
        {
            this.N = n;
        }

        public void Desenha()
        {
            int n = this.n;
         

            for (int i = 1; i <= N; i++)
            {
                for (int j = 0 ; j < N-i; j++)
                    Console.Write(' ');

                for (int j = 1; j <=  i; j++)
                    Console.Write(j);

                for (int j = i-1; j >= 1; j--)  
                    Console.Write(j);  

                Console.WriteLine();
            }
        }

      

    }
}
