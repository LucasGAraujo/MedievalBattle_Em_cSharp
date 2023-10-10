using LibraryDeClasses;
using LibraryDeClasses.Monstros;


namespace LibrarydeEntidades
{
    public interface IGerenciar
    {
        void AtacarJogador(Jogador jogador, Monstros monstroSelecionado);
        void AtacarMonstro(Jogador jogador, Monstros monstroSelecionado);
    }
}
