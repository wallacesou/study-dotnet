// INSTRUÇÃO IF ELSE-IF

Console.Write("Digite a nota do aluno: ");
var nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
    Console.WriteLine("ALUNO REPROVADO!");
else if (nota >= 5 && nota < 7.5)
    Console.WriteLine("ALUNO EM RECUPERAÇÃO!");
else if (nota >= 7.5 && nota <= 9.5)
    Console.WriteLine("ALUNO APROVADO!");
else
    Console.WriteLine("ALUNO APROVADO COM NOTA MÁXIMA");

Console.ReadKey();
