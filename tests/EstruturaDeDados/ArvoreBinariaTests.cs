using JogoGourmet.EstruturaDeDados;
using Xunit;

namespace JogoGourmet.Tests.EstruturaDeDados;

public class ArvoreBinariaTests
{
    [Fact]
    public void ArvoreBinaria_CriarArvore_ComRaizEsquerdaEDireita()
    {
        // Arrange
        var raiz = "raiz";
        var esquerda = new No("Esquerda");
        var direita = new No("Direita");

        // Act
        var arvore = new ArvoreBinaria(raiz, esquerda, direita);

        // Assert
        Assert.Equal(raiz, arvore.Raiz.Valor);
        Assert.Equal(esquerda, arvore.Esquerda);
        Assert.Equal(direita, arvore.Direita);
    }
}
