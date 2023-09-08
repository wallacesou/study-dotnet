# Programação Orientada a Objetos

A **Programação Orientada a Objetos (POO)** é uma abordagem para desenvolvimento de software no qual a estrutura do software é baseada em **objetos** que **interagem** uns com os outros para realizar uma tarefa.

Essa iteração toma a forma de mensagens que são trocadas entre os objetos sendo que em resposta a uma mensagem um objeto pode executar uma *ação ou método*.

> - O mundo é um sistema orientado a objetos
> - O software é o paradigma da orientação a objetos

## Vantagens da abordagem Orientada a Objetos

- Uma transição mais intuitiva dos modelos de análise de negócios para a implementação do software.

- A capacidade de manter e implementar mudanças nos programas de forma rápida e eficiente.

- A capacidade de criar sistemas de software através de um processo de equipe, permitindo a especialistas trabalharem em partes do sistema.

- A capacidade de reutilização dos componentes de código em outros programas e a aquisição de componentes escritos por desenvolvedores de terceiros para aumentar a funcionalidade dos seus programas com pouco esforço.

- Uma melhor integração com sistemas distribuídos e com baixo acoplamento.

- Uma melhor integração com os sistemas operacionais modernos.

- A capacidade de criar uma interface de usuário gráfica intuitiva para os usuários.

## As características da POO

Um objeto é uma estrutura que incorpora dados e comportamentos para trabalhar com esses dados.

- Um **objeto** é uma instância de uma ***classe***.

#### Pilar: Abstração

Abstração em programação de computadores é uma forma de reduzir a complexidade e tornar o projeto e a implementação mais eficientes em sistemas complexos de software.

Abstrair é a habilidade de se concentrar nos *aspectos essenciais de um contexto qualquer*, ignorando características menos importantes, ou seja, são propriedades comuns de um conjunto de objetos, omitindo os *detalhes*.

Sem esta capacidade de abstrair ou filtrar as propriedades de objetos, você teria muita dificuldade de processar o excesso de informações e de se concentrar nas tarefas em mãos.

#### Pilar: Encapsulamento

O encapsulamento é o processo no qual o acesso direto aos dados de um objeto não é permitido. Ele está ocultado e protegido.

Ao usar o encapsulamento, o código de cada objeto deve controlar apenas seu próprio estado.

O encapsulamento adiciona segurança a aplicação pelo fato de esconder as propriedades dos objetos do acesso direto criando uma espécie de caixa preta.

No encapsulamento o objeto esconde seus dados de outros objetos e permite que os dados sejam acessados por intermédio de seus próprios métodos.

#### Pilar: Herança

A herança é um recurso da POO que permite que você *crie novas classes* que *reutilizam, estendem e modificam* o comportamento definido em outras *classes existentes*.

A classe cujos membros são herdados é chamada de **classe base** e a classe que herda esses membros é chamada de **classe derivada**.

A **classe base** fornece uma funcionalidade comum (dados e comportamentos) e as **classes derivadas** herdam ou substituem essa funcionalidade.

#### Pilar: Polimorfismo

Polimorfismo (*do grego: **poli** = muitas, **morphos** = formas*) é a habilidade de objetos distintos responderem a mesma mensagem de sua própria maneira.

Você pode enviar a mensagem mover para cada objeto semelhante a um veículo e cada um vai se comportar de maneira diferente para atender a sua solicitação.

Quando uma mesma mensagem pode ser processada de diferentes formas temos um exemplo de polimorfismo.

Usando polimorfismo podemos invocar métodos da classe derivada através da classe base em tempo de execução e permitir que classes forneçam diferentes implementações de métodos que são chamados com o mesmo nome.

## Herança

A herança é um mecanismo pelo qual uma classe (conhecida como classe **derivada ou subclasse**) pode *adquirir propriedades e métodos* de outra classe (conhecida como **base ou superclasse**).

A classe **derivada** é capaz de reutilizar o código da classe **base**, evitando duplicação de código e permitindo a especialização de comportamentos.

A relação entre a classe **derivada** e a classe **base** é estabelecida através do **sinal de dois pontos** (`:`) seguido do *nome da classe base* após a declaração da *classe derivada*.

```csharp
class ClasseBase
{
    // código
}

class ClasseDerivada : ClasseBase
{
    // código
}
```

### Herança — Benefícios

1. **Reutilização de código:** Com a herança, você pode criar uma classe base com atributos e métodos comuns que são compartilhados por várias classes derivadas. Isso evita a necessidade de duplicar código em cada classe,  tornando o código mais limpo, conciso e mais fácil de manter.

2. **Especialização:** Através da herança, você pode *criar classes derivadas que herdam as características da classe base*, mas também podem *ter atributos e comportamentos específicos*. Isso permite criar hierarquias de classes que representam diferentes níveis de especialização, o que torna o código mais flexível e escalável.

3. **Extensibilidade:** A herança permite adicionar *novos atributos e métodos a uma classe derivada* sem modificar a classe base. Assim, você pode estender o comportamento de uma classe sem afetar outras partes do código que dependem dela.

4. **Encapsulamento:** A herança pode ser combinada com o conceito de modificadores de acesso (`public`, `private`, `protected`, etc.) para controlar o acesso aos membros da classe base e seus derivados. Isso ajdua a proteger o código e a garantir que apenas os membros apropriados sejam acessíveis para as classes que precisam deles.

#### Herança: modificadores de acesso

Um membro com o modificador `protected` é acessível dentro da sua classe e por instâncias das *classes derivadas*.

Uma *classe derivada* tem acesso aos *membros* definidos com o modificador `public`, `internal`, `protected` e `protected internal` de uma *classe base*.

Membros com o modificador `private` embora sejam herdados *não podem ser acessados* pela classe derivada (*subclasse*).

```csharp
internal class Pessoa // classe base
{
    // 'protected': restringe o acesso de classes não derivadas
    protected string? Nome { get; set; }
    protected char Genero { get; set; }
    protected void Apresentar()
    {
        Console.WriteLine($"{this}: {Nome}");
    }
}
```

### Herança: Construtores

A *classe base* e a *classe derivada* podem possuir seus próprios construtores.

A *classe derivada* **não herda** o construtor da *classe base*, mas pode invocá-lo.

Ao criar uma instância da *classe derivada* o construtor da *classe base* sem parâmetros será *invocado primeiro* e **depois** será invocado o construtor da *classe derivada*.

A palavra-chave `base` é usada para acessar membros da *classe base* de dentro de uma classe derivada:

- Ela é usada para *especificar qual construtor da classe base* deve ser chamado ao criar instância da *classe derivada*.

### Herança: A classe Object

Toda a classe é derivada da classe **Object**, e *a classe **Obejct** não deriva de nenhuma classe*. Ela é a classe **Base** de todas as classes.

A classe **Object** dá suporte a todas as classes na hierarquia de classes do .NET e fornece serviços de baixo nível para as classes derivadas.

Os métodos definidos na classe **Object** estão disponíveis em todos os objetos do sistema e as classes derivadas podem substituir alguns desses métodos:

- `Equals`: suporta comparações entre objetos.

- `GetHashCode`: gera um número *hash* para o objeto.

- `ToString`: retorna a representação do objeto como uma *string*.

- `GetType`: retorna informação sobre o tipo.

> No C#, uma classe pode herdar apenas de uma classe. A herança tem que ser de classe para classe. A classe não pode herdar do tipo struct, por exemplo.

### Herança: O modificador new

Se um membro de uma *classe derivada* tiver o *mesmo nome* do membro de uma *classe base*, o compilador vai emitir o aviso:

> *>>> 'member1' hides inherited member 'member2'. Use the new keyword if hiding was intended.*

Este aviso indica que o membro da *classe derivada **oculta** o membro da classe base*.

Quando o método *na classe derivada oculta* um membro da *classe base*, este membro *substitui (override)* o membro da *classe base*.

Se você realmente deseja ocultar um membro da *classe base*, pode usar o modificador **new** para o membro na *subclasse*.

```csharp
class Pessoa
{
    public string? Nome { get; set; }
    public string Apresentar() => $"Nome: {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }

    // 'new' indica que você realmente deseja substituir o método
    public new string Apresentar() => $"{Nome}, do curso de {Curso}";
}
```

### Herança: virtual e override

Se você quiser que um membro da *subclasse* substitua um membro com o *mesmo nome* na *classe base*, deve fazer o seguinte:

1. Usar o modificador `virtual` na declaração do membro da *classe base*:
   
   ```csharp
   class Pessoa
   {
       public string? Nome { get; set; }
       public virtual string Apresentar() => $"Nome: {Nome}";
   }
   ```

2. Usar o modificador `override` na declaração do membro na *classe derivada*:
   
   ```csharp
   class Aluno : Pessoa
   {
       public string? Curso { get; set; }
       public override string Apresentar() => $"{Nome}, do curso de {Curso}";
   }
   ```

### Herança: O modificador sealed

Quando aplicado a uma classe, o modificador `sealed` impede que outras classes herdem dela.

```csharp
sealed class ClasseBase
{
    // código
}

class Subclasse : ClasseBase // error
{
    // código
}
```

Podemos usar o modificador `sealed` em um *método ou propriedade* que substitui um método ou propriedade virtual em uma classe base.

Com isso, você permite que classes sejam derivadas de sua classe e evita que outros desenvolvedores que estejam usando suas classes substituam métodos e propriedades virtuais específicos.

```csharp
class ClasseBase
{
    protected virtual void Metodo()
    {
        // código
    }
}

class Classe1 : ClasseBase
{
    // impedindo que este método continue sendo herdado
    sealed protected override void Metodo() // ok, it's work
    {
        // código
    }
}

class Classe2 : Classe1
{
    protected override void Metodo() // error
    {
        // código
    }
}
```

### Herança: Downcasting e Upcasting

As classes a seguir servirão de exemplo para as operações de **Upcasting** e **Downcasting**:

```csharp
class Shape // classe base
{
    protected int xPos, yPos;

    public Shape() { }

    public Shape(int xPos, int yPos)
    {
        this.xPos = xPos;
        this.yPos = yPos;
    }

    public virtual void Draw()
    {
        Console.WriteLine($"{this} on position: ({xPos}, {yPos})");
    }
}

class Circle : Shape // classe derivada
{
    public Circle() { }

    public Circle(int x, int y) : base (x, y) { }

    public override void Draw()
    {
        base.Draw();
    }

    public void DrawCircle()
    {
        Console.WriteLine("Draw Circle");
    }
}
```

#### Upcasting

A operação **upcasting** converte um objeto de um tipo especializado (*classe derivada*) para um tipo mais geral (*classe base*).

Podemos entender o **upcasting** como a atribuição de um objeto de uma *classe derivada* para uma *referência* de uma *classe base*.

Esta operação é **implícita**, e não é preciso ser feita de forma **explícita**, sendo sempre possível de ser realizada.

```csharp
// UPCASTING: conversão da classe derivada para a classe base

// exemplo 1
Shape circle = new Circle(207, 75); // é um objeto do tipo 'Shape'
circle.Draw();

// exemplo 2
Circle circle = new(34, 89);
Shape shape = circle; // a conversão aqui é implícita

Console.WriteLine(shape == circle); // True
```

#### Downcasting

A operação de **downcasting** converte um objeto de um tipo geral (*classe base*) para um tipo mais especializado (*classe derivada*).

Podemos entender o **downcasting** como a atribuição de um objeto da classe base para um objeto da classe derivada.

A operação de **downcasting** deve ser feita de *forma explícita* pois pode falhar e lançar uma exceção, ou seja, é uma operação que nem sempre é possível de ser realizada.

```csharp
// DOWNCASTING: conversão da classe base para a classe derivada

Shape shape = new Circle(34, 89); // é um objeto do tipo 'Shape'
Circle circle = (Circle)shape; // a conversão aqui é explícita

Console.WriteLine(shape == circle); // True
```

## Operador Is e As

### Operador As

O operador `as` é usado para *realizar a conversão* entre tipos de referência ou *tipos anuláveis compatíveis*.

Este operador retorna o objeto quando ele é compatível com o tipo de dado e retorna `null` se a *conversão não for possível* ao invés de gerar uma exceção.

Ao realizar uma operação de **downcasting** ele avalia o resultado para `null` ao invés de *lançar uma exceção* caso a operação não seja possível.

O operador `as` é um operador de *conversão de tipos (referência e anuláveis)*.

```csharp
// OPERADOR AS

object a = "Mozart";

string? b = a as string; // não lança exceção

Console.WriteLine(b != null ? b : "null");

Console.ReadKey();
```

O operador `as` pode ser usado para realizar a operação **downcasting**:

```csharp
Shape shape = new Circle(34, 89);
Circle circle = shape as Circle; // usando o operador 'as'
```

- caso não seja possível converter, a variável `circle` apenas recebe null.

### Operador Is

O operador `is` é usado para verificar se o tipo de um objeto é compatível com o tipo especificado ou não.

Retorna `true` se o objeto especificado for do mesmo tipo, caso contrário, retorna `false`. Retorna `false` também para objetos nulos.

Podemos usar o operador `is` para verificar se uma conversão entre tipos será bem sucedida ou não.

O operador `is` é um operador do *tipo booleano de comparação de tipos*.

```csharp
object a = "Mozart";
if (a is string)
    Console.WriteLine("A conversão é possível!");
```

O operador `is` pode ser usado para realizar a operação **downcasting**:

```csharp
Shape shape = new Circle(34, 89);
if (shape is Circle) // é possível converter para o tipo 'Circle'?
    Circle circle = shape as Circle; // então converta
```

### A diferença entre os operadores Is e As

O operador `is` é usado para **verificar** se o tipo de um objeto é compatível com o tipo fornecido ou não, enquanto o operador `as` é usado para **realizar a conversão** entre *tipos de referência compatíveis ou tipos anuláveis*.

- O operador `is` é do tipo *booleano*, enquanto o operador `as` não é do tipo booleano.

- O operador `is` retorna `true` ou `false` ao fazer a comparação entre os tipos fornecidos, enquanto o operador `as` retorna `null` se a conversão não for possível.

- O operador `is` é usado para *conversões de referência, boxing e unboxing*, enquanto o operador `as` é usado apenas para *conversões anuláveis, de referência e boxing*.
