
using gameTOP.Interface;

namespace gameTOP.Lib
{

    public class Jogador1:IJogador
    {
        public readonly string _nome;

        public Jogador1(string nome="Ronaldo Fenômeno")
        {
            this._nome = nome;
        }

        public string Chuta()
        {
            return $"{_nome} está chutando.";
        }
        public string Corre()
        {
            return $"{_nome} está correndo.";
        }
        public string Passe()
        {
            return $"{_nome} está passando.";
        }
    }
}