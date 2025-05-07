using ProjetoLivros.Context;
using ProjetoLivros.Interface;
using ProjetoLivros.Models;

namespace ProjetoLivros.Repository
{
    public class AssinaturaRepository : IAssinaturaRepository
    {
    
            private readonly LivrosContext _context;

        public AssinaturaRepository(LivrosContext context)
        {
            _context = context;
        }


        public void Atualizar(int id, Assinatura assinatura)
        {
            throw new NotImplementedException();
        }

        public List<Assinatura> BuscarAssinaturaPorNome(string assinatura)
        {
            throw new NotImplementedException();
        }

        public Assinatura BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Assinatura assinatura)
        {
            _context.Assinatura.Add(assinatura);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            var assinatura = _context.Assinatura.Find(id);
            if (assinatura == null) throw new Exception();

            _context.Assinatura.Remove(assinatura);

            _context.SaveChanges();
        }

   
        public List<Assinatura> ListarTodos()
        {
            return _context.Assinatura.ToList();
        }
    }
}
