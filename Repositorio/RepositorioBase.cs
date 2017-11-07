using Agenda.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioBase<TEntity> where TEntity : class
    {
        protected AgendaDirecionalContext Db = new AgendaDirecionalContext();

        public virtual bool Salvar(TEntity obj)
        {            
            var set = Db.Set<TEntity>();
            set.Add(obj);
            int adicionados = Db.SaveChanges();
            return adicionados > 0;
        }

        public virtual bool Salvar(TEntity obj, bool metodoBool = true)
        {
            var set = Db.Set<TEntity>();
            set.AddOrUpdate(obj);
            int atualizados = Db.SaveChanges();
            return atualizados > 0;
        }

        public TEntity Retornar(int codigo)
        {
            var objeto = Db.Set<TEntity>().Find(codigo);
            return objeto;
        }

        public IEnumerable<TEntity> Listar()
        {
            return Db.Set<TEntity>();
        }

        public bool Atualizar(TEntity obj)
        {
            var set = Db.Set<TEntity>();
            set.AddOrUpdate(obj);
            int atualizados = Db.SaveChanges();
            return atualizados > 0;
        }

        public virtual void Excluir(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }


    }
}
