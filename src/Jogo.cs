using JogoGourmet.EstruturaDeDados;
using JogoGourmet.Interface;

namespace JogoGourmet;

public class Jogo
{
    private No _raiz;
    private IInterfaceComUsuario _interface;

    public Jogo(IInterfaceComUsuario interfaceComUsuario)
    {
        _interface = interfaceComUsuario;

        //inicialização com dois pratos básicos
        var esquerda = new No("Lasanha");
        var direita = new No("Bolo de Chocolate");

        var arvore = new ArvoreBinaria("Massa", esquerda, direita);
        _raiz = arvore.Raiz;
    }

    public void Iniciar()
    {
        _interface.Escrever("Pense em um prato que gosta...");

        while (true)
            Perguntar(_raiz, null!, false);
    }

    private void Perguntar(No no, No pai, bool isEsquerda)
    {
        if (no.IsNoFolha())
            PerguntarSobrePrato(no, pai, isEsquerda);
        else
            PerguntarSobreCategoriaDoPrato(no);
    }

    //tratamento de nós folha (pratos)
    private void PerguntarSobrePrato(No no, No pai, bool isEsquerda)
    {
        var resposta = ObterRespostaDoUsuario($"O prato que você pensou é {no.Valor}? (sim/não)");

        if (resposta is "sim")
            TratarRespostaSim();
        else
            TratarRespostaNao(no, pai, isEsquerda);
    }

    //tratamento de nós intermediários (perguntas)
    private void PerguntarSobreCategoriaDoPrato(No no)
    {
        var resposta = ObterRespostaDoUsuario($"O prato que você pensou é {no.Valor}? (sim/não)");

        if (resposta is "sim")
            Perguntar(no.Esquerda!, no, true);
        else
            Perguntar(no.Direita!, no, false);
    }

    private void TratarRespostaSim() =>
        _interface.Escrever("Acertei!");

    private void TratarRespostaNao(No no, No pai, bool isEsquerda)
    {
        var novoPrato = ObterRespostaDoUsuario("Qual prato você pensou?");

        var diferenca = ObterRespostaDoUsuario($"{novoPrato} é _____________ mas {no.Valor} não.");

        var novoNo = new No(diferenca, novoPrato, no.Valor);

        if (pai is not null)
        {
            if (isEsquerda)
                pai.SetEsquerda(novoNo);
            else
                pai.SetDireita(novoNo);
        }
        else
        {
            _raiz = novoNo;
        }

        _interface.Escrever("Obrigado! Vou lembrar disso da próxima vez.");
    }

    private string ObterRespostaDoUsuario(string pergunta)
    {
        _interface.Escrever(pergunta);

        string resposta;
        do
            resposta = _interface.Ler();
        while (string.IsNullOrWhiteSpace(resposta));

        return resposta;
    }
}
