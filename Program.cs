
using ForcaFinal;
using System.Text.RegularExpressions;

string validaLoop;
do
{
    Palavras palavra = new Palavras();
    Textos texto = new Textos();
    Console.WriteLine("Bem vindo ao jogo da forca =D");
    string categoria = palavra.EscolheCategoria();
    string palavraSecreta = palavra.EscolhePalavra(categoria);
    char[] palavraOculta = new char[palavraSecreta.Length];
    char chute = ' ';
    var letrasValidas = new Regex("^[A-Z]$");
    char[] palavraOcultaDeValidacao = new char[palavraSecreta.Length];
    char[] letrasSelecionadas = new char[26];
    int tentativasRestantes = 6;
    bool validaInput;

    //iterando ao definir as letras selecionadas.
    int iterador = 0;
    foreach (char a in palavraSecreta)
    {
        palavraOculta[iterador] = a;
        if(a == ' ')
        {
            palavraOcultaDeValidacao[iterador] = ' ';
        }
        else
        {
            palavraOcultaDeValidacao[iterador] = '*';
        }
        
        iterador++;
    }
    iterador = 0;
    Console.Clear();
    do
    {
        bool acertou = false;
        texto.Desenho(tentativasRestantes);
        texto.Exibir(palavraOcultaDeValidacao,letrasSelecionadas,categoria.ToUpper());
        Console.WriteLine("faça um palpite");
        // armazena o input do player na variável chute.
        try
        {
            do
            {
                char.TryParse(Console.ReadLine().ToUpper(), out chute);
                validaInput = letrasValidas.IsMatch(chute.ToString());
                if (!validaInput)
                {
                    Console.WriteLine("Por favor informe UMA letra");
                }
                if (letrasSelecionadas.Contains(chute) && chute != '\0')
                {
                    Console.WriteLine("Essa letra já foi informada, tente outra.");
                }
            } while (!validaInput || letrasSelecionadas.Contains(chute));

        }
        catch (Exception)
        {
            Console.WriteLine("erro inesperado, encerrando o programa");
            break;
        }
        
        iterador = AdicionaALetrasSelecionadas(chute, letrasSelecionadas, iterador);
        //encontrar letra na palavra oculta
        acertou = ModificaPalavra(palavraSecreta, palavraOculta, chute, palavraOcultaDeValidacao, acertou);
        //valida o erro;
        tentativasRestantes = ReduzTentativas(tentativasRestantes, acertou);
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
    } while (tentativasRestantes > 0 && palavraOcultaDeValidacao.Contains('*'));
    Console.WriteLine(texto.MensagemFinal(tentativasRestantes, palavraSecreta, palavraOcultaDeValidacao,letrasSelecionadas)); 
    validaLoop = Console.ReadLine();
} while (validaLoop.ToUpper() != "N");

static int AdicionaALetrasSelecionadas(char chute, char[] letrasSelecionadas, int iterador)
{
    letrasSelecionadas[iterador] = chute;
    iterador++;
    return iterador;
}

static int ReduzTentativas(int tentativasRestantes, bool acertou)
{
    if (acertou == false)
    {
        tentativasRestantes--;
        Console.WriteLine($"A letra informada não faz parte da palavra, restam {tentativasRestantes} tentativas");
    }

    return tentativasRestantes;
}

static bool ModificaPalavra(string palavraSecreta, char[] palavraOculta, char chute, char[] palavraOcultaDeValidacao, bool acertou)
{
    for (int i = 0; i < palavraSecreta.Length; i++)
    {
        if (chute == palavraOculta[i])
        {
            palavraOcultaDeValidacao[i] = chute;
            acertou = true;
        }
    }

    return acertou;
}