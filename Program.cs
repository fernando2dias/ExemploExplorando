using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Fernando", sobrenome: "Motta");
Pessoa p2 = new Pessoa(nome: "Juliana", sobrenome: "Michelsen");
Pessoa p3 = new Pessoa(nome: "Neco", sobrenome: "Michelsen");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();


