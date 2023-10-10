using LibraryDeClasses;
using LibraryDeClasses.Herois;
using Carregar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace MedievalBattle.Funcionais
{
    public class Menu
    {
        private bool inicia = true;
        private Jogador jogador = null;

        public void IniciarMenu()
        {
            while (inicia)
            {
                Console.WriteLine("Carregando menu ");
                Carregamento.Carregar();
                Console.WriteLine("Digite o seu nickname: ");
                string nome = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Escolha um herói");
                Console.WriteLine("[ ] Herói  - Ponto de vida - Força - Defesa - Agilidade - Fator de Dano ");
                Console.WriteLine("[1] Guerreiro -     12      -   4   -    3   -     3     -       2d4     ");
                Console.WriteLine("[2] Bárbaro   -     13      -   6   -    1   -     3     -       2d6     ");
                Console.WriteLine("[3] Paladino  -     15      -   2   -    5   -     1    -        2d4     ");
                Console.WriteLine("[4] Arqueiro  -     10      -   4   -    3   -     6    -        2d5     ");
                Console.WriteLine("[5] Mago      -     08      -   2   -    3   -     6    -        2d6     ");
                int opcao;

                try
                {
                    inicia = false;
                    opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            jogador = new Jogador(nome, new Guerreiro());
                            break;
                        case 2:
                            jogador = new Jogador(nome, new Barbaro());
                            break;
                        case 3:
                            jogador = new Jogador(nome, new Paladino());
                            break;
                        case 4:
                            jogador = new Jogador(nome, new Arqueiro());
                            break;
                        case 5:
                            jogador = new Jogador(nome, new Mago());
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Saindo do jogo.");
                            inicia = true;
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Opção inválida. Por favor, insira um número inteiro.");
                    inicia = true;
                }
            }
            Console.WriteLine("Iniciando batalha");
            Carregamento.Carregar();

             Batalha batalha = new Batalha(jogador);
            batalha.RealizarBatalha();
        }
    }
}
