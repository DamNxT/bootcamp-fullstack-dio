using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploFundamentos.Carro
{
    public class Carros
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public void TipoCarro()
        {
            Console.WriteLine($"Este carro é um {Modelo}, do ano: {Ano}");
        }
    }
}