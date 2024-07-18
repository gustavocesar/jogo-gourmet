using JogoGourmet;
using JogoGourmet.Interface;

var interfaceComUsuario = new InterfaceComUsuario();

var jogo = new Jogo(interfaceComUsuario);
jogo.Iniciar();
