using System.Text;
using ExemploExplorando.Models;

try
{
    string[] linhas = File.ReadAllLines("aArquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} catch(Exception ex)
{
    string error_msg = ($"Ocorreu uma exceção genérica. {ex.Message}");

    string path = @"c:\\Projetos\\dio-csharp\\ExemploExplorando\\Arquivos\\log_" + DateTime.Now.ToString().Replace("/", "-").Replace(" ", "_").Replace(":", "-") + ".txt";

    try
    {
        using (FileStream fs = File.Create(path))
        {
            byte[] info = new UTF8Encoding(true).GetBytes(error_msg);
            fs.Write(info, 0, info.Length);
        }
    }catch(Exception e){
        Console.WriteLine(e.Message);
    }
    
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


