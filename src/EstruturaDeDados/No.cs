namespace JogoGourmet.EstruturaDeDados;

public class No
{
    public No(string valor)
    {
        Valor = valor;
    }

    public No(string valor, No? esquerda, No? direita)
    {
        Valor = valor;
        Esquerda = esquerda;
        Direita = direita;
    }

    public string Valor { get; private set; }
    public No? Esquerda { get; private set; }
    public No? Direita { get; private set; }

    public bool IsNoFolha() =>
        Esquerda is null && Direita is null;

    public void SetEsquerda(No esquerda) =>
        Esquerda = esquerda;

    public void SetDireita(No direita) =>
        Direita = direita;
}
