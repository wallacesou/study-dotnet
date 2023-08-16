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

## Construtor

Os construtores são **tipos especiais de métodos** usados para *criar e inicializar objetos de uma classe*.

Na linguagem C# toda a classe precisa de um construtor para ser instanciada.

Sempre que uma classe for instanciada usando a palavra `new` o seu construtor é chamado.

Ao criar uma classe, um **construtor padrão sem parâmetros** é criado automaticamente, e ele é usado para criar instâncias da classe (o objeto) e **definir os valores padrões** para os membros da classe.

- Quando criamos uma classe sem construtor:

```csharp
Curso curso = new Curso();
// um construtor padrão é iniciado, definindo todos os membros da instância com valores padrão

class Curso
{
    public Aluno? Aluno;
    public string? Cursar;
}
```

- Agora criando uma classe com seu construtor:

```csharp
Aluno aluno = new Aluno("Maria", 25, 'F', true);
// quando definimos um construtor na classe, o construtor padrão não é criado

class Aluno
{
    public Aluno(string nome, int idade, char genero, bool aprovado)
    {
        Nome = nome;
        Idade = idade;
        Genero = genero;
        Aprovado = aprovado;
    }

    public string Nome;
    public int Idade;
    public char Genero;
    public bool Aprovado;
}
```

- Podemos criar mais de um construtor na classe:

```csharp
class Aluno
{
    public Aluno()
    {

    }

    public Aluno(string nome) => Nome = nome; // construtor usando body expression

    public Aluno(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public Aluno(string nome, int idade, char genero, bool aprovado)
    {
        Nome = nome;
        Idade = idade;
        Genero = genero;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public char Genero;
    public bool Aprovado;
}
```

Posso criar quantos construtores eu quiser, desde que sejam diferentes pela *quantidade ou tipos de parâmetros* no construtor.

- Não precisa repetir a atribuição entre construtores, podemos usar o `this`:

```csharp
Aluno aluno = new Aluno("Joana", 22, 'F', true);


class Aluno
{
    public Aluno()
    {

    }

    public Aluno(string nome) => Nome = nome; // construtor usando body expression

    public Aluno(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public Aluno(string nome, int idade, char genero, bool aprovado) : this(nome, idade)
    {
        Genero = genero;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public char Genero;
    public bool Aprovado;
}
```

Assim, você evita a duplicação de código.

## This (key-word)

Refere-se à instância atual da classe.

É usada como um *modificador* do **primeiro parâmetro** de um *método de extensão*.

Representa o objeto que está em execução, e assim, usando `this`, de forma implícita chamamos o objeto que está sendo usado.

### Usos comuns do *this*

1. É usado para diferenciar entre os *parâmetros dos métodos* e os *campos* quando eles tiverem o mesmo nome:
   
   ```csharp
   class Cliente
   {
     private string nome;
     private int idade;
   
     public Cliente(string nome, int idade)
     {
         this.nome = nome;
         this.idade = idade;
     }
   }
   ```

2. Usado para passar um objeto da instância atual como parâmetro para outros métodos:
   
   ```csharp
   class Aluno
   {
     public string? Nome;
     public int Idade;
   
     public void ExibirInfo(Aluno aluno)
     {
         Console.WriteLine($"{this}: {aluno.Nome}"); // 'this' aqui vai mostrar o nome desta classe (this class)
         Console.WriteLine($"Idade: {aluno.Idade}");
     }
   
     public void Aprensentar()
     {
         ExibirInfo(this); // 'this' aqui vai passar os valores desta classe para o método
     }
   }
   ```

3. Invocar outro construtor da mesma classe:
   
   ```csharp
   class Somar
   {
     public Somar(int n1, int n2)
     {
         Console.WriteLine($"Somando: {n1} + {n2} = {n1 + n2}");
     }
   
     public Somar(int n) : this(2, 2) // se chamar esse construtor, primeiro executa o construtor com dois parâmetros (passando esses valores dentro de this) e depois volta e executa o seu próprio construtor
     {
         Console.WriteLine($"Fiz uma continha pra você visto que só me passou o número {n} :)");
     }
   }
   ```
