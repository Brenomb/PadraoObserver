using System.Runtime.InteropServices.JavaScript;

namespace ProjetoNotificacoes;

public class Twitter : Observer_Seguidores
{
    public String NomeUsuario;
    public List<Twitter> Seguindo;
    public List<String> Mensagens;
    
    public Twitter(string _NomeUsuario)
    {
        NomeUsuario = _NomeUsuario;
        Seguindo = new List<Twitter>();
        Mensagens = new List<string>();
    }
    
    public void UpdateSeguidores(Twitter Usuario)
    {  
        Seguindo.Add(Usuario);
        Console.WriteLine($"{this.NomeUsuario} agora está seguindo {Usuario.NomeUsuario}.");
    }

    public void RegisterMensagens(String Mensagem)
    {
        Mensagens.Add(Mensagem);
        Console.WriteLine($"{NomeUsuario} publicou uma mensagem: {Mensagem}");
    }
}