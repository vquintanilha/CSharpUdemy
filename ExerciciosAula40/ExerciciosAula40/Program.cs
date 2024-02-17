using ExerciciosAula40;
using System.Globalization;

Exercicio2();

static void Exercicio1()
{
    Pessoa p1, p2;
    p1 = new Pessoa();
    p2 = new Pessoa();

    Console.WriteLine("Dados da primeira pessoa:");
    Console.Write("Nome: ");
    p1.Nome = Console.ReadLine();
    Console.Write("Idade: ");
    p1.Idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Dados da segunda pessoa:");
    Console.Write("Nome: ");
    p2.Nome = Console.ReadLine();
    Console.Write("Idade: ");
    p2.Idade = int.Parse(Console.ReadLine());

    if (p1.Idade > p2.Idade)
    {
        Console.WriteLine("Pessoa mais velha: " + p1.Nome);
    }
    else
    {
        Console.WriteLine("Pessoa mais velha: " + p2.Nome);
    }
}

static void Exercicio2()
{
    Funcionario f1, f2;
    f1 = new Funcionario();
    f2 = new Funcionario();

    Console.WriteLine("Dados do primeiro funcionario:");
    Console.Write("Nome: ");
    f1.Nome = Console.ReadLine();
    Console.Write("Salário: ");
    f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Dados do segunda funcionario:");
    Console.Write("Nome: ");
    f2.Nome = Console.ReadLine();
    Console.Write("Salário: ");
    f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double media = (f1.Salario + f2.Salario) / 2;
    Console.WriteLine("Salario médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
}