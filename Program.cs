using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Fernando";
p1.Sobrenome = "Motta";

Pessoa p2 = new Pessoa();
p2.Nome = "Juliana";
p2.Sobrenome = "Michelsen";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();


