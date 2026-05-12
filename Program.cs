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

/*4- */
static string Cliente(string cliente)
{
    Console.Write("Digite o nome do cliente: ");
    cliente = Console.ReadLine()!;
    return cliente;
}

static double ValorDaCompra(double valorCompra)
{
    Console.Write("Digite o valor da compra: ");
    valorCompra = double.Parse(Console.ReadLine()!);
    return valorCompra;
}

static double CalcularDesconto(double desconto, double valorCompra)
{
    desconto = 0;
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


static void ValorFinal(double valorFinal, double valorCompra, double desconto)
{
    valorCompra = ValorDaCompra(valorCompra);
    desconto = ValorDaCompra(valorCompra);

    valorFinal = valorCompra - desconto;
}

static void ExecutarSistema()
{
    string cliente = Cliente("cliente");
    double valorCompra = ValorDaCompra(valorCompra);
    Console.WriteLine($"Cliente: {cliente}");
    Console.WriteLine($"Valor da compra: R$ {valorCompra:F2}");
    Console.WriteLine($"Desconto: R$ {calcularDesconto:F2}");
    Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
}
ExecutarSistema();

