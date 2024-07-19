using System.Diagnostics.CodeAnalysis;
using JogoGourmet.Interface;

namespace JogoGourmet;

[ExcludeFromCodeCoverage]
static class Program
{
    private static void Main(string[] args)
    {
        var interfaceComUsuario = new InterfaceComUsuario();

        var cancellationToken = new CancellationTokenSource().Token;

        var jogo = new Jogo(interfaceComUsuario, cancellationToken);
        jogo.Iniciar();
    }
}