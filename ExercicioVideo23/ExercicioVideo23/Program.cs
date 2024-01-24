﻿using System.Globalization;

Console.WriteLine("Entre com seu nome completo:");
string nome = Console.ReadLine();
Console.WriteLine("Quantos quartos tem na sua casa?");
int quartos = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o preço de um produto:");
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
string[] vet = Console.ReadLine().Split(' ');
string ultimoNome = vet[0];
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.WriteLine("Você digitou:");
Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(valor.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));