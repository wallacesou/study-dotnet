// TIPOS DE DADOS POR REFERÊNCIA: STRING, OBJECT E DYNAMIC

// String: comum para textos
string frase = "Curso C# Essencial";
frase = "Criando uma nova frase";
// OBS: como strings são imutáveis, aqui foi criada uma nova alocação de memória para esse novo valor

Console.WriteLine(frase);

// Object: suporta todos os tipos de dados
object nome1 = "Ana";
object idade1 = 25;
object altura1 = 1.60;
object genero1 = 'F';
object ativo1 = true;

Console.WriteLine($"{nome1}, {idade1} anos, {altura1} de altura, genero: ({genero1}), ativo: {ativo1}");

// Dynamic: permite usar recursos avançados da linguagem
dynamic nome2 = "Teo";
dynamic idade2 = 21;
dynamic altura2 = 1.85;
dynamic genero2 = 'M';
dynamic ativo2 = false;

Console.WriteLine($"{nome2}, {idade2} anos, {altura2} de altura, genero: ({genero2}), ativo: {ativo2}");

Console.ReadKey();
