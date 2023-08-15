# Classes e Métodos

## Classe

É um *tipo estruturado* que contém *membros*:

1. Atributos (dados: propriedades, campos)

2. Comportamentos (métodos)

Uma **classe** pode ser entendida como um modelo ou um *template*, que contém valores conhecidos como *membros de dados e conjuntos de regras*, e conhecidos como comportamentos ou métodos.

```csharp
class Pessoa
{
    // atributos
    public string Nome;
    public int Idade;
    public char Genero;

    // comportamentos
    public void Andar();
    public void Correr();
    public void Pular();
}
```

- `Pessoa` agora representa um **tipo** que contém **atributos e comportamentos**

- Agora é possível criar objetos do tipo `Pessoa`

- Para criar **objetos** a partir de uma classe usamos a palavra `new`

```csharp
Pessoa pessoa = new Pessoa();
pessoa.Nome = "Jaime Reyes";
pessoa.Idade = 20;
pessoa.Genero = 'M';
```

- Foi criada a variável **pessoa** do tipo `Pessoa`

- Foi atribuído valores aos atributos `Nome`, `Idade` e `Genero`

- `pessoa` é chamado de **objeto** do tipo `Pessoa`

- Dizemos que `pessoa` é uma **instância** da **classe** `Pessoa`

- Os objetos de classes são alocados na **memória Heap** e são *tipos por referência*

## Objeto

Um **objeto** é uma instância de uma classe, criada pelo operador `new`, e todos os membros públicos da classe podem ser acessados através do **objeto**.

### Classe vs. Objeto

Os **objetos** possuem características próprias, definidas pelos atributos e podem ser caracterizados e agrupados, enquanto que uma **classe** descreve todos os objetos de um tipo particular.

```csharp
// Formas de criar um objeto:

// * exemplo 1
Pessoa p1 = new Pessoa();
p1.Nome = "Markus";
p1.Idade = 31;
p1.Genero = 'M';

// * exemplo 2
var p2 = new Pessoa();
p2.Nome = "Connor";
p2.Idade = 27;
p2.Genero = 'M';

// * exemplo 3 (disponível a partir do C# na versão 10)
Pessoa p3 = new();
p3.Nome = "Kara";
p3.Idade = 28;
p3.Genero = 'F';

class Pessoa
{
    public string? Nome;
    public int Idade;
    public char Genero;
}
```

## Métodos

Os métodos representam os comportamentos das classes e são usados para executar ações e realizar a comunicação entre os objetos das classes.

Um método é um *bloco de código* que contém uma *série de instruções* que são executadas quando ele for chamado.

No C#, todas as instruções executadas são realizadas no contexto de um método, e todos os métodos são definidos em classes.

O método **Main** é o ponto de entrada para todos os aplicativos C# e é chamado pela **CLR** (*Common Language Runtime*) quando o programa é iniciado.

> C# é uma linguagem orientada a objetos que *não possui funções* declaradas fora das classes. Por causa dessa rigorosidade no C#, chamamos de **métodos** e não **funções** (embora tenham praticamente o mesmo objetivo).

```csharp
class MinhaClasse
{
    void MeuMetodo()
    {
        Console.WriteLine("Isso é um método");
    }
}
```

### Métodos: Parâmetros

Um parâmetro é um valor passado para o método.

Os métodos podem receber um ou mais parâmetros que são especificados dentro dos parênteses, após a definição do nome do método, e são separados por vírgulas.

Na definição do método devemos informar *o tipo e o nome do parâmetro*.

```csharp
Mensagens msg = new Mensagens();
msg.AprensetarPessoa("Maria", 'F');

class Mensagens
{
    public void AprensetarPessoa(string nome, char genero)
    {
        Console.WriteLine("Olá {0}, seja bem vind{1} ao sistema!", nome, genero == 'F' ? "a" : "o");
    }
}
```

### Métodos: Passando Parâmetros Entre Classes

```csharp
Aluno aluno = new Aluno();
Console.Write("Nome: ");
aluno.Nome = Console.ReadLine();
Console.Write("Idade: ");
aluno.Idade = Convert.ToInt32(Console.ReadLine());
Console.Write("Gênero: ");
aluno.Genero = Console.ReadLine().ToUpper()[0];
Console.Write("Aprovado: ");
aluno.Aprovado = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine();

Curso curso = new Curso();
curso.Resultado(aluno);

class Aluno
{
    public string? Nome;
    public int Idade;
    public char Genero;
    public bool Aprovado;
}

class Curso
{
    public void Resultado(Aluno a)
    {
        Console.WriteLine($"Aluno: {a.Nome}");
        Console.WriteLine($"Idadde: {a.Idade}");
        if (a.Genero == 'F')
            Console.WriteLine("Gênero: Feminino");
        else if (a.Genero == 'M')
            Console.WriteLine("Gênero: Masculino");
        if (a.Aprovado)
            Console.WriteLine("Aluno aprovado!");
        else
            Console.WriteLine("Aluno reprovado!");
    }
}
```

Quando *um tipo de referência é passado por valor* a um método, esse método receberá uma cópia da referência para a instância da classe.

O método chamado recebe uma *cópia do endereço da instância* e o método de chamada retém o endereço original da instância.

A instância de classe no método de chamada tem um endereço, o parâmetro do método chamado tem uma cópia do endereço e os dois endereços se referem ao mesmo objeto.
