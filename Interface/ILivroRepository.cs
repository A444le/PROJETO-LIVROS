using ProjetoLivros.Models;
using ProjetoLivros.ViewModels;

namespace ProjetoLivros.Interface
{
    public interface ILivroRepository
    {
        List<ListarLivroViewModel> ListarTodos();


        //Recebe um identificador, e retorna o produto correspondente
        Livro BuscarPorId(int id);

        //C - Create (Cadastro)

        void Cadastrar(Livro livro);

        // U - Update (Atualizacao)
        // Recebe um identificador para encontrar um produto,
        // e recebe o produto novo para substituir o artigo 

        void Atualizar(int id, Livro livro);

        //D - Delete (delecao)
        // Recebo o indentificador de quem quero excluir 
        void Deletar(int id);

        List<Livro> BuscarLivroPorNome(string livro);
    }
}

