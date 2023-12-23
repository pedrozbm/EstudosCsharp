//using System.Diagnostics;
//using System.Globalization;
//using System.Runtime.CompilerServices;

//Console.WriteLine("Digite seu nome completo");
//string name = Console.ReadLine();

//Console.WriteLine("Quantos quartos tem na sua casa?");
//int quartos = int.Parse(Console.ReadLine());

//Console.WriteLine("Entre com o preço de um produto: ");
//float ProductPrice = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Console.WriteLine("Entre com seu ultimo nome, idade e altura, na mesma linha: ");
//string[] v = Console.ReadLine().Split(' ');
//string LastName = v[0];
//string years = v[1];
//string altura = v[2];

//Console.WriteLine(name);
//Console.WriteLine(quartos);
//Console.WriteLine(ProductPrice.ToString("F2", CultureInfo.InvariantCulture));
//Console.WriteLine(v[0]);
//Console.WriteLine(v[1]);
//Console.WriteLine(v[2]);

//----------------------------------------------------------------------------------------------------------------------


//Faça um programa para ler dois valores inteiros, e depois mostrar na tela
// a soma desses números com uma mensagem explicativa.


//Console.WriteLine("Digite o primeiro numero: ");
//int n1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Digite o segundo ´número: ");
//int n2 = int.Parse(Console.ReadLine());

//Console.WriteLine("A soma dos valores é: {0}", n1 + n2);

//----------------------------------------------------------------------------------------------------------------------

// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
//casas decimais conforme exemplos.
//Fórmula da área: area = π.raio2
//Considere o valor de π = 3.14159
//using System.Globalization;

//Console.WriteLine("Digite o valor do raio do circulo");
//float raio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//float pi = 3.14159f;
//Console.WriteLine((raio * pi).ToString("F4",CultureInfo.InvariantCulture));

//----------------------------------------------------------------------------------------------------------------------

//Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
//de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

//int n1, n2, n3, n4;

//Console.WriteLine("Digite os valores dos numeros:");
//n1 = int.Parse(Console.ReadLine());
//n2 = int.Parse(Console.ReadLine());
//n3 = int.Parse(Console.ReadLine());
//n4 = int.Parse(Console.ReadLine());

//Console.WriteLine("Diferença é: {0}", (n1 * n2 - n3 * n4));

//----------------------------------------------------------------------------------------------------------------------


