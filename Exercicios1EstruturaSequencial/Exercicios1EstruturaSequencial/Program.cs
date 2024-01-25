using System.Globalization;

//Chamada do exercício que quer executar:
//Exercicio1();
//Exercicio2();
//Exercicio3();
//Exercicio4();
//Exercicio5();
Exercicio6();

static void Exercicio1()
{
    int valor1, valor2, resultado;

    valor1 = int.Parse(Console.ReadLine());
    valor2 = int.Parse(Console.ReadLine());

    resultado = valor1 + valor2;

    Console.WriteLine("SOMA = " + resultado);
}

static void Exercicio2()
{
    double valorRaioCirculo, pi, areaCirculo;

    pi = 3.14159;

    valorRaioCirculo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    areaCirculo = pi * Math.Pow(valorRaioCirculo, 2);

    Console.WriteLine(areaCirculo.ToString("F4", CultureInfo.InvariantCulture));
}

static void Exercicio3()
{
    int a, b, c, d, resultado;

    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    d = int.Parse(Console.ReadLine());

    resultado = a * b - c * d;

    Console.WriteLine("DIFERENÇA = " + resultado);
}

static void Exercicio4()
{
    int numeroFuncionario, horasTrabalhadas;
    double valorHora, salario;

    numeroFuncionario = int.Parse(Console.ReadLine());
    horasTrabalhadas = int.Parse(Console.ReadLine());
    valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    salario = horasTrabalhadas * valorHora;

    Console.WriteLine("NUMBER = " + numeroFuncionario);
    Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
}

static void Exercicio5()
{
    string[] vet1, vet2;
    int cod1, cod2, num1, num2;
    double valor1, valor2, resultado;

    vet1 = Console.ReadLine().Split(' ');
    vet2 = Console.ReadLine().Split(' ');

    cod1 = int.Parse(vet1[0]);
    num1 = int.Parse(vet1[1]);
    valor1 = double.Parse(vet1[2]);

    cod2 = int.Parse(vet2[0]);
    num2 = int.Parse(vet2[1]);
    valor2 = double.Parse(vet2[2]);

    resultado = num1 * valor1 + num2 * valor2;

    Console.WriteLine("VALOR A PAGAR: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
}

static void Exercicio6()
{
    string[] input = Console.ReadLine().Split(' ');

    double a = double.Parse(input[0]);
    double b = double.Parse(input[1]);
    double c = double.Parse(input[2]);

    double triangulo = a * c / 2;
    double areaCirculo = 3.14159 * Math.Pow(c, 2);
    double trapezio = (a + b) * c / 2;
    double quadrado = b * b;
    double retangulo = a * b;

    Console.WriteLine("TRIÂNGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("CÍRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("TRAPÉZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("RETÂNGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
}