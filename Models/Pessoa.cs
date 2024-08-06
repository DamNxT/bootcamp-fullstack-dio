using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploFundamentos.Models
{
    public class Pessoa
    {
        // get significa que está pegando um valor
        // set significa que está passando um valor
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}