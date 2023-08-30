using System.Runtime.CompilerServices;

namespace ProjetoNotificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Twitter Joao = new Twitter("Joao");
        Twitter Maria = new Twitter("Maria");

        Joao.UpdateSeguidores(Maria);
        
        Maria.RegisterMensagens("Atirei o pau no gato");
    }
}