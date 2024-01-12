//Imprime um texta na tela
Console.WriteLine("Hello World!");

Console.WriteLine("Seja bem-vindo ao meu primeiro programa!");

// criação de 3 variáveis
string nome;
int idade;
decimal peso;

Console.WriteLine("Qual o seu nome?");

// Lê o nome digitado pelo usuário e armazena na variável nome
nome = Console.ReadLine();

Console.WriteLine("Qual sua idade?");

idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o seu peso?");

peso = decimal.Parse(Console.ReadLine());

Console.WriteLine("Prazer em conhecer " + nome + "!");



