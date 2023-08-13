# Estruturas de Controle

## Estruturas Condicionais

### Instrução if

Seleciona *um bloco ou uma instrução* para execução com base no valor de uma expressão booleana (true or false).

Usamos a **instrução** `if` para especificar um *bloco de código* que deverá ser executado, se uma condição for verdadeira.

```csharp
bool condition = true;

if (condition)
{
    // código que é executado se o resultado da condição for true
}
```

Se o bloco possuir apenas uma linha, o uso das chaves `{}` é opcional:

```csharp
if (condition)
    // código que é executado se o resultado da condição for true
```

### Instrução if-else

A instrução **if-else** é composta por dois blocos de instrução: o bloco de instrução `if` e o bloco de instrução `else`.

```csharp
bool condition = false;

if (condition)
    // código que é executado se o resultado da condição for true
else
    // código que é executado se o resultado da condição for false
```

### Instrução else-if

Podemos usar a instrução `else if` após a instrução `if` para avaliar **mais de uma condição**. As instruções `else if` somente serão executadas se a condição na instrução `if` for `false`. Assim, ou a instrução `if` será executada ou uma das instruções **else if** será executada, *mas não ambas*.

A instrução `if` pode ter várias cláusulas `else if` onde cada cláusula tem uma **condição**. A instrução `else if` verifica cada **condição** de *cima para baixo sequencialmente* e, se uma condição for verdadeira, o bloco correspondente é executado e as demais condições *não serão avaliadas*.

Se nenhuma condição for verdadeira, o bloco da cláusula **else** é executado (a cláusula `else` é opcional).

```csharp
if (condition1)
{
    // código que é executado se o resultado da condição for true
}
else if (condition2)
{
    // código que é executado se o resultado da condição for true
}
else if (condition3)
{
    // código que é executado se o resultado da condição for true
}
else
{
    // código que é executado se o resultado de todas as condições anteriores for false
}
```

### Instrução Switch

O bloco **switch-case** é uma estrutura de condição que define o código a ser executado com base em uma *comparação de valores*.

A instrução **switch** pode ser usada para substituir as instruções **if**/**else-if**.

Diferente das instruções **if else-if**, a instrução **switch** *não avalia uma expressão booleana* que retorna `true` ou `false`, mas avalia *o valor da variável ou expressão* da instrução **switch**.

```csharp
switch (variavel/expression)
{
    case valor1:
        // código
        break;
    case valor2
        // código
        break;
    default:
        // código
        break;
}
```

#### Executando da mesma condição

Podemos definir o mesmo bloco de código que é executada em múltiplas condições.

```csharp
switch(valor)
{
    case valor1:
    case valor2:
    case valor3: 
        // código
    case valor4:
    case valor5:
        // código
    default:
        // código
}
```

#### Instruções Switch aninhadas

Você pode usar **switch** dentro de **switch**.

```csharp
switch(expressao1)
{
    case 1:
        // código
    case 2:
        // código
        switch(expressao2)
        {
            case 1:
                // código
            case 2:
                // código
        }
        break;
    default:
        // código
}
```

## Estruturas de Repetição (*loops*)

As estruturas de repetição são usadas para repetir instruções ou blocos de código.

A decisão de repetir o código é baseada na avaliação de uma expressão lógica. Se a expressão for verdadeira, o código é executado.

Uma estrutura de repetição permite especificar que uma ação seja repetida várias vezes, dependendo do valor de uma condição.

### Loop: Goto e Label

A instrução `goto` pode ser usada para *transferir o controle de uma parte para outra parte* do programa com ajuda de um identificador chamado de **label**.

```csharp
int i = 1;

repetir: // pode ser qualquer label, exceto palavras chaves
    Console.WriteLine(i);
    i++;
if (i <= 10)
    goto repetir;
```

### Loop: While

A instrução `while` executa uma instrução ou um bloco de instrução enquanto uma expressão booleana especificada for avaliada como `true`.

Como essa expressão é avaliada antes de cada execução do loop, um loop `while` pode *executar zero ou mais vezes*.

```csharp
var i = 1;

while(i <= 10)
{
    Console.WriteLine(i);
    i++;
}
```

#### While: Instrução break

A instrução `break` pode ser usada para encerrar uma instrução `switch` ou um loop (`while`, `for`, `if`, etc.) em uma determinada condição.

```csharp
while(true)
{
    Console.Write("Digite um número (999 para sair): ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 999)
        break;
    if (num % 2 == 0)
        Console.WriteLine($"O número {num} é par");
    else
        Console.WriteLine($"O número {num} é impar");
}
```

### Loop: do-while

O loop `do-while` é uma variante do loop `while` e possui o mesmo comportamento.

A diferença é que o loop `do-while` *executa o bloco de código pelo menos uma vez*, antes de avaliar a condição, e a seguir repete o loop enquanto a condição for `true`.

```csharp
int i = 1;
do {
    Console.WriteLine(i);
    i++;
}
while (i <= 10);
```

A execução será interrompida quando a condição booleana for avaliada como `false`.
