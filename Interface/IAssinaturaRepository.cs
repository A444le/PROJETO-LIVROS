using ProjetoLivros.Models;
using ProjetoLivros.ViewModels;

namespace ProjetoLivros.Interface
{
    public interface IAssinaturaRepository
    {
        //R - Read (Leitura)
        //Retorno
        List<Assinatura> ListarTodos();


        //Recebe um identificador, e retorna o produto correspondente
        Assinatura BuscarPorId(int id);

        //C - Create (Cadastro)

        void Cadastrar(Assinatura assinatura);

        // U - Update (Atualizacao)
        // Recebe um identificador para encontrar um produto,
        // e recebe o produto novo para substituir o artigo 

        void Atualizar(int id, Assinatura assinatura);

        //D - Delete (delecao)
        // Recebo o indentificador de quem quero excluir 
        void Deletar(int id);

        Task<List<Assinatura>> BuscarAssinaturaPorNome(string assinatura);
    }
}
