using System.Diagnostics.CodeAnalysis;
using JogoGourmet;
using JogoGourmet.Interface;

[ExcludeFromCodeCoverage]
class Program
{
    private static void Main(string[] args)
    {
        var interfaceComUsuario = new InterfaceComUsuario();

        var cancellationToken = new CancellationTokenSource().Token;

        var jogo = new Jogo(interfaceComUsuario, cancellationToken);
        jogo.Iniciar();
    }
}