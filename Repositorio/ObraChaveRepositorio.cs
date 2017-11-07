using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ObraChaveRepositorio : RepositorioBase<ObraChave>
    {
        public List<string> ListarRegional(string chave, string regional, string obra)
        {
            var query = Db.ObrasChave.AsQueryable();

            if (!String.IsNullOrEmpty(chave))
                query = query.Where(q => q.Chave == chave);

            if (!String.IsNullOrEmpty(regional))
                query = query.Where(q => q.Regional == regional);

            if (!String.IsNullOrEmpty(obra))
                query = query.Where(q => q.Obra == obra);

            var list = query.Select(o => o.Regional).Distinct().ToList();

            return list;
        }  
    }
}
