namespace MedievalBattle.Funcionais
{
    using Carregar;
    using LibraryDeClasses;
    using LibraryDeClasses.Monstros;
    using System;
    using LibrarydeEntidades;
    using System.Collections.Generic;

    public class Batalha
    {
        private Random random = new Random();
        private Jogador jogador;
        GerenciarService gerenciarService = new GerenciarService();

        public Batalha(Jogador jogador)
        {
            this.jogador = jogador;
        }

        public void RealizarBatalha()
        {
            Monstros m1 = new MortoVivo();
            Monstros m2 = new Orc();
            Monstros m3 = new Kobold();
            Monstros m4 = new Troll();
            Monstros m5 = new Zumbi();
            List<Monstros> listaDeMonstros = new List<Monstros>();
            listaDeMonstros.Add(m1);
            listaDeMonstros.Add(m2);
            listaDeMonstros.Add(m3);
            listaDeMonstros.Add(m4);
            listaDeMonstros.Add(m5);

            int monstroSorteado = random.Next(5);
            int valorHeroi = random.Next(10) + 1;
            int valorMonstro = random.Next(10) + 1;
            Monstros monstroSelecionado = listaDeMonstros[monstroSorteado];
            Console.WriteLine("    ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Possíveis monstros a enfrentar ... ");
            Console.WriteLine("Monstro    - Ponto de vida - Força - Defesa - Agilidade - Fator de Dano ");
            Console.WriteLine("Morto-vivo -     25        -   4   -    0   -     1     -       2d4     ");
            Console.WriteLine("ORC        -     20        -   6   -    2   -     2     -       1d8     ");
            Console.WriteLine("Kobold     -     20        -   4   -    2   -     4     -       3d2     ");
            Console.WriteLine("Troll      -     22        -   6   -    3   -     1     -       1d6     ");
            Console.WriteLine("Zumbi      -     27        -   2   -    2   -     1     -       2d4     ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Sorteando monstro ");
            Carregamento.Carregar();
            Console.WriteLine("Monstro sorteado foi " + monstroSelecionado.Tipo);
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Rolando um dado de 10 faces...");
            Carregamento.Carregar();

            while (valorMonstro == valorHeroi)
            {
                Console.WriteLine("Valores iguais...");
                Console.WriteLine("Rolando um dado de 10 faces...");
                Carregamento.Carregar();
                valorMonstro = random.Next(10) + 1;
                valorHeroi = random.Next(10) + 1;
            }

            Console.WriteLine("Valor Monstro: " + (valorMonstro + monstroSelecionado.Agilidade));
            Console.WriteLine("Valor Herói: " + (valorHeroi + jogador.Heroi.Agilidade));
            string iniciaAtaque = (valorMonstro > valorHeroi) ? "Monstro inicia" : "Herói inicia";
            bool iniciamonstro = (valorMonstro > valorHeroi);

            Console.WriteLine(iniciaAtaque);

            int rodadas = 0;
            while (jogador.Heroi.PontoDeVida > 0 && monstroSelecionado.PontoDeVida > 0)
            {
                rodadas++;
                if (iniciamonstro)
                {
                    Console.WriteLine("Iniciando rodada");
                    Carregamento.Carregar();
                    int valorAtaque = random.Next(10) + 1 + monstroSelecionado.Agilidade + monstroSelecionado.Ataque;
                    int valorDefesa = random.Next(10) + 1 + jogador.Heroi.Agilidade + jogador.Heroi.Defesa;
                    Console.WriteLine("Resultado dado de 10 - Monstro ATACA");
                    Console.WriteLine("Valor de ataque: " + valorAtaque);
                    Console.WriteLine("Valor de defesa: " + valorDefesa);
                    Console.WriteLine("");
                    Console.WriteLine("------------------");
                    Console.WriteLine("");
                    if (valorAtaque <= valorDefesa)
                    {
                        Console.WriteLine("Valor de ataque igual ou menor... girando rodada");
                        Console.WriteLine("");
                        Console.WriteLine("------------------");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Monstro atacando");
                        Carregamento.Carregar();
                        gerenciarService.AtacarJogador(jogador, monstroSelecionado);
                    }
                    iniciamonstro = false;
                }
                else
                {
                    Console.WriteLine("Iniciando rodada");
                    Carregamento.Carregar();
                    int valorAtaque = random.Next(10) + 1 + jogador.Heroi.Agilidade + jogador.Heroi.Ataque;
                    int valorDefesa = random.Next(10) + 1 + monstroSelecionado.Agilidade + monstroSelecionado.Defesa;
                    Console.WriteLine("Resultado dado de 10 - herói ATACA");
                    Console.WriteLine("Valor de ataque: " + valorAtaque);
                    Console.WriteLine("Valor de defesa: " + valorDefesa);
                    Console.WriteLine("");
                    Console.WriteLine("------------------");
                    Console.WriteLine("");
                    if (valorAtaque <= valorDefesa)
                    {
                        Console.WriteLine("Valor de ataque igual ou menor... girando rodada");
                        Console.WriteLine("");
                        Console.WriteLine("------------------");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Heroi atacando");
                        Carregamento.Carregar();
                        gerenciarService.AtacarMonstro(jogador, monstroSelecionado);
                    }
                    iniciamonstro = true;
                }
            }

            string resultado;
            Console.WriteLine("A rodada durou ..." + rodadas);
            if (jogador.Heroi.PontoDeVida <= 0)
            {
                Console.WriteLine("O monstro venceu!");
                resultado = "perdeu";
                jogador.Xp -= 20; 
            }
            else
            {
                Console.WriteLine("O herói venceu!");
                resultado = "Ganhou";
                jogador.Xp += 60;
            }
           //jogador.GravarLog(jogador.GetNickName(), jogador.GetHeroi().GetTipoHeroi(), resultado, monstroSelecionado.GetTipoMonstro(), rodadas);
        }
    }

}
