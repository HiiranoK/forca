using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcaFinal
{
    internal class Textos
    {
        string[] animais = {"GATO","CACHORRO","PAPAGAIO","ELEFANTE","HUMANO", "CISNE", "GIRAFA", "ABELHA", "SURICATO", "COALA", "HIPOPOTAMO",
                "CAVALO", "BUFALO", "TAMANDUA", "FORMIGA", "CASTOR", "LEAO", "PINGUIM", "POLVO", "TUBARAO", "TARTARUGA"};

        string[] cidade = {"APARTAMENTO", "TRANSITO","CARRO","MOTO","SEMAFORO","METRO","MUSEU", "ESTADIO", "POLUICAO", "PLASTICO", "STRESS",
                "ESCOLA", "AEROPORTO", "ESPECULACAO", "FAVELA", "FACULDADE","CENTRO COMERCIAL","CONCRETO"};

        string[] comidas = { "PUDIM", "YAKISOBA", "LASANHA", "CHOCOTONE", "ROCAMBOLE", "BOLO", "HAMBURGUER", "PANQUECA", "BAIAO DE DOIS", "PIZZA", "CUSCUS", "FEIJOADA",
                "PAO DE QUEIJO", "VITAMINA", "PASTEL", "EMPADA", "ESCONDIDINHO", "CEIA DE NATAL"};

        string[] cores = { "AZUL", "VERDE", "PRETO", "AMARELO", "VERMELHO", "ROSA", "BRANCO", "LARANJA", "ROXO", "CINZA", "MARROM" };

        string[] geral = {"GATO","CACHORRO","PAPAGAIO","ELEFANTE","HUMANO", "CISNE", "GIRAFA", "ABELHA", "SURICATO", "COALA", "HIPOPOTAMO",
                "CAVALO", "BUFALO", "TAMANDUA", "FORMIGA", "CASTOR", "LEAO", "PINGUIM", "POLVO", "TUBARAO", "TARTARUGA","APARTAMENTO", "TRANSITO","CARRO","MOTO","SEMAFORO","METRO","MUSEU", "ESTADIO", "POLUICAO", "PLASTICO", "STRESS",
                "ESCOLA", "AEROPORTO", "ESPECULACAO", "FAVELA", "FACULDADE","CENTRO COMERCIAL","CONCRETO","PUDIM", "YAKISOBA", "LASANHA", "CHOCOTONE", "ROCAMBOLE", "BOLO", "HAMBURGUER", "PANQUECA", "BAIAO DE DOIS", "PIZZA", "CUSCUS", "FEIJOADA",
                "PAO DE QUEIJO", "VITAMINA", "PASTEL", "EMPADA", "ESCONDIDINHO", "CEIA DE NATAL","AZUL", "VERDE", "PRETO", "AMARELO", "VERMELHO", "ROSA", "BRANCO", "LARANJA", "ROXO", "CINZA", "MARROM"};

        public string EscolheCategoria()
        {


            Dictionary<int, string> categorias = new();
            categorias.Add(1, "animais");
            categorias.Add(2, "cidade");
            categorias.Add(3, "comidas");
            categorias.Add(4, "cores");
            categorias.Add(5, "geral");
            int valor;
            string opcaoSelecionada;
            do
            {
                Console.WriteLine("Informe o nº da categoria desejada:\n[1]-animais \n[2]-cidade\n[3]-comidas\n[4]-cores\n[5]-geral");
                int.TryParse(Console.ReadLine(), out valor);
                if (valor >= 1 && valor <= 5)
                {
                    break;
                }
                Console.WriteLine("O valor informado não é válido, tente novamente");
            } while (true);
            categorias.TryGetValue(valor, out opcaoSelecionada);
            return opcaoSelecionada;
        }
        public string EscolhePalavra(string valor)
        {
            switch (valor)
            {
                case "animais":
                    return animais[new Random().Next(animais.Length)];
                    break;
                case "cidade":
                    return cidade[new Random().Next(cidade.Length)];
                    break;
                case "comidas":
                    return comidas[new Random().Next(comidas.Length)];
                    break;
                case "cores":
                    return cores[new Random().Next(cores.Length)];
                    break;
                case "geral":
                    return geral[new Random().Next(geral.Length)];
                    break;
                default:
                    Console.WriteLine("resultado inesperado");
                    return "0";
                    break;
            }
        }
        public void Exibir(char[] palavraOcultaDeValidacao, char[]letras,string categoria)
        {
            Console.WriteLine("palavra da rodada");
            string exibir = "";
            foreach (char a in palavraOcultaDeValidacao)
            {
                exibir += a;
            }

            Console.WriteLine("Categoria atual: "+ categoria + "\n"+ exibir);
            LetrasInformadas(letras);
        }
        public void Exibir(char[] palavraOcultaDeValidacao, char[] letras)
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
