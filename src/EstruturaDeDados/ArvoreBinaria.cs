namespace JogoGourmet.EstruturaDeDados;

public class ArvoreBinaria
{
    public ArvoreBinaria(string raiz, No esquerda, No direita)
    {
        Esquerda = esquerda;
        Direita = direita;

        Raiz = new No(raiz, esquerda, direita);
    }

    public No Raiz { get; private set; }
    public No Esquerda { get; private set; }
    public No Direita { get; private set; }
}
