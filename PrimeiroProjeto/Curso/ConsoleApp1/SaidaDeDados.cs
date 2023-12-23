
using System.Globalization;

//char genero = 'F';
//int idade = 32;
//double saldo = 10.35748;
//string nome = "Maria";

//Console.WriteLine("Bom dia!");
//Console.WriteLine(genero);
//Console.WriteLine(saldo);   
//Console.WriteLine(nome);
//Console.WriteLine(idade);
//Console.WriteLine(saldo.ToString("F2")); //ToString retorna o mesmo valor com o numero de casas decimais definidas(nesse caso 2)
//Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

//// PlaceHolders, concatenação e interepolação

////placeholder
//Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo);

////interpolaçãp
//Console.WriteLine($"{nome} tem {idade} anos e tem saldo igaul a {saldo:F2} reais");

////concatenação
//Console.WriteLine(nome + "tem" + idade + "e tem saldo igual a"+ saldo.ToString("F2", CultureInfo.InvariantCulture) );

//Exercicio:

string produto1 = "Computador";
string produto2 = "Mesa de escritorio";

byte idade_exercicio = 30;
int codigo = 5290;
char genero_exercicio = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

Console.WriteLine("Produtos: ");
Console.WriteLine("Computador, cujo o preço é $ {0} ", preco1);
Console.WriteLine("Registro: {0}, código {1}, e genêro: {2}", idade_exercicio, codigo, genero_exercicio);

Console.WriteLine(medida.ToString("F8"));
Console.WriteLine(medida.ToString("F3"));
Console.WriteLine(medida.ToString("F3", CultureInfo.InvariantCulture));

