
using System;
using gameTOP.Lib;


namespace gameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(new Jogador1(),new Jogador2());
            jogo.iniciarJogo();
        }
    }


}
