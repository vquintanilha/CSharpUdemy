using System.Globalization;

Exercicio8();

static void Exercicio1()
{
    int numero = int.Parse(Console.ReadLine());
    if (numero < 0)
    {
        Console.WriteLine("NEGATIVO");
    } else
    {
        Console.WriteLine("NÃO NEGATIVO");
    }
}

static void Exercicio2()
{
    int numero = int.Parse(Console.ReadLine());
    if (numero % 2 == 0)
    {
        Console.WriteLine("PAR");
    }
    else
    {
        Console.WriteLine("IMPAR");
    }
}

static void Exercicio3()
{
    string[] vet = Console.ReadLine().Split(' ');
    int n1 = int.Parse(vet[0]);
    int n2 = int.Parse(vet[1]);

    if (n1 % n2 == 0 || n2 % n1 == 0)
    {
        Console.WriteLine("São Múltiplos");
    }
    else
    {
        Console.WriteLine("Não São Múltiplos");
    }
}

static void Exercicio4()
{
    string[] vet = Console.ReadLine().Split(' ');
    int horaInicio = int.Parse(vet[0]);
    int horaFim = int.Parse(vet[1]);
    int duracao;
    if (horaInicio < horaFim)
    {
        duracao = horaFim - horaInicio;
    }
    else
    {
        duracao = 24 - horaInicio + horaFim;
    }
    Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
}
static void Exercicio5()
{
    string[] vet = Console.ReadLine().Split(' ');
    int codigo = int.Parse(vet[0]);
    int quantidade = int.Parse(vet[1]);
    double valor = 0;
    if (codigo == 1)
    {
        valor = quantidade * 4;
    }
    else if (codigo == 2)
    {
        valor = quantidade * 4.5;
    }
    else if (codigo == 3)
    {
        valor = quantidade * 5;
    }
    else if (codigo == 4)
    {
        valor = quantidade * 2;
    }
    else if (codigo == 5)
    {
        valor = quantidade * 1.5;
    }
    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
}

static void Exercicio6()
{
    double valor = double.Parse(Console.ReadLine());
    if (valor >= 0 && valor <= 25)
    {
        Console.WriteLine("Intervalo [0, 25]");
    }
    else if (valor > 25 && valor <= 50)
    {
        Console.WriteLine("Intervalo [25, 50]");
    }
    else if (valor > 50 && valor <= 75)
    {
        Console.WriteLine("Intervalo [50, 75]");
    }
    else if (valor > 75 && valor <= 100)
    {
        Console.WriteLine("Intervalo [75, 100]");
    }
    else
    {
        Console.WriteLine("Fora de intervalo");
    }
}

static void Exercicio7()
{
    string[] vet = Console.ReadLine().Split(' ');
    double x = double.Parse(vet[0]);
    double y = double.Parse(vet[1]);
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Q1");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Q2");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Q3");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Q4");
    }
    else if (x == 0 && y == 0)
    {
        Console.WriteLine("Origem");
    }
    else if (x == 0)
    {
        Console.WriteLine("Eixo X");
    }
    else if (y == 0)
    {
        Console.WriteLine("Eixo Y");
    }
}

static void Exercicio8()
{
    double salario = double.Parse(Console.ReadLine());
    double valorImposto;
    if (salario <= 2000)
    {
        valorImposto = 0;
    }
    else if (salario > 2000 && salario <= 3000)
    {
        valorImposto = (salario - 2000) * 0.08;
    }
    else if (salario > 3000 && salario <= 4500)
    {
        valorImposto = (salario - 3000) * 0.18 + 1000 * 0.08;
    }
    else
    {
        valorImposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
    }

    if (valorImposto == 0)
    {
        Console.WriteLine("Isento");
    }
    else
    {
        Console.WriteLine("R$ " + valorImposto.ToString("F2", CultureInfo.InvariantCulture));
    }
}