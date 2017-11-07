using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Data.EntidadeConfig
{
    public class ObraChaveConfig : EntityTypeConfiguration<ObraChave>
    {
        public ObraChaveConfig()
        {
            ToTable("Obra_Chave");

            Property(c => c.Regional)
              .HasColumnName("Regional")
              .IsRequired()
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(c => c.Obra)
             .HasColumnName("Obra")
             .IsRequired()
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(c => c.Chave)
           .HasColumnName("Chave")
           .IsRequired()
           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            HasKey(c => c.Chave);

            Property(c => c.Responsavel)
         .HasColumnName("Responsavel_Execução")
         .IsRequired()
         .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
