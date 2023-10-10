namespace LibraryDeClasses
{
    public class Jogador
    {
        public String NickName { get; set; }
        public Herois.Herois Heroi { get; set; }
        public int Xp { get; set; }
        public int Nivel { get; set; }

        public Jogador(String NickName, Herois.Herois heroi)
        {
            this.NickName = NickName;
            this.Heroi = heroi;
        }
        public void GanharXP(int quantidadeXP)
        {
            Xp += quantidadeXP;

            if (Xp >= 100)
            {
                Nivel++;
                Xp = 0;
            }
        }
        }
    }

