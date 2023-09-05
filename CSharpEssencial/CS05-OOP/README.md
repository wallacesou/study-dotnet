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
