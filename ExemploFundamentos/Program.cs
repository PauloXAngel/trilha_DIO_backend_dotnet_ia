using ExemploFundamentos.Common.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Buta";
pessoa1.Idade = 26;
pessoa1.Apresentar();







//--------------------ESTRUTURAS DE REPETIÇÃO---------------------------

// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente ");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de Cliente");
//             break

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             Environment.Exit(0);    
//             break;

//         default:
//             Console.WriteLine("Opção invalida!");
//             break;
//     }

// }

// Console.WriteLine("O programa terminou");



//  int soma = 0, numero = 0;

//  do
//  {
//      Console.WriteLine($"Digite um numero(0 para parar): ");
//      numero = Convert.ToInt32(Console.ReadLine());
//      soma += numero;


//  } while (numero != 0 );


//  Console.WriteLine($"Total da soma dos numeros é: {soma} ");



// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
// //     }

// }


// int numero = 5;



// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }


// ;




// ------------------EXPLORANDO O METODO CALC-------------------------------

// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

// ------------------INCREMENTAÇÃO E DECREMENTAÇÃO---------------

// int numeroIncremento = 10;
// Console.WriteLine(numeroIncremento);
// Console.WriteLine("incrementando o 10");
// // numero = numero + 1;
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 20;
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);



//-------------DADOS BOLEANOS----------------



// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar!");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia!");
// }


// bool possuiPresencaMinima = true;

// double media = 7.5;

// if (possuiPresencaMinima && media >= 7.5)  //verifica se as duas condições são verdadeiras
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel) // vereifica se ao menos uma das condições é verdadeira
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// } 




// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();


//-------------------------- SWITCH CASE -----------------------


// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }


//------------------UTILIZAÇÃO DE PIPES------------------

// if (letra == "a"
//     || letra == "e"
//     || letra == "i"
//     || letra == "o"
//     || letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }





// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("é uma consoante");
// }






// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possiel realizar a venda?  {possivelVenda}");


// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
    
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Compra realizada com sucesso");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque");
// }



// double a = 4 / (2 + 2);

// Console.WriteLine(a);





// // int a = 5;
// // double b = a; // implicitamente converter int para double

// int a = 5;
// long b = a; // implicitamente converter int para long


// string a = 5;

// string a = inteiro.ToString();


// // cast - casting
// int a = Convert.ToInt32(null);
// //int a = int.Parse(null);

// Console.WriteLine(a);




// int a = 10;
// int b = 20;

// int c = a + b;
// //c = c + 5;

// //c += 5;

// c -= 5;
// //c *= 5;
// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));



// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);


// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;   



//Console.WriteLine(apresentacao);
//Console.WriteLine("Valor da variável quantidade: " + quantidade);
//Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
//Console.WriteLine("Valor da variável preco: " + preco);
//Console.WriteLine("Valor da variável condicao: " + condicao);


//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Buta";
//pessoa1.Idade = 26;
//pessoa1.Apresentar();

//Pessoa pessoa_FisicaRepresentacao = new Pessoa();