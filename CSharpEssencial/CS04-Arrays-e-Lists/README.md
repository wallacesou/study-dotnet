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
