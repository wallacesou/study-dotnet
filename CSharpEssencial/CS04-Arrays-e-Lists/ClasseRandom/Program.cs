// CLASSE RANDOM

Random random = new Random();

// Gerando números alatórios
Console.WriteLine(random.Next());
Console.WriteLine(random.Next(20));
Console.WriteLine(random.Next(0, 20));
Console.WriteLine(random.NextDouble());

// Preenchendo um array com números aleatórios
byte[] numbers = new byte[10];

random.NextBytes(numbers);

Console.WriteLine(string.Join(", ", numbers));


Console.ReadKey();
