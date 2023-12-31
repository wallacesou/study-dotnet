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

## Métodos: Retorno

Os métodos podem retornar um valor para o chamador.

Se o tipo de retorno (o tipo listado antes do nome do método) não for `void`, o método poderá retornar o valor usando a palavra-chave `return`.

Uma instrução com a palavra-chave `return` seguida por uma variável, constante ou expressão que corresponde ao tipo de retorno retornará esse valor para o chamador do método.

```csharp
public int Somar(int n1, n2)
{
    return n1 + n2;
}
```

## Métodos: Sobrecarga

**Assinatura de um método** é uma identificação exclusiva de um método para o compilador C#.

A **assinatura de um método** é formada assim:

- Nome do método

- O número de parâmetros

- O tipo dos parâmetros

- A ordem dos parâmetros

O tipo de retorno *não faz parte* da assinatura do método.

Não é possível ter dois métodos com a mesma assinatura.

```csharp
class Calculadora
{
    public int Somar(int n1, int n2) // a assinatura deste método é única
    {
        return n1 + n2;
    }
    public int Somar(int n1, int n2, int n3) // diferencia pela quantidade de parâmetros
    {
        return n1 + n2 + n3;
    }
    public double Somar(int n1, double n2) // diferencia pelo tipos dos parâmetros
    {
        return n1 + n2;
    }
    public double Somar(double n1, int n2) // diferencia pela ordem dos tipos
    {
        return n1 + n2;
    }
}
```

## Passagem de argumentos por valor e referência

No C#, existe duas maneiras de passar argumentos para parâmetros de métodos:

### Passagem de argumentos por valor (padrão)

- Uma *cópia do valor do argumento* é feita e passada para o parâmetro do método chamado

- As alterações na cópia não afetam o valor da variável original no chamador

```csharp
int x = 20; // variável 'x' inicializada com o valor '20'
Console.WriteLine($"Valor de x: {x}");

Calculo calc = new Calculo(); // objeto criado

Console.WriteLine("Valor de y: " + calc.Dobrar(x)); // é passado uma cópia como argumento para 'y'

Console.WriteLine($"Valor de x: {x}"); // a variável 'x' continua com o valor '20'

class Calculo
{
    public int Dobrar(int y)
    {
        return y *= 2;
    }
}
```

### Passagem de argumento por referência (ref e out)

- Passa a *referência ao mesmo local da memória* dos argumentos para os parâmetros; nenhuma cópia é passada.

- O chamador dá ao método a capacidade de *acessar e modificar a variável original do chamador (passa o acesso à variável para o método)*

- Para fazer isso usamos as palavras chave `ref` e `out`

#### Com ref:

```csharp
int x = 20; // variável 'x' inicializada com o valor '20'
Console.WriteLine($"Valor de x: {x}");

Calculo calc = new Calculo(); // objeto criado

Console.WriteLine("Valor de y: " + calc.Dobrar(ref x)); // é passado a cópia da referência do argumento 'x' para 'y'

Console.WriteLine($"Valor de x: {x}"); // a variável 'x' agora é '40'

class Calculo
{
    public int Dobrar(ref int y)
    {
        return y *= 2; // aqui a instrução trabalha na mesma área da memória da variável 'x'
    }
}
```

#### Com out:

- A palavra-chave `out` faz com que os argumentos sejam passados **por referência**

- Devemos usar `out` na *declaração do método* e na *invocação do método*

- A principal diferença é que `out` transfere dados *para fora do método* e não para dentro dele

No entanto o método chamado *deve atribuir um valor ao parâmetro* definido com a `out` antes que o método seja retornado.

```csharp
Console.Write("Digite o RAIO do círculo: ");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new Circulo();
/* 
double area = circulo.Area(raio);
double perimetro = circulo.Perimetro(raio);
    // Antes eu precisava criar essas duas variáveis //
*/

double perimetro = circulo.AreaPerimetro(raio, out double area); // 'out' torna possível que a variável 'area' seja criada com o valor recebido do método a partir desse ponto

Console.WriteLine($"Area: {area}"); // agora eu posso usar a variável 'area'
Console.WriteLine($"Perímetro: {perimetro}");

class Circulo
{
    public double Area(double raio)
    {
        return Math.PI * Math.Pow(raio, 2);
    }
    public double Perimetro(double raio)
    {
        return 2 * Math.PI * raio;
    }
    public double AreaPerimetro(double raio, out double areaCalculada)
    {
        areaCalculada = Math.PI * Math.Pow(raio, 2);
        return 2 * Math.PI * raio;
    }
}
```

## Diferença de argumento e parâmetro

Um **parâmetro** representa *um valor que o método espera receber* quando for chamado; quando criamos o método, definimos seus parâmetros.

Um **argumento** representa *o valor que você passa* para um *parâmetro de método* quando você chama o método.

```csharp
...
var soma = calc.Somar(10, 10); // argumentos

public int Somar(int n1, int n2) // parâmetros
{
    return n1+n2;
}
```

## Argumentos Nomeados

Permitem que você especifique *um argumento* para *um parâmetro* correspondendo *o argumento com seu nome* em vez de *com sua posição* na lista de parâmetros.

Liberam o programador da necessidade de combinar *a ordem dos argumentos* com *a ordem dos parâmetros* nas listas de parâmetros de métodos chamados.

O *argumento* para cada *parâmetro* pode ser especificado pelo *nome do parâmetro*.

```csharp
Email email = new Email();
email.Enviar(titulo: "Urgente", assunto: "Próxima reunião com os devs dia 15/05", destino: "email@email.com");
/* os argumentos acima não precisam
 * estar na mesma ordem dos
 * parâmetros declarados nos métodos
 * se usarmos argumentos nomeados
 */

Console.ReadKey();

class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Para: {destino, 24}");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Assunto: {titulo.ToUpper()}");
        Console.WriteLine("------------------------------");
        Console.WriteLine(assunto);
    }
}
```

## Parâmetros Opcionais

Permitem definir *parâmetros* em uma assinatura de método que o chamador do método *pode omitir*.

Cada *parâmetro opcional deve ter* um *valor padrão* como parte de sua definição.

Se *nenhum argumento for enviado* para esse parâmetro, o *valor padrão deverá ser usado.*

Os parâmetros opcionais devem ser definidos *no final da lista de parâmetros*, depois de todos os parâmetros obrigatórios (se existirem).

```csharp
Email email = new Email();
email.Enviar("dev1@email.com");
email.Enviar("dev2@email.com", assunto: "Alguns projetos estão pendentes...");
/* os argumentos acima usam
 * os valores opcionais dos parâmetros
 * caso os argumentos não sejam informados.
 * Podemos até omitir um argumento
 * no meio da lista de parâmetros se
 * usarmos arguementos nomeados.
 */

Console.ReadKey();

class Email
{
    public void Enviar(string destino, string titulo = "Relatório semanal", string assunto = "Segue em anexo o resumo dos seus projetos...")
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Para: {destino,24}");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Assunto: {titulo.ToUpper()}");
        Console.WriteLine("------------------------------");
        Console.WriteLine(assunto);
    }
}
```

## Métodos Estáticos

Um método estático é definido usando *modificador* `static` na declaração do método.

O *modificador* `static` pode ser usado em *classes*, *interfaces*, *structs*, *campos*, *métodos*, *propriedades*, *operadores*, *eventos* e *construtores*.

```csharp
Calculadora.Somar(9, 2);
Calculadora.Subtrair(8, 5);
Calculadora.Multiplicar(5, 3);
Calculadora.Dividir(10, 2);

class Calculadora
{
    // métodos estáticos
    public static int Somar(int n1, int n2) => n1 + n2;
    public static int Subtrair(int n1, int n2) => n1 - n2;
    public static double Multiplicar(double n1, double n2) => n1 * n2;
    public static double Dividir(double n1, double n2) => n1 / n2;
}
```

Os métodos estáticos são métodos que *não dependem de um objeto*, ou seja, não dependem da criação de uma instância da classe para serem acessados.

Os métodos estáticos pertecem **à classe** e não ao **objeto**.

Como o método estático *não possui ligação com um objeto*, ele não pode usar variáveis de instância, que são variáveis do objeto.

Exemplo: Classes **Math** e **Console**.

## Membros Estáticos

Um membro estático é definido usando o *modificador* `static` na declaração do *membro*.

```csharp
ClasseA objetoA = new ClasseA();

objetoA.x = 1; // atribuindo valor à instância da classe
A.y = 2; // atribuindo valor diretamente ao membro da classe

class A
{
    public int x;
    public static int y;
}
```

## Construtor Estático

Um construtor estático é usado para *inicializar quaisquer membros estáticos* ou para executar uma ação específica que precisa ser executada *apenas uma vez*.

Ele é chamado automaticamente *antes que a primeira instância seja criada* ou que quaisquer membros estáticos sejam referenciados.

> Membros estáticos são membros que usam o modificador `static` e que estão associados com **a classe** e não com uma *instância particular da classe*, ou seja, para acessar membros estáticos não precisamos criar uma instância da classe.

### Construtor Estático: Propriedades

- Um construtor *não usa* modificadores de acesso nem tem parâmetros

- Uma **classe** ou **struct** só pode ter *um único construtor estático*

- Um construtor estático *não pode* ser chamado diretamente

- O usuário *não tem controle* sobre quando o construtor estático é executado no programa

- Se você não fornecer um construtor estático para inicializar *campos estáticos*, todos os campos estáticos serão inicializados com seu valor padrão

- Se um construtor estático gerar uma exceção, o *runtime* não o invocará uma segunda vez, e o membro estático permanecerá não inicializado durante o tempo de vida do aplicativo

```csharp
class MinhaClasse
{
    // só podemos ter um construtor estático
    static MinhaClasse() // sem modificadores de acesso e sem parâmetros
    {
        // código
    }
}
```

> Podemos ter outros construtores na **classe/struct** além do construtor estático

## Propriedades

Uma propriedade é um *membro* da classe que fornece um mecanismo para ler, gravar ou calcular o valor de um *campo privado*.

As propriedades podem ser usadas como se fossem *membros de dados públicos*, mas possuem métodos especiais chamados *acessadores*.

Esse recurso permite que os dados sejam acessados com facilidade e ainda ajuda a promover a segurança e a flexibilidade dos métodos.

> As propriedades permitem que uma classe exponha uma maneira pública de obter e definir valores, enquanto *oculta o código de implementação ou verificação*.

```csharp
public class Pessoa
{
    private string nome; // campo
    public string Nome { get; set; } // propriedade, acessadores: get, set
}
```

### Propriedades: Somente Leitura e Somente Gravação

- **Propriedades leitura e gravação:**

```csharp
public string Nome { get; set; }
```

- **Somente leitura:**

```csharp
public string Nome { get; } // podemos apenas ler o valor
```

- **Somente gravação:**

```csharp
public string Idade { set; } // podemos apenas atribuir o valor
```

### Propriedades: Vantagens

Permitem um melhorar controle dos membros da classe (*reduz a possibilidade de o programador bagunçar o código*).

São mais flexíveis pois o programador pode alterar uma parte do código sem afetar outras partes.

Garantem uma maior segurança dos dados permitindo controlar o acesso.

> Um dos pilares da programação orientada a objetos é justamente o *encapsulamento* da classe, e isso significa que o trabalho interno de uma classe deve ser escondido do mundo exterior. O uso de propriedades respeita esse pilar.

## Structs

**Struct** é um tipo de dado definido pelo usuário que é composta por outros tipos de dados e funcionalidades (*semelhante a uma classe*).

**Struct** pode conter campos, métodos, constantes, construtores, propriedades, indexadores, operadores e mesmo outros tipos de estruturas.

A principal diferença entre **classe** e **struct** é que **structs** são **tipos de valor** e não de referência (*membros e instâncias de uma struct são criadas na memória Stack e contém seus dados*).

> Uma struct é uma alternativa mais leve para uma classe.

```csharp
struct Pessoa
{
    public string Nome;
    public int Idade;

    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}");
    }
}
```

### Quando usar Structs?

**CONSIDERE** usar o tipo `struct` em vez de uma classe se as instâncias do tipo forem *pequenas e normalmente de curta duração* ou se forem comumente incorporadas em outros tipos de objetos.

**EVITE** definir um tipo `struct`, a menos que o tipo tenha todas as características a seguir:

1. Representa logicamente um único valor, semelhante aos tipos primitivos (*int, double*).

2. Tem um tamanho de *instância inferior a 16 bytes*.

3. É imutável.

4. Não precisará *sofrer conversão para tipo de referência (boxing)* com frequência

## Enum

**Enum** ou *Enumeration* é um *tipo de dado especial* definido pelo usuário.

Um **enum** é uma "classe" especial que é definida por um *conjunto de constantes nomeados* do *tipo numérico*.

O uso do tipo **enum** ajuda a tornar o programa mais fácil de entender e manter.

```csharp
Console.WriteLine(DiasDaSemana.Sexta); // Sexta

// Para exibir o valor do membro do enumerador
Console.WriteLine((int)DiasDaSemana.Sexta); // 4

enum DiasDaSemana
{
    Segunda,
    Terça,
    Quarta,
    Quinta,
    Sexta,
    Sábado,
    Domingo
}
```

Podemos definir valores dentro de **enums**:

```csharp
enum CodigoDeErro
{
    Nenhum = 0,
    Desconhecido = 1,
    ConexaoFalhou = 100,
    DadosInvalidos = 200
}
```

Por padrão, os valores associados aos membros de um **enum** são do tipo `int`.

O primeiro membro **de um enum** tem o valor 0 e o valor de cada membro seguinte é incrementada de 1 (*quando nenhum valor for atribuído*).

```csharp
enum Categorias
{
    Moda,          // 0
    Automotivo,    // 1
    Artes,         // 2
    Bebidas,       // 3
    Livros,        // 4
    Brinquedos     // 5
}
```

Um **enum** é um **tipo de valor** que é alocado na memória **Stack**.

Podemos atribuir valores diferentes aos membros de uma enum.

Uma alteração no valor padrão de um membro **enum** atribuída *automaticamente* valores *incrementais* aos outros membros sequencialmente.

```csharp
enum Categorias
{
    Moda,          // 0
    Automotivo,    // 1
    Artes = 5,     // 5
    Bebidas,       // 6
    Livros,        // 7
    Brinquedos     // 8
}
```

Podemos atribuir valores diferentes a cada membro de uma enum:

```csharp
enum Categorias
{
    Moda = 1,
    Automotivo = 5,
    Artes = 6,
    Bebidas = 10,
    Livros = 12,
    Brinquedos = 15
}
```

Um **enum** pode ser de qualquer tipo de dado numérico como: `byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long `ou `ulong`.

Para definir o tipo basta informar o nome do tipo após o nome do enum:

```csharp
Console.WriteLine(DiasDaSemana.Sexta); // Sexta

// Para exibir o valor do membro do enumerador
Console.WriteLine((byte)DiasDaSemana.Sexta); // 4

enum DiasDaSemana : byte
{
    Segunda,
    Terça,
    Quarta,
    Quinta,
    Sexta,
    Sábado,
    Domingo
}
```

## Modificadores de Acesso

Os modificadores de acesso são palavras-chave usadas para especificar o acesso de **um membro** *(membro, propriedade, método, etc.)* ou de **um tipo** *(classe, struct, etc.)*

Temos os seguintes modificadores de acesso:

`public` - O *tipo ou membro* pode ser acessado por qualquer outro código no mesmo *assembly* ou em outro *assembly* que faz referência a ele.

`private` - O *tipo ou membro* pode ser acessado somente pelo código na *mesma classe ou struct*.

`internal` - O *tipo ou membro* pode ser acessado por qualquer código no mesmo assembly, mas não de outro *assembly*.

`protected` - O *tipo ou membro* pode ser acessado por qualquer código no *assembly* no qual ele é declarado ou de uma *classe derivada* em outro *assembly*.

`file` - *(incluído a partir do C# 10)* Restringe o escopo e a visibilidade de um *tipo* de nível superior ao arquivo no qual ele for declarado.

| Modificador de Acesso ....................................... | *Subclasses* no Assembly | Classes no Assembly | Subclasses fora do Assembly | Classes fora do Assembly |
| ------------------------------------------------------------- |:------------------------:|:-------------------:|:---------------------------:|:------------------------:|
| `public`                                                      | ×                        | ×                   | ×                           | ×                        |
| `protected internal`                                          | ×                        | ×                   | ×                           |                          |
| `internal`                                                    | ×                        | ×                   |                             |                          |
| `protected`                                                   | ×                        | ×                   | ×                           |                          |
| `private protected`                                           | ×                        | ×                   |                             |                          |
| `private`                                                     | ×                        |                     |                             |                          |

- **Subclasses** - É a classe derivada, a classe filha que foi herdada da classe pai

- **Assembly** - É o arquivo **.exe** ou **.dll** gerado pela aplicação .NET em cada projeto da solução

> Uma boa prática é limitar a visibilidade de seus tipos e/ou membros restringindo-os apenas a quem realmente precisa acessar o *tipo ou membro*.

### Valor padrão dos modificadores de acesso

A menos que você especifique o modificador de acesso, esses são os valores padrões:

| Recurso                        | Valor Padrão |
| ------------------------------ | ------------ |
| Classe                         | `internal`   |
| Struct                         | `internal`   |
| Interface                      | `internal`   |
| Enum                           | `internal`   |
| Métodos, Campos e Propriedades | `private`    |

## Bloco Try-Catch

Uma exceção é um erro que ocorre em *tempo de execução* em um programa, que viola uma condição que não foi especificada para acontecer durante a operação normal.

Se o programa não fornecer o código para *tratar uma exceção*, o sistema vai parar a execução do programa com uma mensagem de erro *(lançar uma exceção)*.

Desta forma as exceções que podem ocorrer em um aplicativo devem ser tratadas para evitar *travamentos e resultados inesperados* e continuar a execução do código quando isso for possível.

Para lidar com exceções, a linguagem C# fornece suporte interno através do uso do bloco `try`-`catch`.

```csharp
try
{
    // código que pode gerar uma exceção
}
catch
{
    // caso aja uma exceção, o erro será tratado aqui
}
```

Podemos também usar o bloco `finally` (opcional) que *sempre será executado* e que é usado para liberar recursos usados no programa ou realizar outra tarefa.

```csharp
try
{
    // código que pode gerar uma exceção
}
catch
{
    // caso aja uma exceção, o erro será tratado aqui
}
finally
{
    // um código que será executado independente se houver uma exceção ou não
}
```

### Tratamento de exceção: Propriedades da exceção (Exception)

Uma **exceção** contém diversas propriedades *somente leitura* que mostram informações sobre a exceção que cousou o erro. Abaixo temos as principais:

| Propriedade      | Tipo      | Descrição                                                                                           |
| ---------------- | --------- | --------------------------------------------------------------------------------------------------- |
| `Message`        | String    | Contém uma mensagem de erro explicando a causa da exceção.                                          |
| `StackTrace`     | String    | Contém a informação que descreve a onde a exceção ocorreu.                                          |
| `InnerException` | Exception | Se a exceção foi lançada por outra exceção, esta propriedade contém a referência da antiga exceção. |

```csharp
try
{
    // código que pode gerar uma exceção
}
catch (Exception ex)
{
    // caso aja uma exceção especificada, o erro será tratado aqui
}
catch
{
    // caso aja uma exceção genérica, o erro será tratado aqui
}
finally
{
    // um código que será executado independente se houver uma exceção ou não
}
```

## Tipos Anônimos

Um tipo anônimo é um tipo (*classe*) sem nenhum nome que pode conter apenas propriedades públicas somente leitura.

Os tipos anônimos fornecem uma maneira conveniente para encapsular um conjunto de propriedades somente leitura em um único objeto sem precisar primeiro definir explicitamente um tipo.

O nome do tipo é *gerado pelo compilador* e não está disponível no código-fonte e o tipo de cada propriedade é *inferido pelo compilador*.

```csharp
var aluno = new
{
    Nome = "Maria",
    Idade = 25
};

Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Idade);
```

Um tipo anônimo pode ter uma propriedade de outro tipo anônimo:

```csharp
var aluno = new
{
    Id = 1,
    Nome = "Matt",
    Email = "matt@email.com",
    Endereco = new { Id = 1, Cidade = "Londres", Pais = "Reino Unido" }
}

Console.WriteLine($"{aluno.Nome} mora em {aluno.Endereco.Cidade}");
```

Podemos criar um array de tipos anônimos:

```csharp
var alunos = new[]
{
    new { Id = 1, Nome = "Maria", Email = "maria@email.com" },
    new { Id = 2, Nome = "Martin", Email = "martin@email.com" },
    new { Id = 3, Nome = "Julian", Email = "julian@email.com" }
}

Console.WriteLine($"Aluno: {alunos[2].Nome} | E-mail: {alunos[2].Email}");
```

### Tipos anônimo: características

São os tipos de referência que derivam diretamente de **Object**.

Contêm uma ou mais *propriedades públicas somente leitura*.

Nenhum outro tipo de membro de classe, como métodos ou eventos, é válido; e a expressão usada para inicializar uma propriedade não pode ser *nula, uma função anônima ou um tipo de ponteiro*.

Se dois ou mais tipos anônimos tiverem o *mesmo número de tipos de propriedades na mesma ordem*, o compilador irá tratá-los como o mesmo tipo eles compartilham as mesmas informações de tipo gerado pelo compilador.

Sempre será local para o método no qual for definido e não pode ser retornado do método.

Pode ser passado para outro método como parâmetro de tipo de objeto, mas isso não é recomendado.

> Tipos anônimos são normalmente usados em uma cláusula **Select** de uma expressão de consulta, geralmente com a LINQ, para retornar um subconjunto das propriedades de cada objeto na sequência de origem.

## Partial Class

Quando definimos uma classe usando a sintaxe padrão da linguagem C#, temos que definir em *um único arquivo físico* com extensão **.cs** todos os membros da classe.

Nessa abordagem não podemos declarar uma classe em dois arquivos separados em um mesmo projeto.

A partir da versão 2.0 a plataforma .NET introduziu o recurso chamado ***partial class*** que permite que uma classe venha a ser implementada em *múltiplos arquivos físicos* com extensão **.cs**.

Desta forma é possível dividir a definição de uma **classe, struct, interface ou método** em dois ou mais arquivos de origem.

Cada arquivo de origem contém a definição de *membros, tipos ou métodos* e todas as partes são combinadas quando o aplicativo for compilado.

- Podemos criar **classes, interfaces, structs e métodos** *parciais* usando o modificador `partial`:

```csharp
// nome do arquivo: "MinhaPartialClassProps.cs"
public partial class MinhaPartialClass
{
    public DateTime DataDeNascimento { get; set; }
    public string Nome { get; set; }
}
```

```csharp
// nome do arquivo: "MinhaPartialClassMetodos.cs"
public partial class MinhaPartialClass
{
    public TimeSpan CalculaIdade(DateTime dataNascimento)
    {
        return (DateTime.Now.Date - dataNascimento);
    }
    public TimeSpan DiferencaEntreDatas(DateTime data1, DateTime data2)
    {
        var diferenca = data1.Subtract(data2);
        return diferenca;
    }
}
```

O compilador vai juntar tudo em uma única classe.

### Partial Class - Regras

- Todas as definições das *classes parciais* devem estar no mesmo **assembly** e no mesmo **namespace**

- Todas as partes devem possuir a mesma acessibilidade como `public` ou `private`, etc.

- Se qualquer parte for declarada **abstract**, então toda a classe será declarada do mesmo tipo

- O modificador **partial** somente pode ser usado *antes* da palavra-chave **class**, **struct**, ou **interface**

- **Tipos** parciais **aninhados** são permitidos

- Os **atributos** se aplicam a todas as partes da classe

- As características definidas em qualquer parte estão disponíveis para todas as partes da classe

### Partial Class - Quando usar

- Ao trabalhar em projetos grandes, dividir uma classe em arquivos separados permite que vários programadores trabalharem ao mesmo tempo

- Ao trabalhar com código-fonte gerado automaticamente, o código pode ser adicionado à classe sem precisar recriar o arquivo de origem

- Ao usar geradores de código fonte (**sources generators**) para gerar funcionalidade adicional em uma classe
