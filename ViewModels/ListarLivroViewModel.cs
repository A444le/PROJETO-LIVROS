﻿namespace ProjetoLivros.ViewModels
{
    public class ListarLivroViewModel
    {
        public int LivrosId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }
    }
}
