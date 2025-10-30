using ExemploPOO.Models;

ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();
c1.Sacar(5000);
c1.ExibirSaldo();

 

// // um objeto é uma concretização  de uma representação 
// Pessoa p1 = new Pessoa(); //Criando objeto de uma classe / P1 se torna objeto da Pessoa
// p1.Nome = "Paulo";
// p1.Idade = 26;

// p1.Apresentar();
