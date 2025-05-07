using ProjetoLivros.Models;

namespace ProjetoLivros.Interface
{
    public interface ICategoriaRepository
    {
        List<Categoria> ListarTodos();


        //Recebe um identificador, e retorna o produto correspondente
        Categoria BuscarPorId(int id);

        //C - Create (Cadastro)

        void Cadastrar(Categoria categoria);

        // U - Update (Atualizacao)
        // Recebe um identificador para encontrar um produto,
        // e recebe o produto novo para substituir o artigo 

        void Atualizar(int id, Categoria categoria);

        //D - Delete (delecao)
        // Recebo o indentificador de quem quero excluir 
        void Deletar(int id);

        List<Categoria> BuscarCategoriaPorNome(string categoria);
    }
}

