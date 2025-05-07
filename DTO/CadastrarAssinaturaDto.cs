namespace ProjetoLivros.DTO
{
    public class CadastrarAssinaturaDto
    {
        public int AssinaturaId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Status { get; set; }
        public int UsuarioId { get; set; }
    }
}
