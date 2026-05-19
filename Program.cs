/*
DEsenvolva a solução aqui em Program.cs, quando terminar cole o conteúdo 
no respectivo arquivo
*/

/*1- using System.Data;

static string LerNomeAluno(string nome)
{
    Console.WriteLine("Informe o nome do aluno:");
    nome = Console.ReadLine()!;

    return nome;
}

static double LerNota(string mensagem)
{
    Console.Write(mensagem);
    double nota = double.Parse(Console.ReadLine()!);

    return nota;
}

static double CalcularMedia(double nota1, double nota2, double nota3)
{
    double media = ((nota1 + nota2 + nota3) / 3);
    return media;
}

static double VerificarSituacao(double situacao)
{

    switch (situacao)
    {
        case >= 7:
            Console.WriteLine("Aprovado");
            break;
        case >= 5:
            Console.WriteLine("Recuperação");
            break;
        default:
            Console.WriteLine("Reprovado");
            break;

    }
    return situacao;
}

static void ExibirResultado(string nome, double media, double situacao)
{
    Console.WriteLine();
    Console.WriteLine($"Aluno: {nome}");
    Console.WriteLine($"Média final: {media}");
    Console.WriteLine($"Situação: {situacao}");

}

static void ExecutarSistema()
{


    string nome = LerNomeAluno("nome");

    double nota1 = LerNota("Nota 1: ");
    double nota2 = LerNota("Nota 2: ");
    double nota3 = LerNota("Nota 3: ");

    double media = CalcularMedia(nota1, nota2, nota3);

    double situacao = VerificarSituacao(situacao);

    ExibirResultado(nome, media, situacao);
}

ExecutarSistema();*/


/* 2 
static int LerNumeroTabuada()
{
    Console.Write("Digite um número para a tabuada");
    int numero = int.Parse(Console.ReadLine()!);
    return numero;
}
static void ExibirTabuada(int numero)
{
    Console.WriteLine();
    int contador = 1;
    while (contador <= 10)
    {
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
    }
    Console.WriteLine();
}

static string LerContinuacao()
{
    Console.WriteLine("Deseja continuar outra tabuada? s/n: ");
    string resposta = Console.ReadLine()!;
    return resposta;
}
static bool DesejaContinuar(string resposta)
{
    if (resposta == "s" || resposta == "S")
    {
        return true;
    }
    else
    {
        return false;
    }
}
static void ExecutarTabuada()
{
    Console.Clear();
    int numero = LerNumeroTabuada();
    ExibirTabuada(numero);
    string resposta = LerContinuacao();
    if (DesejaContinuar(resposta))
    {
        ExecutarTabuada();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Programa encerrado.");
    }
}
ExecutarTabuada(); */



/* 3- static void ExibirMenuConversao()
{
    Console.Clear();
    Console.WriteLine("=== CONVERSOR DE TEMPERATURA ===");
    Console.WriteLine("1 - Celsius para Fahrenheit");
    Console.WriteLine("2 - Fahrenheit para Celsius");
    Console.Write("Escolha uma opção: ");
}

static string LerOpcaoConversao()
{
    return Console.ReadLine()!;
}

static double LerTemperatura()
{
    Console.Write("Digite a temperatura: ");
    return double.Parse(Console.ReadLine()!);
}

static double ConverterCelsiusParaFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}

static double ConverterFahrenheitParaCelsius(double fahrenheit)
{
    return (fahrenheit - 32) * 5 / 9;
}

static void ExibirResultadoConversao(double resultado, string unidade)
{
    Console.WriteLine();
    Console.WriteLine($"Resultado: {resultado:F2} {unidade}");
}

static void ExecutarConversor()
{
    ExibirMenuConversao();

    string opcao = LerOpcaoConversao();
    double temperatura = LerTemperatura();

    switch (opcao)
    {
        case "1":
            double resultadoFahrenheit = ConverterCelsiusParaFahrenheit(temperatura);
            ExibirResultadoConversao(resultadoFahrenheit, "°F");
            break;

        case "2":
            double resultadoCelsius = ConverterFahrenheitParaCelsius(temperatura);
            ExibirResultadoConversao(resultadoCelsius, "°C");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

ExecutarConversor(); */

/*4- 
static string Cliente()
{
    Console.Write("Digite o nome do cliente: ");
    string cliente = Console.ReadLine()!;
    return cliente;
}

static double ValorDaCompra()
{
    Console.Write("Digite o valor da compra: ");
    double valorCompra = double.Parse(Console.ReadLine()!);
    return valorCompra;
}

static double CalcularDesconto(double valorCompra)
{
    double desconto = 0;
    if (valorCompra >= 200)
    {
        desconto = valorCompra * 0.15;
    }
    else
    {
        desconto = valorCompra * 0.05;
    }
    return desconto;
}


static double ValorFinal(double valorCompra, double desconto)
{
    double valorFinal = valorCompra - desconto;
    return valorFinal;
}

static void ExibirResultado(string cliente, double valorCompra, double desconto, double valorFinal)
{
    Console.WriteLine($"Cliente: {cliente}");
    Console.WriteLine($"Valor da compra: R$ {valorCompra:F2}");
    Console.WriteLine($"Desconto: R$ {desconto:F2}");
    Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
}

static void ExecutarSistema()
{
    string cliente = Cliente();

    double valorCompra = ValorDaCompra();
    double desconto = CalcularDesconto(valorCompra);
    double valorFinal = ValorFinal(valorCompra, desconto);

    ExibirResultado(cliente, valorCompra, desconto, valorFinal);
}

ExecutarSistema(); */

/*5-
double numero1;
double numero2;
double resultado = 0;
string opcao;
string continuar = "s";

static double Somar(double numero1, double numero2, double resultado)
{
    resultado = numero1 + numero2;
    return resultado;
}

static double Subtrair(double numero1, double numero2, double resultado)
{
    resultado = numero1 - numero2;
    return resultado;
}

static double Multiplicar(double numero1, double numero2, double resultado)
{
    resultado = numero1 * numero2;
    return resultado;
}

static double Dividir(double numero1, double numero2, double resultado)
{
    resultado = numero1 / numero2;
    return resultado;
}

while (continuar == "s" || continuar == "S")
{
    Console.Clear();
    Console.WriteLine("=== CALCULADORA ===");
    Console.WriteLine("+ Soma");
    Console.WriteLine("- Subtração");
    Console.WriteLine("* Multiplicação");
    Console.WriteLine("/ Divisão");
    Console.Write("Escolha uma opção: ");
    opcao = Console.ReadLine()!;

    Console.Write("Digite o primeiro número: ");
    numero1 = double.Parse(Console.ReadLine()!);

    Console.Write("Digite o segundo número: ");
    numero2 = double.Parse(Console.ReadLine()!);

    if (opcao == "+")
    {
        resultado = Somar(numero1, numero2, resultado);
        Console.WriteLine($"Resultado da soma: {resultado}");
    }
    else if (opcao == "-")
    {
        resultado = Subtrair(numero1, numero2, resultado);
        Console.WriteLine($"Resultado da subtração: {resultado}");
    }
    else if (opcao == "*")
    {
        resultado = Multiplicar(numero1, numero2, resultado);
        Console.WriteLine($"Resultado da multiplicação: {resultado}");
    }
    else if (opcao == "/")
    {
        resultado = Dividir(numero1, numero2, resultado);
        Console.WriteLine($"Resultado da divisão: {resultado}");
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }

    Console.WriteLine();
    Console.Write("Deseja fazer outro cálculo? (s/n): ");
    continuar = Console.ReadLine()!;
}

Console.Write("Fim de programa!!"); */

