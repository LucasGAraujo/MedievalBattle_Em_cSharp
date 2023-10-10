using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDeClasses.Monstros
{
    public class Monstros
    {
        public string Tipo { get; set; }
        public int PontoDeVida { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public int Agilidade { get; set; }
        public int QuantdeLadoDado { get; set; }
        public int QuantdeJogada { get; set; }


        public Monstros(string tipo, int pontoDeVida, int ataque, int defesa, int agilidade, int quantidadeLadoDado, int quantidadeJogada)
        {
            this.Tipo = tipo;
            this.PontoDeVida = pontoDeVida;
            this.Ataque = ataque;
            this.Defesa = defesa;
            this.Agilidade = agilidade;
            this.QuantdeLadoDado = quantidadeLadoDado;
            this.QuantdeJogada = quantidadeJogada;
        }
    }
}
