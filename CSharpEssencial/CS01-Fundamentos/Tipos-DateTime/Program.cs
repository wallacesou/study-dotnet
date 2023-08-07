// TIPOS DE DADOS: DATETIME

// Obtendo data atual
DateTime data = DateTime.Now;
Console.WriteLine(data);

// Obtendo uma data específica
DateTime apenasData = new DateTime(2029, 09, 29); // (yyyy,MM,dd)
Console.WriteLine(apenasData);

// Obtendo uma data e hora específica
DateTime dataEHora = new DateTime(2029, 09, 29, 14, 45, 59); // (yyyy,MM,dd,HH,mm,ss)
Console.WriteLine(dataEHora);


// OPERAÇÕES COM DATA E HORA

// Extraindo informações de datas
Console.WriteLine("Ano: " + data.Year);
Console.WriteLine("Mês: " + data.Month);
Console.WriteLine("Dia: " + data.Day);
Console.WriteLine("Hora: " +data.Hour);
Console.WriteLine("Minutos: " + data.Minute);
Console.WriteLine("Segundo: " + data.Second);
Console.WriteLine("Milissegundos: " + data.Millisecond);

// Adicionando valores
Console.WriteLine(data.AddDays(30));
Console.WriteLine(data.AddMonths(1));
Console.WriteLine(data.AddHours(2));
Console.WriteLine(data.AddYears(5));

// Obtendo o dia da semana e do ano
Console.WriteLine(data.DayOfWeek);
Console.WriteLine(data.DayOfYear);

// Data e hora no formato longo ou curto
Console.WriteLine("Data por extenso: " + data.ToLongDateString());
Console.WriteLine("Data abreviada: " + data.ToShortDateString());

Console.WriteLine("Hora por extenso: " + data.ToLongTimeString());
Console.WriteLine("Hora abreviada: " + data.ToShortTimeString());

Console.ReadKey();
