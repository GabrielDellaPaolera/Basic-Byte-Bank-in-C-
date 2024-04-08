using bytebank.Funcionarios;
using bytebank.Utilitario;

Funcionario pedro = new Funcionario();

pedro.Nome = "Pedro Janini";
pedro.Cpf = "420246913";
pedro.Salario = 1000.20;

Console.WriteLine(pedro.GetNotification());


Diretor paula = new Diretor();
paula.Nome = "paula Tejano";
paula.Cpf = "42420402220";
paula.Salario = 500.40;

Console.WriteLine(paula.GetNotification());


GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);

Console.WriteLine("Total:" +  gerenciador.TotalDeBonificacao);

