using pooJogoAdivinhacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoAdivinhacao
{
    public class GerenciadorJogo
    {
        public GerenciadorJogo()
        {
            this.CriarPerguntas();
        }
        private List<NovaPergunta> perguntas;

        public List<NovaPergunta> Perguntas
        {
            get { return this.perguntas; }           
        }
        public void Jogar()
        {
            // Pegunta que será exibida para o usuário
            Random r = new Random();
            int pos = r.Next(0, perguntas.Count);
            NovaPergunta pergunta = perguntas[pos];
            int tentativas = 0;
            Boolean flag = false;
            String resposta = "";
            while (tentativas < 3 && flag == false)
            {
                Console.WriteLine("Pergunta: " + pergunta.Pergunta);
                Console.Write("Resposta: ");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();
                if (resposta == pergunta.Resposta)
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Errou!!!! Dica: " + pergunta.Dica);
                }
                tentativas++;
            }
            if (flag == true)
            {
                Console.WriteLine("Parabens!!!! Você ganhou o jogo");
            }
            else
            {
                Console.WriteLine("Que pena!!!! Você perdeu o jogo");
                Console.WriteLine("A resposta correta é: "+pergunta.Resposta);
            }   
            Console.ReadKey();
        }   
        private void CriarPerguntas()
        {
            perguntas = new List<NovaPergunta>();
            perguntas.Add(new NovaPergunta("Qual é a cor do céu?", "Azul", "começa com a letra A"));
            perguntas.Add(new NovaPergunta("Qual é a cor do sol?", "Amarelo", "começa com a letra A"));
            perguntas.Add(new NovaPergunta("Qual é a cor das nuvens?", "Branca", "começa com a letra B"));
            perguntas.Add(new NovaPergunta("Qual é a capital do Brasil?", "Brasilia", "começa com a letra B"));
            perguntas.Add(new NovaPergunta("Qual é a capital da Bahia?", "Salvador", "começa com a letra S"));
            perguntas.Add(new NovaPergunta("Qual é a capital de Sergipe?", "Aracaju", "começa com a letra A"));
            perguntas.Add(new NovaPergunta("Qual é a capital de Pernambuco?", "Recife", "começa com a letra R"));
            perguntas.Add(new NovaPergunta("Qual é a capital da Paraíba?", "João Pessoa", "começa com a letra J"));
            }
        }
    }

