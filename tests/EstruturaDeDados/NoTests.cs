using JogoGourmet.EstruturaDeDados;
using Xunit;

namespace JogoGourmet.Tests.EstruturaDeDados;

public class NoTests
{
    [Fact]
    public void Construtor_ValorDefinido_DeveDefinirValorCorretamente()
    {
        // Arrange
        string valor = "Teste";

        // Act
        var no = new No(valor);

        // Assert
        Assert.Equal(valor, no.Valor);
    }

    [Fact]
    public void Construtor_ValorEsquerdaEDireitaDefinidos_DeveDefinirValoresCorretamente()
    {
        // Arrange
        string valor = "Teste";
        var esquerda = new No("Esquerda");
        var direita = new No("Direita");

        // Act
        var no = new No(valor, esquerda, direita);

        // Assert
        Assert.Equal(valor, no.Valor);
        Assert.Equal(esquerda, no.Esquerda);
        Assert.Equal(direita, no.Direita);
    }

    [Fact]
    public void Construtor_ValorEsquerdaEDireitaComoStringDefinidos_DeveDefinirValoresCorretamente()
    {
        // Arrange
        string valor = "Teste";
        string esquerda = "Esquerda";
        string direita = "Direita";

        // Act
        var no = new No(valor, esquerda, direita);

        // Assert
        Assert.Equal(valor, no.Valor);
        Assert.Equal(esquerda, no.Esquerda?.Valor);
        Assert.Equal(direita, no.Direita?.Valor);
    }

    [Fact]
    public void IsNoFolha_NoComEsquerdaEDireitaNulos_DeveRetornarTrue()
    {
        // Arrange
        var no = new No("Teste");

        
        Assert.True(no.IsNoFolha());
    }

    [Fact]
    public void IsNoFolha_NoComEsquerdaDefinidaEDireitaNula_DeveRetornarFalse()
    {
        // Arrange
        var esquerda = new No("Esquerda");
        var no = new No("Teste", esquerda, null);

        // Act & Assert
        Assert.False(no.IsNoFolha());
    }

    [Fact]
    public void IsNoFolha_NoComEsquerdaNulaEDireitaDefinida_DeveRetornarFalse()
    {
        // Arrange
        var direita = new No("Direita");
        var no = new No("Teste", null, direita);

        // Act & Assert
        Assert.False(no.IsNoFolha());
    }

    [Fact]
    public void SetEsquerda_EsquerdaDefinida_DeveDefinirEsquerdaCorretamente()
    {
        // Arrange
        var esquerda = new No("Esquerda");
        var no = new No("Teste");

        // Act
        no.SetEsquerda(esquerda);

        // Assert
        Assert.Equal(esquerda, no.Esquerda);
    }

    [Fact]
    public void SetDireita_DireitaDefinida_DeveDefinirDireitaCorretamente()
    {
        // Arrange
        var direita = new No("Direita");
        var no = new No("Teste");

        // Act
        no.SetDireita(direita);

        // Assert
        Assert.Equal(direita, no.Direita);
    }
}
