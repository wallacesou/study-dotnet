# Arrays, ArrayList e List

As coleções formam uma estrutura importante de dados por meio da qual podemos criar e gerenciar grupos de objetos relacionados.

Existem duas maneiras de agrupar objetos:

- **Criando Arrays e objetos**
  
  - Arrays são úteis para criar e trabalhar com um *número fixo de objetos do mesmo tipo*.

- **Criando Coleções de objetos**
  
  - As coleções fornecem uma maneira mais flexível de trabalhar com *grupos de objetos*.

## Arrays

Os arrays são um *conjunto de elementos* do *mesmo tipo de dado* e de *tamanho fixo*.

Um *array de uma dimensão* é também conhecido como **vetor**, e um *array de mais de uma dimensão* é conhecido como uma **matriz**.

Podemos declarar um array definindo o *tipo dos seus elementos abrindo e fechando colchetes* seguido do *nome da variável* que identifica o array:

```csharp
int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 7, 8, 9, 10 };
```

Outras formas declarar um array:

```csharp
// Exemplo 1 / Declarando um array de strings
string[] nomes = new string[5] { "Ana", "Bea", "Lian", "Bill", "Jin" };

// Exemplo 2 / Ocultando o tamanho do array
string[] nomes = new string[] { "Ana", "Bea", "Lian", "Bill", "Jin" };

// Exemplo 3 / Ocultando a instância
string[] nomes = { "Ana", "Bea", "Lian", "Bill", "Jin" };

// Exemplo 4 / Atribuindo valores pelos índices
int[] numeros = new int[3];
numeros[0] = 1;
numeros[1] = 2;
numeros[2] = 3;
```

### Acessando elementos de um Array usando índices

Os elementos de um **Array** podem ser acessados usando um índice.

Um índice é o número associado a cada elemento da matriz, começando com o valor 0 e terminando com o *tamanho do Array menos 1*.

```csharp
string[] nomes = { "Ana", "Bea", "Lian", "Bill", "Jin" };
Console.WriteLine(nomes[1]); // Bea
```

### Acessando elementos de um Array usando o laço for

Podemos usar o laço `for` para percorrer elementos de um array.

Usamos a propriedades `Length` da classe **Array** para definir o **tamanho do array** no laço `for`.

A classe **Array** está no *namespace* **System** e fornece diversas propriedades e métodos para trabalhar com um *array* (`Length`, `Rank`, `Copy`, `Clear`, `Sort`, etc.).

```csharp
int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < numeros.Length; i++)
    Console.WriteLine($"Indíce ({i}): Número: {numeros[i]}");
```

### Acessando elementos de um Array usando o laço foreach

Podemos usar um laço `foreach` para *ler e recuperar* elementos de um Array *sem precisar* usar o *´índice* nem definir o tamanho do array.

A instrução `foreach` permite executar uma instrução ou um bloco de instruções para cada elemento presente em uma coleção *(Array, List, ArrayList, Stack, Queue, etc.)*.

```csharp
int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (int numero in numeros)
{
    Console.Write($"{numero} ");
}
```

Na declaração do `foreach`, entre parênteses criamos um *elemento do tipo* utilizado na *coleção*, e com o operador `in`, informamos a coleção a ser percorrida.

## Classe Array

Fornece métodos para criar, manipular, pesquisar e classificar arrays, servindo assim como a classe base para os arrays.

- `Reverse` - Inverte a sequência de um array unidimensional
  
  - Ex: `Array.Reverse(nome_array);`

- `Sort` - Ordena os itens de un array
  
  - Ex: `Array.Sort(nome_array);`

- `BinarySearch` - Faz a busca de um em um *array ordenado* de um valor usando o algoritmo de busca binário. Se for encontrado será retornado o *valor do índice* do elemento, caso contrário será *retornado um número negativo*.
  
  - Ex: `Array.BinarySearch(nome_array, objeto);`

```csharp
string[] nomes = { "Jin", "Zelda", "Bea", "Lian", "Bill", "Ana", "Maria", "James" };

// Array original
Console.Write("Original: ");
ExibirArray(nomes);

// Invertendo a ordem do array
Console.Write("Reverse: ");
Array.Reverse(nomes);
ExibirArray(nomes);

// Ordenando array
Console.Write("Sort: ");
Array.Sort(nomes);
ExibirArray(nomes);

// Localizando um item no array
Console.Write("Digite um nome pra ver se está no array: ");
string? nome = Console.ReadLine();
var indice = Array.BinarySearch(nomes, nome);

Console.WriteLine(indice >= 0 ? $"Achamos \"{nomes[indice]}\" na posição {indice}" : "Esse nome não foi encontrado!");

Console.ReadKey();

static void ExibirArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.Write($"{nome}, ");
    }
    Console.WriteLine("\n");
}
```

## Modificador Params

Esse modificador permite o parâmetro receber os valores separados por vírgula, sem a necessidade de instanciar o array ao passar como argumento.

```csharp
Calcular.Somar(7, 3, 2, 6, 1, 8 ); // com 'params' é possível passar os valores diretamente no método separados por vírgula

public class Calcular
{
    public static int Soma(params int[] numeros)
    {
        return numeros.Sum();
    }
}
```

- Nenhum parâmetro adicional é permitido após a palavra-chave `params` em uma declaração de método.

- Apenas uma palavra-chave `params` é permitida em uma declaração de método.

- Deve ser o *último argumento* na lista de parâmetros do método.

- Se o tipo declarado do parâmetro `params` não for um *array unidimensional*, vai ocorrer o erro do compilador **CS0225**.

**Ao chamar um método com um parâmetro `params`, podemos passar:**

- Uma lista separada por vírgula de argumentos do tipo dos elementos do array.

- Um *array de argumentos* do tipo especificado.

- Se não for enviado *nenhum argumento*, o comprimento da *lista de parâmetros* será zero.

## Arrays Multidimensionais

Os *arrays* podem ter *mais de uma dimensão* e a linguagem C# suporta *arrays* com até 32 dimensões.

Um *array multimensional* pode ser **declarado** adicionando **vírgula** entre **colchetes** na declaração do array:

```csharp
int[,] array2d;
int[,,] array3d;
int[,,,] array4d;
```

### Arrays com duas dimensões (bidimensionais)

Um *array bidimensional* pode ser pensado como uma **tabela**, que tem um número *x* de linhas e um número *y* de colunas.

```csharp
// Inicialização
int[,] a = new int[3,3];

// Representação
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
}

// Atribuição
a[1, 2] = 1; // 6

// Exibição
Console.WriteLine(a[1, 2]);
```

Podemos inicializar o *array* de formas diferentes:

```csharp
// Exemplo 1
int[,] a = new int[2, 2];

// Exemplo 2
int[,] a;
a = new int[2, 2,];

// Exemplo 3
int[,] a = new int[2, 2] { { 3, 5 }, { 4, 6 } };

// Exemplo 4
int[,] a = { { 3, 5 }, { 4, 6 } };
```

### Usando laços em arrays multidimensionais

#### Laço for

Podemos usar um laço `for` para *ler e recuperar* os valores dos elementos de um array bidimensional definindo um laço `for` para *cada uma das dimensões do array*.

Para obter as dimensões do array usamos o método `GetLength(n)` onde a primeira dimensão inicia com zero (**n=0**).

```csharp
int[,] a = new int[2, 2] { { 3, 5 }, { 4, 6 } };

for (int x = 0; x < a.GetLength(0); x++) // primeira dimensão
{
    for (int y = 0; y < a.GetLength(1); y++) // segunda dimensão
    {
        Console.WriteLine(a[x, y]);
    }
}
```

#### Laço foreach

Em **arrays de duas dimensões**, a instrução **foreach** processa elementos em ordem crescente de índice, começando com o índice 0 e terminando com *índice com valor* **Length-1**.

Os elementos são percorridos de modo a que os índices da dimensão mais à direita são aumentados primeiro e, em seguida, *os da próxima dimensão à esquerda*, e assim por diante seguindo para a esquerda.

```csharp
int[,] a = { { 1, 2, 3 }, { 4, 5, 6 } };

foreach(var n in a)
{
    Console.WriteLine(n);
}
```

## ArrayList

Um **ArrayList** é uma coleção *não genérica* cujo tamanho pode ser alterado *dinamicamente* e que armazena elementos de *vários tipos de dados*.

Esta coleção é uma alternativa a **Array** e também pode ser *indexada* individualmente e permite *alocação dinâmica de memória, inclusão, pesquisa e classificação* de elementos na coleção.

> O tamanho de uma **ArrayList** aumenta de forma *dinâmica* à medida que novos elementos são adicionados, e os elementos possuem um *índice* que começa com o valor 0 incrementando de 1 em 1, conforme adicionamos valores.

A classe *ArrayList* está no *namespace* `System.Collections` possui 3 construtores usados para uma *ArrayList*:

`ArrayList()` - É usado para criar uma instância da classe *ArrayList* que está vazia e sem *capacidade* inicial. (**Capacity** e **Count**)

`ArrayList(Int32)` - É usado para criar uma instância da classe *ArrayList* que está vazia e tem a *capacidade* incial especificada.

`ArrayList(ICollection)` - É usado para criar *uma lista de array inicializada* com os elementos da coleção especificada e tendo a mesma *capacidade* inicial que é copiada da coleção.

```csharp
using System.Collections;

// Exemplo 1
ArrayList lista;
lista = new ArrayList(); // Count = 0, Capacity = 0

// Exemplo 2
ArrayList lista = new ArrayList(); // Count = 0, Capacity = 0

// Exemplo 3
var lista = new ArrayList(); // Count = 0, Capacity = 0

// Exemplo 4 (C#10)
ArrayList lista = new(); // Count = 0, Capacity = 0
```

Para definir a capacidade, você pode colocar um número do tipo `Int32` dentro de parêntesis (de qualquer forma, à medida que adicionamos elementos, a capacidade da *ArrayList* vai aumentando):

```csharp
ArrayList lista = new ArrayList(5);
```

Atribuindo valores no momento da inicialização:

```csharp
var lista = new ArrayList()
{
    "Paulo", 4.5, true, " ", null
};
```

OBS: A capacidade padrão de uma *ArrayList* é 4. Se você atingir 5 elementos, a capacidade aumenta para 8. Se você atingir 9 elementos a capacidade aumenta para 12 e assim por diante, incrementando de 4 em 4.

> A *ArrayList* aceita diferente tipos de dados, diferentemente de uma *array* que só aceita um tipo de dado.

### Métodos para manipular elementos na lista

```csharp
lista.Add(Object value);
// inlcui um único elemento ao final de uma ArrayList
```

```csharp
lista.Insert(int index, Object value);
// inclui um elemento em uma posição especificada
```

```csharp
lista.Remove(Object value);
// remove a primeira ocorrência de um objeto especificado
```

```csharp
lista.RemoveAt(int index);
// remove elemento no índice especificado
```

```csharp
lista.RemoveRange(int index, int count);
// remove um número definido de elementos a partir de um índice especificado
```

```csharp
lista.Contains(Object item);
// verifica se elemento contém o item especificado, retorna true ou false
```

```csharp
lista.Sort();
// ordena a ArrayList com elementos do mesmo tipo na ordem ascendente
// Usa o algorítmo QuickSort para classificar os elementos da ArrayList
```

```csharp
lista.Clear();
// remove todos os elementos de uma ArrayList sem alterar sua capacidade
```

- Por exemplo:

```csharp
var lista = new ArrayList() { "Paul", 4.5, true, " ", null };

lista.Add(4.6);
lista.Insert(1, "Hard");
```

### Métodos para adicionar uma *coleção de elementos* a um *ArrayList*

```csharp
lista.AddRange(ICollection c);
// adiciona a coleção de elementos ao final da ArrayList
```

```csharp
lista.Insert(int index, ICollection c);
// adiciona a coleção de elementos na ArrayList na posição do índice especificado
```

- Por exemplo:

```csharp
var lista = new ArrayList() { "Jean", 19, true, " ", null };
int[] array = { 1, 2, 3, };

lista.AddRange(array);
lista.InsertRange(2, array);
```

> Quando trabalhamos com um ArrayList, estamos trabalhando em memória (*stack*)

### ArrayList (considerações finais)

A classe *ArrayList* foi projetada para conter coleções heterogenias de objetos. No entanto, nem sempre oferece o melhor desempenho.

Para tratar uma coleção heterogenia de objetos, a recomendação é usar a coleção `List<Object>`, e para tratar com uma coleção homogenia de objetos, a recomendação é usar a coleção `List<T>`.

## List

A coleção `List<T>` é uma coleção de *objetos fortemente tipados* que podem ser acessados *usando um índice que inicia em zero*, e possui métodos para classificar, pesquisar, modificar e manipular listas.

Esta coleção é a *versão genérica* da coleção **ArrayList**, sendo equivalente a ela, e esta presente no *namespace* **System.Collections.Generic**.

A classe `List<T>` pode ser usado para criar *uma coleção de tipos diferentes*, onde `T` representa *o tipo de objetos* que pode ser *int, string, double, etc.*, e também pode ser um *tipo complexo* como uma classe definida pelo usuário.

- Uma `List<T>` pode conter elementos do tipo especificado por `T`, fornece verificação de tipo em tempo de compilação e **não** executa **boxing-unboxing** porque é genérica.

- Os elemenstos podem ser adicionados a uma `List<T>` usando os métodos `.Add()`, `.AddRange()`, `.Insert()` e `.InsertRange()` ou usando a sintaxe de *inicializador de coleção*.

- Uma `List<T>` é uma *estrutura dinâmica* que pode ser *redimensionada*.

- Uma `List<T>` *inicia vazia* e seus elementos são alocados sob demanda.

- Uma `List<T>` como *Arrays* e *ArrayList* são *tipos de referência*: *uma variável refere-se ao objeto real, que deve ser instânciado na memória **Heap**.*

```csharp
// Exemplo 1
List<int> lista;
lista = new List<int>(); // Count = 0, Capacity = 0

// Exemplo 2
List<string> lista = new List<string>(); // Count = 0, Capacity = 0

// Exemplo 3
var lista = new List<string>(); // Count = 0, Capacity = 0

// Exemplo 4 (C#10)
List<int> lista = new(); // Count = 0, Capacity = 0
```

> `List` apresenta os mesmos métodos e comportamentos da `ArrayList`

| `ArrayLis`                                                                               | `List<T>`                                                 |
| ---------------------------------------------------------------------------------------- | --------------------------------------------------------- |
| `System.Collections`                                                                     | `System.Collections.Generic`                              |
| Coleção que pode armazenar itens de diversos tipos de dados. **Não** é fortemente tipada | Coleção de objetos *fortemente tipados*                   |
| Realiza operação de *boxing* e *unboxing*                                                | Não realiza operação de *boxing* e *unboxing*             |
| Apresenta menor desempenho                                                               | Apresenta melhor desempenho                               |
| Não apresenta segurança de tipo                                                          | Apresenta segurança de tipo                               |
| Seu uso deve ser evitado                                                                 | Recomendada para tratar objetos homogêneos e heterogêneos |

### List: Métodos Find

Os métodos Find espera que se forneça um ***predicado***:

- `.Find()` retorna o *primeiro elemento* que corresponde ao predicado fornecido.

- `.FindLast()` retorna o *último elemento* que corresponde ao predicado fornecido.

- `.FindIndex()` retorna o *índice do primeiro elemento* que corresponde ao predicado fornecido. Ele retorna -1 se não houver correspondência exata.

- `.FindLastIndex()` retorna o *índice do último elemento* que corresponde ao predicado fornecido. Ele retorna -1 se não houver correspondência exata.

- `.FindAll()` retorna uma *lista com todos os elementos* que correspondem às condições definidas pelo predicado especificado.

> Um ***predicado*** é uma *função/método de argumento único* que retorna um valor *booleano*.

```csharp
List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

frutas.Find(ProcuraPrimeiroR); // Pera
Console.WriteLine(frutas.Find(IniciaComA); // Abacate

static bool ProcuraPrimeiroR(string item)
{
    return item.Contains("r");
}
static bool IniciaComA(string item)
{
    return item.StartsWith("A");
}
```

#### Expressão Lambda

Para evitar sempre ter que escrever métodos para fornecer um predicado para os métodos Find a linguagem C# simplificou com um recurso chamado *expressão lambda*.

Uma expressão lambda é uma *função anônima*. Para criar uma expressão lambda, devemos especificar:

- *os parâmetros de entrada* no lado esquerdo do **operador lambda** `=>`.

- e definir a *expressão ou o bloco de instruções* do lado direito do *operador lambda*.

Exemplo:

```csharp
List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

string result = frutas.Find(f => f.Contains('n')); // Banana
```

Usando expressão lambda em todos os métodos Find:

```csharp
List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

string? primeiraFrutaComA = frutas.Find(f => f.Contains('a')); // Uva
string? ultimaFrutaComA = frutas.FindLast(f => f.Contains('a')); // Morango
int indexDaPrimeiraFrutaComE = frutas.FindIndex(f => f.Contains('e')); // 2
int indexDaUltimaFrutaComE = frutas.FindLastIndex(f => f.Contains('e')); // 4
var listaDeFrutasComE = frutas.FindAll(f => f.Contains('e')); // Pera, Abacate
```

## Indexadores

Os indexadores permitem que as instâncias de uma *classe* ou *struct* sejam indexadas como um array. Eles lembram as *propriedades*, mas seus acessores (get, set) recebem parâmetros.

Um indexador é um membro da classe que permite acessar uma *variável de membro* da classe ou struct os recursos de um *array*.

Quando você define um indexador para uma classe, essa classe se comporta como um *array virtual* e podemos acessar a *instância da classe* usando o operador de acesso ao array `[]` e também usar índices para *acessar e atribuir* valores como nos arrays.

- Declaramos um indexador *como um método* passando um modificador de acesso.

- Devemos definir um retorno de qualquer tipo, **exceto void**.

- O nome do indexador será a palavra-chave `this`.

- A lista de parâmetros de entrada deve ser envolta entre colchetes `[]`.

- Ao final basta definir os acessores `get` e `set` para definir a lógica de acesso retornando e atribuindo um valor.

```csharp
public int this[int index] // declaração do index
{
    get { .. }
    set { .. }
}
```

Exemplo de uso:

```csharp
Nomes n = new();
n[0] = "Robin";
n[1] = "Jake";
n[4] = "Miller";

string n1 = n[0]; // Robin
string n2 = n[1]; // Jake
string n3 = n[2]; // ""
string n4 = n[3]; // ""
string n5 = n[4]; // Miller
string n6 = n[5]; // ""


Console.ReadKey();

class Nomes
{
    string[] nomes = new string[10];

    public string this[int i]
    {
        get // => i >= 0 && i < nomes.Length ? nomes[i] : string.Empty;
        {
            if (i >= 0 && i < nomes.Length)
                return nomes[i];
            return "";
        }
        set
        {
            if (i >= 0 && i < nomes.Length)
                nomes[i] = value;
        }
    }
}
```

Os acessores `get` e `set` possuem a lógica que assegura que o *array* não será acessado fora dos limites (**10 elementos**).

- Um acessor `get` retorna um valor. Um acessor `set` define um valor.

- A palavra-chave `this` é usada para definir os indexadores.

- A palavra-chave `value` é usada para definir o valor que está sendo atribuído pelo indexador set.

- Um indexador não pode ser estático.

A utilidade de um indexador é fornecer uma sintaxe para acessar, através do índice, itens de um objeto que represente uma coleção.
