using gameTOP.Interface;

namespace gameTOP.Lib
{
    public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "Teste chuta...";
        }

        public string Corre()
        {
            return "Teste corre...";
        }

        public string Passe()
        {
            return "Teste passe...";
        }
    }
}