Exercicio3();

static void Exercicio1()
{
    int senha = int.Parse(Console.ReadLine());
    while (senha != 2002)
    {
        Console.WriteLine("Senha Inválida");
        senha = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Acesso Permitido");
}

static void Exercicio2()
{
    string[] valores = Console.ReadLine().Split(' ');
    int x = int.Parse(valores[0]);
    int y = int.Parse(valores[1]);
    
    while (x != 0 && y != 0)
    {
        if (x > 0 && y > 0)
        {
            Console.WriteLine("Primeiro");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Segundo");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Terceiro");
        }
        else
        {
            Console.WriteLine("Quarto");
        }

        valores = Console.ReadLine().Split(' ');
        x = int.Parse(valores[0]);
        y = int.Parse(valores[1]);
    }
}

static void Exercicio3()
{
    int codigo = int.Parse(Console.ReadLine());
    int alcoolCount = 0;
    int gasolinaCount = 0;
    int dieselCount = 0;
    while (codigo != 4)
    {
        if (codigo == 1)
        {
            alcoolCount++;
        }
        else if (codigo == 2)
        {
            gasolinaCount++;
        }
        else if (codigo == 3)
        {
            dieselCount++;
        }
        codigo = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("MUITO OBRIGADO");
    Console.WriteLine("Alcool: " + alcoolCount);
    Console.WriteLine("Gasolina: " + gasolinaCount);
    Console.WriteLine("Diesel: " + dieselCount);
}