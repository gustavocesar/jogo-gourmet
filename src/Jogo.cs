﻿using JogoGourmet.EstruturaDeDados;

namespace JogoGourmet;

public class Jogo
{
    private No _raiz;

    public Jogo()
    {
        //inicialização com dois pratos básicos
        var esquerda = new No("Lasanha");
        var direita = new No("Bolo de Chocolate");

        var arvore = new ArvoreBinaria("Massa", esquerda, direita);
        _raiz = arvore.Raiz;
    }

    public void Iniciar()
    {
        Console.WriteLine("Pense em um prato que gosta...");

        while (true)
            Perguntar(_raiz, null!, false);
    }

    private void Perguntar(No no, No pai, bool isEsquerda)
    {
        if (no.IsNoFolha())
        {
            //estamos em um nó folha (prato)
            Console.WriteLine($"O prato que você pensou é {no.Valor}? (sim/não)");
            string resposta = Console.ReadLine()!.ToLower();

            if (resposta is "sim")
            {
                Console.WriteLine("Acertei!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Qual prato você pensou?");
                string novoPrato = Console.ReadLine()!;

                Console.WriteLine($"{novoPrato} é _____________ mas {no.Valor} não.");
                string diferenca = Console.ReadLine()!;

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

                Console.WriteLine("Obrigado! Vou lembrar disso da próxima vez.");
            }
        }
        else
        {
            //estamos em um nó intermediário (pergunta)
            Console.WriteLine($"O prato que você pensou é {no.Valor}? (sim/não)");
            string resposta = Console.ReadLine()!.ToLower();

            if (resposta is "sim")
                Perguntar(no.Esquerda!, no, true);
            else
                Perguntar(no.Direita!, no, false);
        }
    }
}
