using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorJogo jogo = new GerenciadorJogo();
            jogo.Jogar();
        }
    }
}
