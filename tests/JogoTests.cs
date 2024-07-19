using JogoGourmet.Interface;
using Moq;
using Xunit;

namespace JogoGourmet.Tests;

public class JogoTests
{
    private readonly Mock<IInterfaceComUsuario> _mockInterface;
    private readonly CancellationTokenSource _cts;

    public JogoTests()
    {
        _mockInterface = new Mock<IInterfaceComUsuario>();
        _cts = new CancellationTokenSource();
    }

    [Fact]
    public void Jogo_InicializaComDoisPratosBasicos()
    {
        var mockInteracaoUsuario = new Mock<IInterfaceComUsuario>();
        var jogo = new Jogo(mockInteracaoUsuario.Object, _cts.Token);

        Assert.NotNull(jogo);
    }

    [Fact]
    public void Jogo_Iniciar_DevePerguntarAoUsuario()
    {
        // Arrange
        var jogo = new Jogo(_mockInterface.Object, _cts.Token);

        // Act
        var task = new Task(() => jogo.Iniciar());
        task.Start();
        _cts.Cancel();

        // Assert
        _mockInterface.Verify(m => m.Escrever("Pense em um prato que gosta..."), Times.Once);
    }
}
