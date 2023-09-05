namespace Inheritance.Models;
internal class Aluno : Pessoa // classe derivada
{
    public string? Sala { get; set; }
    public int Ano { get; set; }
    public bool Ativo { get; set; }
}
