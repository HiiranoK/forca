using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcaFinal
{
    internal class Textos
    {
        
        public void Exibir(char[] palavraOcultaDeValidacao, char[]letras)
        {
            Console.WriteLine("palavra da rodada");
            string exibir = "";
            foreach (char a in palavraOcultaDeValidacao)
            {
                exibir += a;
            }
            Console.WriteLine(exibir);
            LetrasInformadas(letras);
        }

        public void Desenho(int tentativas)
        {
            if (tentativas == 6)
            {
                Console.WriteLine($"+----+\n" +
                                  $"|\n" +
                                  $"|\n" +
                                  $"|\n" +
                                  $"|\n");
            }
            else if (tentativas == 5)
            {
                Console.WriteLine($"+----+\n" +
                                  $"|    O\n" +
                                  $"|\n" +
                                  $"|\n" +
                                  $"|\n");
            }
            else if (tentativas == 4)
            {
                Console.WriteLine($"+----+\n" +
                                  $"|    O\n" +
                                  $"|    |\n" +
                                  $"|\n" +
                                  $"|\n");
            }
            else if (tentativas == 3)
            {
                Console.WriteLine($"+----+\n" +
                                  $"|    O\n" +
                                  $"|   /|\n" +
                                  $"|\n" +
                                  $"|\n");
            }
            else if (tentativas == 2)
            {
                Console.WriteLine($"+----+\n" +
                                  $"|    O\n" +
                                  $"|   /|\\\n" +
                                  $"|\n" +
                                  $"|\n");
            }
            else if (tentativas == 1)
            {
                Console.WriteLine($"+----+\n" +
                                  $"|    O\n" +
                                  $"|   /|\\\n" +
                                  $"|   /\n" +
                                  $"|\n");
            }
            else
            {
                Console.WriteLine($"+----+\n" +
                                  $"|    O\n" +
                                  $"|   /|\\\n" +
                                  $"|   / \\\n" +
                                  $"|\n");
            }
        }
        public string MensagemFinal(int tentativasRestantes,string palavraSecreta, char[] palavraOcultaDeValidacao, char[] letras)
        {
            string mensagem;
            if (tentativasRestantes <= 0)
            {
                Exibir(palavraOcultaDeValidacao,letras);
                Desenho(tentativasRestantes);
                mensagem =$"Infelizmente não foi dessa vez =/ a palavra secreta era: {palavraSecreta}\n" +
                    $"Deseja tentar novamente? responda[N] para encerrar.";
                return mensagem.ToUpper();
            }
            Exibir(palavraOcultaDeValidacao,letras);
            Desenho(tentativasRestantes);
             mensagem =$"Parabéns obrigado por jogar! deseja tentar novamente? responda [N] para encerrar.";
            return mensagem.ToUpper();

        }
        public void LetrasInformadas(char[] letras)
        {
            string valores = "Palpites informados: ";
            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] != '\0')
                {
                    if (i == 0)
                    {
                        valores += $"[{letras[i]}]";
                    }
                    else
                    {
                        valores += $",[{letras[i]}]";
                    }
                }
            }
            Console.WriteLine(valores); ;
        }
    }

}
