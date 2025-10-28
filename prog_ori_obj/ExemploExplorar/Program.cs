 using ExemploExplorar.Models;
using System.Globalization;
using Newtonsoft.Json;


List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00m);
Venda v2 = new Venda(2, "Licença de Software", 110.00m);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);


 


// int numero = 20;
// bool ehPar = false;


// ehPar = numero % 2 == 0;

// Console.WriteLine($" o numero {numero} é" + (ehPar ? "par" : "impar"));










// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O numero {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O numero {numero} é impar ");
// }












// Pessoa p1 = new Pessoa("Paulo","Angelo");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");




// LeituraArquivo arquivo = new LeituraArquivo();
// var (Sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");


// if (Sucesso)
// {
//     //Console.WriteLine("Quantidade de linhas do arquibo: "+ QuantidadeDeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// } 

// else
// { 
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }










// (int, string, string, decimal) tupla = (1, "Paulo", "Angelo", 1.80M);
// ValueTuple<int, string, string, decimal> tupla2 = (2, "Maria", "Clara", 1.65M);
// var tupla3 = (3, "José", "Silva", 1.75M);

// Console.WriteLine($"Id:{tupla.Item1}");
// Console.WriteLine($"Nome:{tupla.Item2}");
// Console.WriteLine($"Sobrenome:{tupla.Item3}");
// Console.WriteLine($"Salário:{tupla.Item4}");

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("MG", "Minas Gerais");
// estados.Add("BA", "Bahia");
// Console.WriteLine(estados["RJ"]);

// Ou var
// foreach (KeyValuePair <string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// Console.WriteLine("---------------------------------------------------");

// estados.Remove("BA");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento {chave}");   

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"O dicionário contém a chave {chave}");
// }
// else
// {
//     Console.WriteLine($"O dicionário não contém a chave {chave}");
// }









// Stack<int> pilha = new Stack<int>();



// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }




// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);


// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


// fila.Dequeue(); // Remove o primeiro item da fila (2)

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }




// new ExemploExecao().Metodo1();

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }


// } catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu um erro: {ex.Message}");
// } 


// finally
// {
//     Console.WriteLine("Chegou no bloco finally");
// }








// string dataString = "2024-06-25 15:30";
// DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm",
// CultureInfo.InvariantCulture, DateTimeStyles.None, out
// DateTime data);




// // DateTime data = DateTime.Now;
// // Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));








// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine($"Valor monetário: {valorMonetario:C}"); //C de currency (moeda)








// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;
// Console.WriteLine(resultado);













// Pessoa p1 = new Pessoa("Paulo", "Angelo");
// Pessoa p2 = new Pessoa("Maria", "Clara");


// Cursos cursoDeIngles = new Cursos();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();















// Pessoa p1 = new Pessoa();

// p1.Nome = "Paulo";
// p1.Sobrenome = "Angelo";
// p1.Idade = 26;
// p1.Apresentar();

