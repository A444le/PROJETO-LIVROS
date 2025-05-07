using ProjetoLivros.Models;

namespace ProjetoLivros.Interface
{
    public interface IUsuarioRepository
    {
        List<Usuario> ListarTodos();


        //Recebe um identificador, e retorna o produto correspondente
        Livro BuscarPorId(int id);

        //C - Create (Cadastro)

        void Cadastrar(Usuario usuario);

        // U - Update (Atualizacao)
        // Recebe um identificador para encontrar um produto,
        // e recebe o produto novo para substituir o artigo 

        void Atualizar(int id, Usuario usuario);

        //D - Delete (delecao)
        // Recebo o indentificador de quem quero excluir 
        void Deletar(int id);

        List<Usuario> BuscarUsuarioPorNome(string usuario);
    }
}

