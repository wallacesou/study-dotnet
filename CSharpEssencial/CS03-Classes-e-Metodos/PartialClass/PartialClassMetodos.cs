namespace PartialClass;
internal partial class MyPartialClass
{
    public TimeSpan CalculaIdade(DateTime dataNacimento)
    {
        return (DateTime.Now.Date - dataNacimento.Date);
    }

    public TimeSpan DiferencaEntreDatas(DateTime data1, DateTime data2)
    {
        var diferenca = data1.Subtract(data2);
        return diferenca;
    }
}
