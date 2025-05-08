using Microsoft.EntityFrameworkCore;
using ProjetoLivros.Context;
using ProjetoLivros.DTO;
using ProjetoLivros.Interface;
using ProjetoLivros.Models;
using static ProjetoLivros.Repository.AssinaturaRepository;

namespace ProjetoLivros.Repository
{
    public class AssinaturaRepository : IAssinaturaRepository
    {
        private readonly LivrosContext _context;


        public AssinaturaRepository(LivrosContext context)
        {
            _context = context;
        }

        public void Atualizar(int id, CadastrarAssinaturaDto Assinatura)
        {
            Assinatura assinaturaEncontrado = _context.Assinatura.Find(id);
            if (assinaturaEncontrado == null)
            {

                assinaturaEncontrado.AssinaturaId = Assinatura.AssinaturaId;
                assinaturaEncontrado.DataInicio = Assinatura.DataInicio;
                assinaturaEncontrado.DataFim = Assinatura.DataFim;
                assinaturaEncontrado.Status = Assinatura.Status;
                assinaturaEncontrado.UsuarioId = Assinatura.UsuarioId;

                //AssinaturaEncontrado.IdPedido = Assinatura.IdPedido;
                _context.SaveChanges();
            }
        }


        public Assinatura BuscarPorId(int id)
        {
            return _context.Assinatura.FirstOrDefault(a => a.AssinaturaId == id);
        }
        //DTO
        public void Cadastrar(CadastrarAssinaturaDto assinatura)
        {
            Assinatura assinaturaEncontrado = new Assinatura
            {
                AssinaturaId = assinatura.AssinaturaId,
                DataInicio = assinatura.DataInicio,
                DataFim = assinatura.DataFim,
                Status = assinatura.Status,
                UsuarioId = assinatura.UsuarioId

            };
            //_context.Assinaturas.Add(AssinaturaCadastro);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Assinatura assinaturaEncontrado = _context.Assinatura.Find(id);
            if (assinaturaEncontrado == null)
            {
                throw new Exception();
            }
            _context.Assinatura.Remove(assinaturaEncontrado);
            _context.SaveChanges();
        }
        public List<Assinatura> ListarTodos()
        {
            return _context.Assinatura.Include(a => a.AssinaturaId).ToList();
        }
    }
}
//_context.Assinatura.Include

