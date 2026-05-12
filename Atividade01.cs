/*
Uma escola deseja criar um pequeno programa para calcular a média final de um aluno. 
O sistema deve receber o nome do aluno e três notas. Ao final, deve exibir a média e 
informar se o aluno foi aprovado, ficou em recuperação ou foi reprovado.

Código iniciado, o método LerNota ( ) é chamado, ele leva a string como mensagem 9Nota 1:; Nota 2: ...
*/

/* using System.Data;

static string LerNomeAluno(string nome)
{
    Console.WriteLine(nome);
    return nome;

}
static double LerNota(string mensagem)
{
    Console.Write(mensagem);
    double nota = double.Parse(Console.ReadLine()!);

    return nota;
}

static void ExecutarSistema()
{
    string nome = LerNomeAluno();

    double nota1 = LerNota("Nota 1: ");
    double nota2 = LerNota("Nota 2: ");
    double nota3 = LerNota("Nota 3: ");

    double media = CalcularMedia(nota1, nota2, nota3);

    string situacao = VerificarSituacao(media);

    ExibirResultado(nome, media, situacao);
}

ExecutarSistema(); */
/* ## Requisitos do programa

Crie um programa em C# que possua, no mínimo, os seguintes métodos:

```csharp
static string LerNomeAluno(){}
static double LerNota(string mensagem){}
static double CalcularMedia(double nota1, double nota2, double nota3){}
static string VerificarSituacao(double media)
static void ExibirResultado(string nome, double media, string situacao){}
``` */