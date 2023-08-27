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
