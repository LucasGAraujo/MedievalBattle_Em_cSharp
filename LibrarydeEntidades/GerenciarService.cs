using LibraryDeClasses;
using LibraryDeClasses.Monstros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarydeEntidades
{
    public class GerenciarService
    {
        public void AtacarMonstro(Jogador jogador, Monstros monstroSelecionado)
        {
            Random random = new Random();
            int dano = 0;

            for (int i = 0; i <= jogador.Heroi.QuantdeJogada; i++)
            {
                int atacar = random.Next(jogador.Heroi.QuantdeLadoDado);
                dano += atacar;
            }

            Console.WriteLine("Herói atacando . . .");
            Console.WriteLine("As somas de dados foi ... " + dano);

            int vidaMonstro = monstroSelecionado.PontoDeVida - dano;
            monstroSelecionado.PontoDeVida = vidaMonstro;

            Console.WriteLine("Resultado desta rodada...");
            Console.WriteLine("A vida do monstro agora é: " + monstroSelecionado.PontoDeVida);
            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");
        }

        public void AtacarJogador(Jogador jogador, Monstros monstroSelecionado)
        {
            Random random = new Random();
            int dano = 0;

            for (int i = 0; i <= monstroSelecionado.QuantdeJogada; i++)
            {
                int atacar = random.Next(monstroSelecionado.QuantdeLadoDado);
                dano += atacar;
            }

            Console.WriteLine("Monstro atacando . . .");
            Console.WriteLine("As somas de dados foi ... " + dano);

            int vidaHeroi = jogador.Heroi.PontoDeVida - dano;
            jogador.Heroi.PontoDeVida = vidaHeroi;

            Console.WriteLine("Resultado desta rodada...");
            Console.WriteLine("A vida do herói agora é: " + jogador.Heroi.PontoDeVida);
            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");
        }
    }
}
