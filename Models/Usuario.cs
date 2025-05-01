namespace ProjetoLivros.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string? Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int TipoUsuarioId { get; set; } //Esse e pq e uma chave estrangeira 
        public TipoUsuario? TipoUsuario { get; set; } // Esse seria para ver o tipo de navegacao 
    }
}
