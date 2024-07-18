namespace JogoGourmet.Interface;

public class InterfaceComUsuario : IInterfaceComUsuario
{
    public void Escrever(string mensagem) =>
        Console.WriteLine(mensagem);

    public string Ler() =>
        Console.ReadLine()!.ToLower();
}
