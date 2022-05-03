using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class CategoriaDaoComEfCore : ICategoriaDao
    {
        AppDbContext _context;

        public CategoriaDaoComEfCore(AppDbContext context)
        {
            _context = context;
        }


        public Categoria BuscarPorId(int id)
        {
            return _context.Categorias
                .Include(c => c.Leiloes)
                .First(c => c.Id == id);
        }

        public IEnumerable<Categoria> BuscarTodos()
        {
            return _context.Categorias
                .Include(c => c.Leiloes);
        }
        public void Alterar(Categoria obj)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(Categoria obj)
        {
            throw new System.NotImplementedException();
        }

        public void Incluir(Categoria obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
