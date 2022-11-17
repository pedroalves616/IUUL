using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV7
{
    public class Usuario
    {
        public String Nome { get; private set; }
        public long Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public double Rendamensal { get; private set; }
        public char EstadoCivil { get; private set; }
        public int Depedentes { get; private set; }
        public Usuario(string nome, string cpf, string datanascimento , string rendamensal, string depedentes)
        {
            String nomeValidado = ValidaNOME(nome);
            this.Nome = nomeValidado;

  
        }
    

    private String ValidaNOME(string nome)
        {
            while (nome.Length < 5)
            {
                Console.WriteLine("Favor, inserir nome de pelo menos 5 caracteres: ");
                nome = Console.ReadLine();
            }
            return nome;
        }

        public static bool ValidaData(string data)
        {
            DateTime tempObject;
            return DateTime.TryParseExact(data, "dd/mm/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tempObject) ?  true: throw new Exception(" formato incorreto") ;
        }

    }

}
//referencia https://www.caelum.com.br/apostila/apostila-csharp-orientacao-objetos.pdf