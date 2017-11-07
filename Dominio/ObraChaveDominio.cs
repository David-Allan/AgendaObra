using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ObraChaveDominio
    {
        ObraChaveRepositorio repositorio = new ObraChaveRepositorio();

        public List<string> ListarRegional(string chave, string regional, string obra)
        {
            return repositorio.ListarRegional(chave, regional, obra);
        }

    }
}
