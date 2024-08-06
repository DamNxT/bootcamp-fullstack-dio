// É possível ter mais de uma classe com o mesmo nome, por exemplo a classe pessoa. O que deve-se mudar é o namespace da classe.

using exemploFundamentos.Carro;
using exemploFundamentos.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Danilo";
pessoa1.Idade = 25;
pessoa1.Apresentar();

Carros modelos = new Carros();
modelos.Modelo = "Audi";
modelos.Ano = 1999;
modelos.TipoCarro();