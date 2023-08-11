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

