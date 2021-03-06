

using System;
using gameTOP.Interface;

namespace gameTOP
{
    class JogoFoda
    {
        private readonly IJogador _jogador1;
        private readonly IJogador _jogador2;

        public JogoFoda(IJogador jogador1, IJogador jogador2)
        {
            this._jogador1 = jogador1;
            this._jogador2 = jogador2;

        }
        public void iniciarJogo()
        {
            Console.WriteLine(_jogador1.Corre());
            Console.WriteLine(_jogador1.Chuta());
            Console.WriteLine(_jogador1.Passe());

            Console.WriteLine(_jogador2.Corre());
            Console.WriteLine(_jogador2.Chuta());
            Console.WriteLine(_jogador2.Passe());

        }

    }


}