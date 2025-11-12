﻿//Exercício 1
Console.WriteLine("Qual é o seu nome:");

var nome = Console.ReadLine();

Console.Write("Olá, ");
Console.Write(nome);
Console.WriteLine("! Seja bem-vindo!");


//Exercício 2
Console.WriteLine("Qual é o nome da sua cidade natal?");


var cidade = Console.ReadLine();

Console.WriteLine("Qual é a sua comida favorita?");

var comida = Console.ReadLine();

Console.Write("Que legal! Eu adoraria visitar ");
Console.Write(cidade);
Console.Write(" e experimentar ");
Console.Write(comida);
Console.WriteLine("!");

//Exercício 3
Console.WriteLine("Digite o primeiro número: ");
var num1 = Console.ReadLine();

Console.WriteLine("Digite o segundo número ");
var num2 = Console.ReadLine();

var soma = Convert.ToInt32(num1) + Convert.ToInt32(num2);

Console.Write("A soma de ");
Console.Write(num1);
Console.Write(" e ");
Console.Write(num2);
Console.Write(" é ");
Console.WriteLine(soma);

//Exercício 4
Console.WriteLine("Quantos anos você tem?");
var idade = Console.ReadLine();

Console.Write("No próximo ano, você terá ");
Console.Write(Convert.ToInt32(idade)+1);
Console.WriteLine(" anos! ");

//Exercício 5
Console.Write("Digite o nome do produto: ");
var produto = Console.ReadLine();

Console.Write("Digite a quantidade em estoque: ");
var qtde = Console.ReadLine();

Console.Write("Produto '");
Console.Write(produto);
Console.Write("' cadastrado com ");
Console.Write(qtde);
Console.Write(" unidades em estoque. ");
