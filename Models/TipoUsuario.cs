using System.Data;

namespace ProjetoLivros.Models
{


    //prop+tab = criar uma propriedade
    public class TipoUsuario
    {
        public int TipoUsuarioId { get; set; }
        public string DescricaoTipo { get; set; }
        public List<Usuario> Usuarios { get; set; }   = new(); //= new(); = Para nao ser nulo 
    }
}