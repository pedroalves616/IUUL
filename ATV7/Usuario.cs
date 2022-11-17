using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV7
{
    internal class Usuario
    {
        public String Nome { get; private set; }
        public long Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public double Rendamensal { get; private set; }
        public char EstadoCivil { get; private set; }
        public int Depedentes { get; private set; }

    }

    private  String ConverterNome(String nome)
    {

        while(nome.Length < 5)
            {
            Console.WriteLine("Favor, inserir nome de pelo menos 5 caracteres: ");
            nome = Console.ReadLine();
        }
        return nome;
    }



}
//referencia https://www.caelum.com.br/apostila/apostila-csharp-orientacao-objetos.pdf