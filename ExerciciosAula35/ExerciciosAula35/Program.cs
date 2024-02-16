using System.Globalization;

Exercicio7();

static void Exercicio1()
{
    int valor = int.Parse(Console.ReadLine());
    for (int i = 0; i <= valor; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}

static void Exercicio2()
{
    int quantidade = int.Parse(Console.ReadLine());
    int qtdIn = 0, qtdOut = 0;
    for (int i = 0; i < quantidade; i++)
    {
        int valor = int.Parse(Console.ReadLine());
        if (valor >= 10 && valor <= 20)
        {
            qtdIn++;
        }
        else
        {
            qtdOut++;
        }
    }
    Console.WriteLine(qtdIn + " in");
    Console.WriteLine(qtdOut + " out");
}

static void Exercicio3()
{
    int N = int.Parse(Console.ReadLine());
    for (int i = 0; i < N; i++)
    {
        string[] valores = Console.ReadLine().Split(' ');
        double v1 = double.Parse(valores[0]);
        double v2 = double.Parse(valores[1]);
        double v3 = double.Parse(valores[2]);
        double media = (2 * v1 + 3 * v2 + 5 * v3) / 10;
        Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
    }
}

static void Exercicio4()
{
    int N = int.Parse(Console.ReadLine());
    for (int i = 0; i < N; i++)
    {
        string[] valores = Console.ReadLine().Split(' ');
        double v1 = double.Parse(valores[0]);
        double v2 = double.Parse(valores[1]);
        if (v2 == 0)
        {
            Console.WriteLine("Divisão impossível");
        }
        else
        {
            Console.WriteLine((v1 / v2).ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}

static void Exercicio5()
{
    int N = int.Parse(Console.ReadLine());
    int fatorial = 1;
    for (int i = 1; i <= N; i++)
    {
        fatorial = fatorial * i;
    }
    Console.WriteLine(fatorial);
}

static void Exercicio6()
{
    int N = int.Parse(Console.ReadLine());
    for (int i = 1; i <= N; i++)
    {
        int result = N % i;
        if (result == 0)
        {
            Console.WriteLine(i);
        }
    }
}

static void Exercicio7()
{
    int N = int.Parse(Console.ReadLine());
    for (int i = 1; i <= N; i++)
    {
        int quadrado = i * i;
        int cubo = i * i * i;
        Console.WriteLine($"{i} {quadrado} {cubo}");
    }
}