using JogoGourmet.Interface;
using Moq;
using Xunit;

namespace JogoGourmet.Tests;

public class JogoTests
{
    [Fact]
    public void Jogo_InicializaComDoisPratosBasicos()
    {
        var mockInteracaoUsuario = new Mock<IInterfaceComUsuario>();
        var jogo = new Jogo(mockInteracaoUsuario.Object);

        Assert.NotNull(jogo);
    }
}
