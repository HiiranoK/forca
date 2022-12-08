using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcaFinal
{
    internal class Palavras
    {
public string Escolhepalavra()
        {
            string[] palavras = {"OCULOS","MARACUJA","BETERRABA", "ESQUINA", "PORAO", "PERNAMBUCO", "JOELHO", "FILHOTE", "ESCOLA", "PISCINA", "ATLETISMO",
        "PIX","SINQIA", "LETSCODE", "PICLES", "LIXA", "GOIABADA", "APARTAMENTO", "POLENTA", "ESCOLHA", "ESCALADA", "COELHO", "ABELHA", "CIVILIZACAO",
        "EGITO", "AMAZONIA", "FLORESTA", "OCEANO","TORNADO", "TERREMOTO","CONVENCAO","TORTO","ARADO","GRAMADO","CIMENTO","CONCRETO","NEVASCA","TABUA"};
 
            return palavras[new Random().Next(palavras.Length)];
        }
    }
}
