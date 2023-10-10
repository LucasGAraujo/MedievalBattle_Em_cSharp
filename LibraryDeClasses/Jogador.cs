using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDeClasses
{
    public  class Jogador
    {
        public String NickName { get; set; }
        public Personagens Heroi { get; set; }
        public int Xp { get; set; }
        public int Nivel { get; set; }

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
