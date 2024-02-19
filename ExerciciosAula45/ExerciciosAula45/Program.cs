using ExerciciosAula45;
using System.Globalization;

Exercicio03();

static void Exercicio01()
{
    Retangulo retangulo = new Retangulo();

    Console.WriteLine("Entre a largura e altura do retângulo:");
    retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("AREA = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("PERÍMETRO = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
}

static void Exercicio02(){
    Funcionario funcionario = new Funcionario();

    Console.Write("Nome: ");
    funcionario.Nome = Console.ReadLine();

    Console.Write("Salário bruto: ");
    funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Imposto: ");
    funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    Console.WriteLine();
    Console.WriteLine("Funcionário: " + funcionario);

    Console.WriteLine();
    Console.Write("Digite a porcentagem para aumentar o salário: ");
    double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    funcionario.AumentarSalario(porcentagem);

    Console.WriteLine("Dados atualizados: " + funcionario);
}

static void Exercicio03()
{
    Aluno aluno = new Aluno();
    
    Console.Write("Nome do aluno: ");
    aluno.Nome = Console.ReadLine();

    Console.WriteLine("Digite as três notas do aluno:");
    aluno.NotaTrimestre1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    aluno.NotaTrimestre2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    aluno.NotaTrimestre3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
    
    if (aluno.Aprovado())
    {
        Console.WriteLine("APROVADO");
    }
    else
    {
        Console.WriteLine("REPROVADO");
        Console.WriteLine("FALTARAM " + aluno.Diferenca().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
    }
}