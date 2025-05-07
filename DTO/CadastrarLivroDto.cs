namespace ProjetoLivros.DTO
{
    public class CadastrarLivroDto
    {
        public int LivrosId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }
        public int CategoriaId { get; set; }
    }
}
