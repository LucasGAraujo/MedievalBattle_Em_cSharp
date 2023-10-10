using System;
using System.Threading;

namespace Carregar
{
    public class Carregamento
    {
        public static void Carregar()
        {
            int numeroDePontos = 10; // Número de pontos na animação
            int delayEntrePontos = 360; // Tempo de atraso entre cada ponto (em milissegundos)

            
            

            for (int i = 0; i < numeroDePontos; i++)
            {
                Console.Write(".");
                Thread.Sleep(delayEntrePontos);
            }
            Console.WriteLine();

            
        }
    }
}

