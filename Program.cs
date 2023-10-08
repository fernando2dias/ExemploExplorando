using ExemploExplorando.Models;


string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach(string linha in linhas)
{
    Console.WriteLine(linha);
}















// 
// decimal valorMonetario = 34482.30M;
// Console.WriteLine($"{valorMonetario:C}");
// 
// double porcentagem = .4322;
// Console.WriteLine(porcentagem.ToString("p"));
// 
// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));
// 
















// Pessoa p1 = new Pessoa(nome: "Fernando", sobrenome: "Motta");
// Pessoa p2 = new Pessoa(nome: "Juliana", sobrenome: "Michelsen");
// Pessoa p3 = new Pessoa(nome: "Neco", sobrenome: "Michelsen");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.AdicionarAluno(p3);
// cursoDeIngles.ListarAlunos();


