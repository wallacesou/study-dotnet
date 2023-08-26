// PARTIAL CLASS

using PartialClass;

MyPartialClass partialClass = new();
partialClass.Nome = "Mario";
var idade = partialClass.CalculaIdade(new DateTime(2003, 8, 7));

Console.WriteLine($"Nome: {partialClass.Nome}");
Console.WriteLine($"Idade: {Math.Round(idade.TotalDays / 365)}");


Console.ReadKey();
