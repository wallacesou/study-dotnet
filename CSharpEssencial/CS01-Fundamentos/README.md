# Fundamentos da Linguagem C#

## Introdução a Tipos de Dados

As informações em um computador são armazenadas inicialmente na memória RAM. A memória do computador se organiza como um armário com várias divisões, sendo cada divisão identificada por um endereço. Como temos diversos tipos de informações, para otimizar o armazenamento, a linguagem C# divide essas informações em diferentes tipos de dados.

> Exemplo de tipos de dados: números inteiros, números decimais, carácteres simples, textos, tipos complexos, estruturas de dados, etc.

A linguagem C# é uma linguagem *fortemente tipada*, por isso precisamos sempre informar qual o tipo de dado que vamos usar ao declarar uma *variável ou constante*. É para isso que servem os *tipos pré-definidos* da linguagem C#.

### Tipos de dados de referência e de valor

**Tipos de referência:** Não armazenam os dados diretamente e cada variável contém uma referência ao local da memória onde os dados estão armazenados.

- Os tipos de referência são armazenados na memória **Heap**.

**Tipos de valor:** Armazenam diretamente seus dados e cada variável tem sua própria cópia dos dados.

- Os tipos de valor são armazenados na memória **Stack (LIFO – Last in First Out)**.

![Charp Data Type](./img/csharp-data-types.png "C# Data Type")

#### Variáveis e Constantes

Uma **variável** é um nome que representa a informação ou dados armazenados na memória durante a execução do programa. Cada variável em C# precisa ter **um tipo específico**, que determina o *tamanho e o uso da memória*.

Uma **constante** é uma variável *cujo valor não se altera* durante o tempo de vida do programa. Para declarar uma constante, basta usar `const` antes do tipo da variável.

### Números Inteiros

| Alias    | Tamanho                                              | Tipo .NET      |
| -------- | ---------------------------------------------------- | -------------- |
| `sbyte`  | 8 bits com sinal                                     | System.SByte   |
| `byte`   | 8 bits                                               | System.Byte    |
| `short`  | 16 bits com sinal                                    | System.Int16   |
| `ushort` | 16 bits                                              | System.UInt16  |
| `int`    | 32 bits com sinal                                    | System.Int32   |
| `uint`   | 32 bits                                              | System.UInt32  |
| `long`   | 64 bits com sinal                                    | System.Int64   |
| `ulong`  | 64 bits                                              | System.UInt64  |
| `nint`   | 32 bits ou 64 bits com sinal (depende da plataforma) | System.IntPtr  |
| `nuint`  | 32 bits ou 64 bits (depende da plataforma)           | System.UIntPtr |

- São tipos por valor armazenados na stack e dão suporte a operadores aritméticos de comparação e de igualdade.

- Se nenhum valor for atribuído a variável, o valor padrão dos inteiros é `0`.

```csharp
int valor = 123;
// ou
System.Int32 valor = 123;
```

### Números de Ponto Flutuante

| Alias     | Precisão        | Tamanho  | Tipo .NET      |
| --------- | --------------- | -------- | -------------- |
| `float`   | 6 a 9 dígitos   | 4 bytes  | System.Single  |
| `double`  | 15 a 17 dígitos | 8 bytes  | System.Double  |
| `decimal` | 28 a 29 dígitos | 16 bytes | System.Decimal |

- Representam números reais.

- São tipos por valor armazenados na *stack* e dão suporte a operadores aritméticos de comparação e de igualdade.

- Se nenhum valor for atribuído a variáveis de ponto flutuante, o valor padrão é `0`.

- O tipo `double` é usado para cálculos científicos e o decimal para cálculos financeiros.

- São inicializadas usando os literais reais com os sufixos:
  
  - `d` ou `D` para `double` *(opcional)*
  
  - `f` ou `F` para `float` *(obrigatório)*
  
  - `m` ou `M` para `decimal` *(obrigatório)*

```csharp
float n1 = 1.234F;
double n2 = 1.234;
decimal n3 = 1.234M;
```

### Tipos Boolean e Char

| Alias  | Tamanho                | Tipo .NET      |
| ------ | ---------------------- | -------------- |
| `bool` | 8 bits (true or false) | System.Boolean |
| `char` | 16 bits                | System.Char    |

- São tipos por valor armazenados na *stack*.

- O tipo `bool` pode ser obtido como resultado de operações e comparações.

- O valor padrão do tipo `bool` é `false`.

- O valor padrão do tipo `char` é `'\0'`.

```csharp
// Bool
bool ativo = true;

// Char
char caractere = 'A';
char unicode = '\u0041';
```

### Tipos de Referência: String, Object e Dynamic

| Alias     | Definição                                                                                          | Tipo .NET     |
| --------- | -------------------------------------------------------------------------------------------------- | ------------- |
| `string`  | Representa uma sequência de zero ou mais caracteres Unicode (são imutáveis)                        | System.String |
| `object`  | É o tipo base para todos os outros tipos                                                           | System.Object |
| `dynamic` | São resolvidos em tempo de execução <br>Se comportam como o tipo `object` na maioria das situações | System.Object |

- São tipos de referência.

- O valor padrão é `null`.

```csharp
// String: comum para textos
string frase = "Curso C# Essencial";
frase = "Criando uma nova frase";
// OBS: como strings são imutáveis, aqui foi criada uma nova alocação de memória para esse novo valor

// Object: suporta todos os tipos de dados
object nome = "Ana";
object idade = 25;
object altura = 1.60;
object ativo = true;
object genero = 'F';

// Dynamic: permite usar recursos avançados da linguagem
dynamic nome = "Ana";
dynamic idade = 25;
dynamic altura = 1.60;
dynamic ativo = true;
dynamic genero = 'F';
```

### DateTime

- `DateTime` é uma **struct**.

- Representa um momento no tempo expresso como uma data e hora

- Uma variável do tipo **DateTime** é um *tipo de valor*

- O valor padrão de um **DateTime** é: `01/01/0001 00:00:00`

- Ao usar **DateTime** a representação para o português brasileiro usa o formato: `dd/MM/yyyy HH:mm:ss`

```csharp
// Obtendo data e hora atual
DateTime data = DateTime.Now;

// Criando uma data específica
DateTime data = new DateTime(2021,05,21); // (yyyy,MM,dd)

// Criando uma data e hora específica
DateTime data = new DateTiem(2021,05,21,21,41,20); // // (yyyy,MM,dd,HH,mm,ss)
```

##### Operações com data e hora

1. Extrair informações como dia, mês, hora, ano, ect:
   
   - `Year`, `Month`, `Day`, `Hour`, `Minute`, `Second`, `Millisecond`

2. Adicionar dias, horas, mês, anos, ect:
   
   - `AddDays`, `AddHours`, `AddMonths`, `AddYears`

3. Obter dia da semana e do ano:
   
   - `DayOfWeek`, `DayOfYear`

4. Expressar data no formato longo e abreviado
   
   - `ToLongDateString`, `ToShortDateString`

5. Expressar hora no formato longo e abreviado
   
   - `ToLongHourString`, `ToShortHourString`

```csharp
// Extraindo informações de datas
Console.WriteLine(data.Year);
Console.WriteLine(data.Month);
Console.WriteLine(data.Day);
Console.WriteLine(data.Hour);
Console.WriteLine(data.Minute);
Console.WriteLine(data.Second);
Console.WriteLine(data.Millisecond);

// Adicionando valores
Console.WriteLine(data.AddDays(30));
Console.WriteLine(data.AddMonths(1));
Console.WriteLine(data.AddHours(2));
Console.WriteLine(data.AddYears(5));

// Obtendo o dia da semana e do ano
Console.WriteLine(data.DayOfWeek);
Console.WriteLine(data.DayOfYear);

// Data e hora no formato longo ou curto
Console.WriteLine(data.ToLongDateString());
Console.WriteLine(data.ToShortDateString());

Console.WriteLine(data.ToLongTimeString());
Console.WriteLine(data.ToShortTimeString());
```

### Nullable Types

Uma variável de um *tipo de valor* não pode conter o valor `null`, pois o valor padrão de uma variável de um tipo de valor como int é `0`.

```csharp
int valor = null; // error
```

Um **Nullable Type** é um tipo de valor que pode receber um valor `null`. Os **Nullable Types** permitem atribuir um valor `null` a um *tipo de valor*.

```csharp
Nullable<int> a = null;
Nullable<bool> b = null;
// ou
int? a = null;
bool? b = null; // agora b suporta true/false/null
```

#### Cuidado!

Um `int?` é diferente de `int`. Int é um tipo *Non-Nullable Type*. Não tente atribuir um valor ou resultado de uma operação do tipo `int?` ao tipo `int`.

```csharp
int? a = null;
int b = a; // error
```

Para resolver esse problema, utilize o operador de coalescência nula.

##### Operador de coalescência nula (`??`)

```csharp
int? a = null;
int b = a ?? 0; // se 'a' for null, retorna 0
```

#### Propriedades somente leitura: HasValue e Value

- Só funciona em **Nullable Types**.

- `.HasValue` retorna `true` ou `false`

- `.Value` retorna o valor

```csharp
if (a.HasValue) // (a != null)
    Console.WriteLine(a.Value);
else
    Console.WriteLine("a não possui um valor (null)");
```

## Nomenclaturas: convenções

Um **identificador** é o nome que você atribui a um tipo (classe, interface, *struct*, *record*, *delegate* ou *enum*), membro, propriedade, variável ou *namespace*.

Utilize nomes significativos que permitem compreender com facilidade o propósito do identificador.

### Regras gerais para identificadores válidos

- Devem começar com letra ou sublinhado (`_`)

- Não podem iniciar com números ou caracteres especiais

- Não podem conter espaços

- Podem usar caracteres Unicode (não recomendado)

- Não podem ser uma palavra reservada da linguagem (`if`, `int`, `string`, `class`, etc.)

- Não podem exceder 512 caracteres

```csharp
// Válidos
int idade;
string sobrenome2;
double _saldo; // usado para campos internos privados e somente leitura
float valorTotal; // Camel Case, usados em nomes de variáveis, parâmetros e campos internos privados
string NomeCompleto; // Pascal Case, usado em nome de classes, métodos, interfaces e propriedades
const double PI = 3.1415; // Constantes
```

## Formatação de Saída de Dados

```csharp
string nome = "Mark";
int idade = 25;

// concatenação de strings
Console.WriteLine(nome + " tem " + idade + " anos");

// interpolação de strings
Console.WriteLine($"{nome} tem {idade} anos");

// place holders (legacy)
Console.WriteLine("{0} tem {1} anos", nome, idade);

// SEQUÊNCIA DE ESCAPES
string texto = "Ele disse: \"O que você fez?\"";
Console.WriteLine(texto);
```

### Sequencias de Escape

Usados para usar certos caracteres especiais em strings.

| Escape | Representação                          |
| ------ | -------------------------------------- |
| `\a`   | Sinal sonoro (alerta)                  |
| `\b`   | Backspace                              |
| `\f`   | Alimentação de formulário              |
| `\n`   | Nova linha                             |
| `\r`   | Carriagem return                       |
| `\t`   | Tabulação horizontal                   |
| `\v`   | Tabulação vertical                     |
| `\'`   | Aspas simples                          |
| `\"`   | Aspas duplas                           |
| `\\`   | Barra invertida                        |
| `\?`   | Interrogação                           |
| `\u`   | Caractere ASCII na notação Unicode     |
| `\x`   | Caractere ASCII na notação hexadecimal |

## Conversão de Tipos

- A linguagem C# é **estaticamente tipada** em tempo de compilação

- Após uma variável ser declarada ela *não pode ser declarada novamente*

- Nem pode ser usada para armazenar valores de outro tipo de dados, a menos que este tipo deda seja convertível para o tipo de dado da variável

### Conversão Implícita

O compilador C# converte automaticamente um tipo de dado em outro tipo (*quando a conversão dos tipos for compatível*).

```csharp
int a = 100; // int usa 4 bits
double b = a; // double usa 8 bits
```

### Conversão Explícita

A conversão tem que ser feita manualmente de forma explícita.

```csharp
double b = 12.2938;
int a = (int) b;
```

O resultado de uma operação pode ou não ser um inteiro.

```csharp
int num1 = 10;
int num2 = 4;

float result = num1 / num2; // 2

float result = (float) num1 / num2; // 2.5
```

### Método .ToString()

O método `.ToString()` da classe **Object** retorna uma string que representa o objeto atual. Converte um objeto em sua *representação de cadeia de caracteres para exibição*.

> Como **Object** é pai de todos os objetos na linguagem C# todos os objetos herdam o método `.ToString()` da classe **Obejct**.

```csharp
double b = 12.2938;
string c = b.ToString();
Console.WriteLine(c);
```

### Classe Convert()

Fornece diversos métodos para converter um tipo de dado em outro tipo de dado.

Essa classe pertence ao *namespace* System.

| Método        | Descreição                                  |
| ------------- | ------------------------------------------- |
| `ToBoolean()` | converte um tipo para um valor Boolean      |
| `ToChar()`    | converte um tipo para o tipo char           |
| `ToDouble()`  | converte um tipo para o tipo double         |
| `ToInt16()`   | converte um tipo para o tipo 16-bit (short) |
| `ToInt32()`   | converte um tipo para o tipo 32-bit (short) |
| `ToString()`  | converte um tipo para uma string            |

```csharp
int a = 100;
double b = 12.2938;
string c = b.ToString();

Console.WriteLine(Convert.ToInt32(b));
Console.WriteLine(Convert.ToDecimal(c));
Console.WriteLine(Convert.ToBoolean(a)); // se for diferente de 0 sempre vai ser true
```

#### Mas e se não couber?

As conversões de *ampliação* ou *estreitamento* entre dois tipos de dados que não resultarem em *perda de dados*, terão êxito e o método retornará um valor do tipo de destino.

Quando uma conversão de *estreitamento de dados* resultar em perda de dados, vai ocorrer uma **OverflowException** em tempo de execução.

```csharp
int a = 1000;
Console.WriteLine(Convert.ToByte(a)); // não cabe (byte: 0 a 255)
```

## Entrada de dados

`ReadLine()`: lê uma única linha de entrada do fluxo de entrada padrão. Retorna a mesma *string*.

```csharp
Console.Write("Informe seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Seu nome é {nome} e você tem {idade} anos.");
```

`Read()`: lê apenas um único caractere do fluxo de entrada padrão. Retornar o *valor ASCII* do caractere.

```csharp
Console.WriteLine("Digite algo:");
var ascii = Console.Read();
Console.WriteLine($"O valor ASCII do primeiro caractere é {ascii}");
```

`ReadKey()`: lê apenas um único caractere do fluxo de entrada padrão. Obtém a próxima tecla pressionada pelo usuário. Retorna um tipo **ConsoleKeyInfo**.

É usado também para segurar a tela até que o usuário pressione uma tecla.

```csharp
Console.ReadKey();
```

## Operadores Aritméticos

### Operadores binários

| Operação                  | Operador | Exemplo |
| ------------------------- | -------- | ------- |
| adição                    | `+`      | x + y   |
| subtração                 | `-`      | x - y   |
| multiplicação             | `*`      | x * y   |
| divisão                   | `/`      | x / y   |
| módulo (resto da divisão) | `%`      | x % y   |

```csharp
Console.Write("Digite um número: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite outro número: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"Soma de {x} + {y} = {x+y}");
Console.WriteLine($"Subtração de {x} - {y} = {x-y}");
Console.WriteLine($"Multiplicação de {x} * {y} = {x*y}");
Console.WriteLine($"Divisão de {x} / {y} = {x/y}");
Console.WriteLine($"Módulo de {x} % {y} = {x%y}");
```

### Classe Math

Possui constantes e diversos **métodos estáticos** usados para cálcuos matemáticos

| Métodos    | Resultado                                  | Exemplo                 |
| ---------- | ------------------------------------------ | ----------------------- |
| `Math.PI`  | Representa o número PI                     | PI = 3.141516171819     |
| `Math.E`   | Representa a base `e` do logaritmo natural | E = 2.7182818284590     |
| `Cos(x)`   | Obtém o cosseno de `x`                     | Cos(2.0) = -0.4164...   |
| `Sin(x)`   | Obtém o seno de `x`                        | Sin(2) = 0.909297       |
| `Tan(x)`   | Obtém o tangente de `x`                    | Tan(1.5) = 14.1014      |
| `Sqrt(x)`  | Calcula a raiz quadrada de `x`             | Sqrt(169) = 13          |
| `Pow(x,y)` | Obtém o valor de `x` elevado a `y`         | Pow(2,4) = 16           |
| `Abs(x)`   | Fornece o valor absoluto `x`               | Abs(-4.5) = 4.5         |
| `Max(x,y)` | Obtém o maior valor entre dois números     | Max(2.46,2.56) = 2.56   |
| `Min(x.y)` | Obtém o menor valor entre dois números     | Min(1.92,1.89) = 1.89   |
| `Log10(x)` | Calcula o logaritmo `x` na base 10         | Log10(3.0) = 0.47712... |
| `Log(x)`   | Calcula o logaritmo `x` na base `e`        | Log(3) = 1.098612       |
| `Exp(x)`   | Retorna o exponencial (`e` elevado a `x`)  | Exp(5.0) = 54.59...     |

```csharp
Console.Write("Digite um número: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite outro número: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Raíz quadrada de {x} = {Math.Sqrt(x)}");
Console.WriteLine($"Potência de {x} elevado a {y} = {Math.Pow(x,y)}");
Console.WriteLine($"Valor máximo entre {x} e {y} = {Math.Max(x,y)}");
Console.WriteLine($"Valor mínimo entre {x} e {y} = {Math.Min(x,y)}");
Console.WriteLine($"Seno de {x} = {Math.Sin(x)}");
Console.WriteLine($"Cosseno de {x} = {Math.Cos(x)}");
Console.WriteLine($"Tangente de {x} = {Math.Tan(x)}");
Console.WriteLine($"Exponencial de {x} = {Math.Exp(x)}");
```

## Inferência de Tipos

A partir da versão 3.0 da linguagem C# as variáveis que forem declaradas no escopo do método podem possuir *um tipo implícito **var**.*

Usar a palavra-chave **var** para instruir o compilador para *deduzir o tipo da variável da expressão* a partir do valor que é atribuído na sua inicialização.

O tipo inferido pode ser *um tipo interno, um tipo anônimo, um tipo definido pelo usuário ou um tipo definido na biblioteca de classes da plataforma .NET*.

```csharp
var x = 0; // x é int

var y; // error: implicity-typed
```

### Limitações

- A palavra-chave **var** só pode ser usando quando uma variável local é declarada e inicializada na mesma instrução.

- Não é possível inicializar a variável como **null**.

- Múltiplas variáveis de tipo *implícito* não podem ser inicializadas na mesma instrução.

- Não podemos alterar o tipo da variável **var** depois de inicializada.

### Usos do Var

- Considerado um açúcar sintático (*sugar syntax*)

- Usada para declarar *tipos anônimos*

- Usada em laços `for` e `foreach`

- Usada em instruções `using`

## Operadores de Incremento e Decremento

Objetivo: Aumentar ou diminuir exatamente em uma unidade o valor de uma variável.

| Operador | Exemplo          | Significado                               |
| -------- | ---------------- | ----------------------------------------- |
| ++       | `x++;` ou `++x;` | Incrementa x de uma unidade (`x = x + 1`) |
| --       | `x--;` ou `--x;` | Decrementa x de uma unidade (`x = x - 1`) |

### Diferença entre pré e pós incremento/decremento

```csharp
int a, resultado;

a = 0;
resultado = a++ + 10; // 10 -> primeiro calcula e depois incrementa
Console.WriteLine(resultado);

a = 0;
resultado = ++a + 10; // 11 -> primeiro incrementa e depois calcula
Console.WriteLine(resultado);
```

## Constantes

Constantes são valores imutáveis que são conhecidos em *tempo de compilação* e não mudam durante a vida útil do programa.

As constantes são declaradas usando o modificador **const** e devem ser inicializadas na sua declaração.

```csharp
const int ANO = 12; // opção 1
const int MES = 30, SEMANA = 7, QUIZENA = 15; // opção 2

const int MESES_ANO = 12;
const int DIAS_ANO = 365;

const float DIAS_POR_MES = (float)DIAS_ANO / (float)MESES_ANO;
```

## Operadores Relacionais

A característica dos operadores relacionais é que o resultado de uma operação relacional terá como resultado `true` ou `false` (*verdadeiro ou falso*).

| Operador | Significado    | Exemplo (`int x = 10; y = 20;`)     |
| -------- | -------------- | ----------------------------------- |
| `==`     | Igualdade      | `x == y` (resultado será **False**) |
| `>`      | Maior que      | `x > y` (resultado será **False**)  |
| `<`      | Menor que      | `x < y` (resultado será **True**)   |
| `>=`     | Maior ou igual | `x >= y` (resultado será **False**) |
| `<=`     | Menor ou igual | `x <= y` (resultado será **True**)  |
| `!=`     | Diferente de   | `x != y` (resultado será **True**)  |

### Comparando números

```csharp
int x = 10;
int y = 20;

Console.WriteLine($"{x} == {y}: {x==y}");
Console.WriteLine($"{x} > {y}: {x==y}");
Console.WriteLine($"{x} < {y}: {x==y}");
Console.WriteLine($"{x} >= {y}: {x==y}");
Console.WriteLine($"{x} <= {y}: {x==y}");
Console.WriteLine($"{x} != {y}: {x == y}");
```

### Comparando strings

```csharp
string a = "Curso";
string b = "curso";
Console.WriteLine(a == b);

// Usando o método Equals()
Console.WriteLine(a.Equals(b));
```

## Operadores Lógicos

São usados em expressões lógicas e trabalham com operandos boolenaos e seu resultado será `true` ou `false` (*verdadeiro ou falso*).

| Operação | Significado | a = true; b = false;  | Comportamento                                                                               |
| -------- | ----------- | --------------------- | ------------------------------------------------------------------------------------------- |
| `&&`     | AND         | `a && b` => `false`   | Retornará `false` se apenas uma das condições for **False**                                 |
| `\||`    | OR          | `!(a && b)` => `true` | Retornará `true` se apenas uma das condições for **True**                                   |
| `!`      | NOT         | `!(a && b)` => `true` | Inverte o resultado, retorna `false` se o resultado da expressão for **True**, e vice-versa |

## Precedência de Operadores

As expressões como operadores de maior precedência são avaliadas primeiro. Quando dois operadores tiverem a *mesma precedência* eles são avaliados com base na **associatividade** do operador que pode ser *da direita para esquerda* ou *da esquerda para a direita*.

| Operadores  | Ordem de Precedência               | Associatividade            |
| ----------- | ---------------------------------- | -------------------------- |
| Aritméticos | `*`, `/`, `%`, `+`, `-`            | Da esquerda para a direita |
| Atribuição  | `=`, `*=`, `/=`, `%=`, `+=`, `-=`  | Da direita para a esquerda |
| Incremento  | `++`, `--`, (prefixo) `++a`, `--a` | Da direita para a esquerda |
| Decremento  | `++`, `--`, (sufixo) `a++`, `a--`  | Da esquerda para a direita |
| Relacionais | `<`, `>`, `<=`, `>=`, `==`, `!=`   | Da esquerda para a direita |
| Lógicos     | `!`, `&&`, `\||`                   | Da esquerda para a direita |

Os operadores `[]` e `()` possuem a maior ordem de precedência nesta ordem, e podem ser usados para alterar a ordem de precedência.

```csharp
int x = 10 - 2 * 3; // 4
int y = (10 - 2) * 3 // 24
bool a = !(9 != 8) && 5 >= 7 || 8 >= 6; // true
bool b = !(9 != 8) && (5 >= 7 || 8 >= 6); // false
```

### Precedência de associatividade

```csharp
int a = 5, b = 6, c = 3;
int resultado = a = b = c; // 3 - atribuição da direita para esquerda
```

## Operadores Unitários, Binários e Ternários

### Operador Unitário

```csharp
int a = +5;
float b = -2.7f;

int x = 1;
int y = +x;
```

### Operador Binário

```csharp
int a = 2 * 5;
bool b = true && true;
```

### Operador Ternários (condicional)

```csharp
bool a = true, b = false;
string resultado = a == b ? "é igual" : "é diferente";
```

#### Operador Ternário Aninhado

```csharp
int x = 10, y = 20;
string msg = x > y ? "x é maior que y" :
                    x < y ? "x é menor que y" :
                    x == y ? "x é igual a y" : "sem resultado";
```
