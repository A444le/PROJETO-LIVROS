using ProjetoLivros.Interface;
using ProjetoLivros.Models;

namespace ProjetoLivros.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Atualizar(int id, Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Livro BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> BuscarUsuarioPorNome(string usuario)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
