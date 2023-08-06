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
