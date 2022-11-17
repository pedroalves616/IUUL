using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV5
{

    internal class Intervalo
    {

        public DateTime tempoInicial { get; }
        public DateTime tempoFinal { get; }


        public Intervalo(DateTime inicial , DateTime final)
        {
            if (inicial.CompareTo(final) > 0)
            {
                throw new ArgumentException("tempoInicial começo maior que tempoFinal");
            }
            else
            {
                this.tempoInicial = inicial;
                this.tempoFinal = final;
            }
        }
        public bool TemIntersecao(Intervalo intersecao)
            {

                if (this.tempoInicial.Ticks <= intersecao.tempoFinal.Ticks && this.tempoInicial.Ticks >= intersecao.tempoInicial.Ticks)
                {
                    return true;
                }
                if (this.tempoFinal.Ticks >= intersecao.tempoInicial.Ticks && this.tempoFinal.Ticks <= intersecao.tempoFinal.Ticks)
                {
                    return true;
                }
                return false;
            }

        public bool Compara(Intervalo comparar)
        {
            return (tempoInicial.Equals(comparar.tempoInicial) && tempoFinal.Equals(comparar.tempoFinal)) ? true : false;
        }
            

        public TimeSpan Duracao(Intervalo outro)
            {
                TimeSpan interval = outro.tempoInicial - outro.tempoFinal;
                return interval;
            }
        }


}




//Referencias
//https://www.tutorialspoint.com/datetime-compare-method-in-chash ,https://learn.microsoft.com/pt-br/dotnet/api/system.datetime.ticks?view=net-7.0#code-try-1
