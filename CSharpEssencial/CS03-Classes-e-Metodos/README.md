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
