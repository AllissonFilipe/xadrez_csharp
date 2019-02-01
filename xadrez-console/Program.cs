using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.colocarPeca(new Rei(Cor.Branca, tab), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);

                /*PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao());*/

            } catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
