// SAIDA DE DADOS: FORMATAÇÃO

string nome = "Mark";
int idade = 25;

// Console.Write();
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.WriteLine(" anos");

// concatenação de strings
Console.WriteLine(nome + " tem " + idade + " anos");

// interpolação de strings
Console.WriteLine($"{nome} tem {idade} anos");

// place holders (legacy)
Console.WriteLine("{0} tem {1} anos", nome, idade);

// SEQUÊNCIA DE ESCAPES
string texto = "Ele disse: \"O que você fez?\""; // permite o uso de aspas dentro da string
Console.WriteLine(texto);
string caminho = @"C:\User\user\source"; // desconsidera o caractere barra invertida
Console.WriteLine(caminho);

/* OUTRAS SEQUÊNCIAS DE ESCAPES

\a  -   Sinal sonoro (alerta)
\b  -   Backspace
\f  -   Alimentação de formulário
\n  -   Nova linha
\r  -   Carriagem return
\t  -   Tabulação horizontal
\v  -   Tabulação vertical
\'  -   Aspas simples
\"  -   Aspas duplas
\\  -   Barra invertida
\?  -   Interrogação
\u  -   Caractere ASCII na notação Unicode
\x  -   Caractere ASCII na notação hexadecimal

*/

Console.ReadKey();
