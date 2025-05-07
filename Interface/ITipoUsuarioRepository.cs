using ProjetoLivros.Models;
using ProjetoLivros.ViewModels;

namespace ProjetoLivros.Interface
{
    public interface ITipoUsuarioRepository
    {
        List<TipoUsuario> ListarTodos();


        //Recebe um identificador, e retorna o produto correspondente
        Livro BuscarPorId(int id);

        //C - Create (Cadastro)

        void Cadastrar(TipoUsuario tipoUsuario);

        // U - Update (Atualizacao)
        // Recebe um identificador para encontrar um produto,
        // e recebe o produto novo para substituir o artigo 

        void Atualizar(int id, TipoUsuario tipoUsuario);

        //D - Delete (delecao)
        // Recebo o indentificador de quem quero excluir 
        void Deletar(int id);

        List<TipoUsuario> BuscarTipoUsuarioPorNome(string tipoUsuario);
    }
}
