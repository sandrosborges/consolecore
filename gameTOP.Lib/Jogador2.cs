using gameTOP.Interface;

namespace gameTOP.Lib
{
    public class Jogador2 : IJogador
    {        

        public string Chuta()
        {
            return "Maradona estas pateando";
        }
        public string Corre()
        {
            return "Maradona estas corriendo";
        }
        public string Passe()
        {
            return "Maradona estas passando";
        }
    }
}