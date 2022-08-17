using Heranca;

string nome;
string especie;

Console.WriteLine("Informe o nome do mamífero:");
nome = Console.ReadLine();

Console.WriteLine("Informe a especie:");
especie = Console.ReadLine();

Mamifero mamifero = new Mamifero(nome, especie);

mamifero.Mamar();

Console.WriteLine("Informe o nome do réptil:");
nome = Console.ReadLine();

Console.WriteLine("Informe a especie:");
especie = Console.ReadLine();

Console.WriteLine("Informe se o répitil possui veneno: (Sim/Nao) ");
string respostaveneno = Console.ReadLine();

Reptil reptil = new Reptil(nome, especie);
if (respostaveneno == "Sim")
{
	reptil.PossuiVeneno = true;
}
else
{
	reptil.PossuiVeneno = false;
}

reptil.BotarOvo();