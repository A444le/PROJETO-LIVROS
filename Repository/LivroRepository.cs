using ProjetoLivros.Interface;
using ProjetoLivros.Models;
using ProjetoLivros.ViewModels;

namespace ProjetoLivros.Repository
{
    public class LivroRepository : ILivroRepository
    {
        public void Atualizar(int id, Livro livro)
        {
            throw new NotImplementedException();
        }

        public List<Livro> BuscarLivroPorNome(string livro)
        {
            throw new NotImplementedException();
        }

        public Livro BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Livro livro)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<ListarLivroViewModel> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
