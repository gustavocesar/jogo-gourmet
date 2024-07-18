namespace JogoGourmet.EstruturaDeDados;

public class ArvoreBinaria
{
    public ArvoreBinaria()
    {
        //inicialização com dois pratos básicos
        Esquerda = new No("Lasanha");
        Direita = new No("Bolo de Chocolate");
        Raiz = new No("Massa", Esquerda, Direita);
    }

    public No Raiz { get; private set; }
    public No Esquerda { get; private set; }
    public No Direita { get; private set; }
}
