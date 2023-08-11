// INSTRUÇÃO IF-ELSE

Console.Write("Informe a nota do aluno: ");
double nota = Convert.ToDouble(Console.ReadLine());

if (nota > 5)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno reprovado!");
}

Console.ReadKey();
