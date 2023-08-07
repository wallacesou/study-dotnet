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

Nomenclaturas: convenções

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
