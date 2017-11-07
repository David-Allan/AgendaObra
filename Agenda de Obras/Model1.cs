namespace Agenda_de_Obras
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Agendamento> Agendamento { get; set; }
        public virtual DbSet<Agendamento_Cancelado> Agendamento_Cancelado { get; set; }
        public virtual DbSet<Agendamento_TEMP> Agendamento_TEMP { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Data_Canceladas> Data_Canceladas { get; set; }
        public virtual DbSet<Data_Disponiveis> Data_Disponiveis { get; set; }
        public virtual DbSet<Data_Disponiveis_temp> Data_Disponiveis_temp { get; set; }
        public virtual DbSet<Data_INSERIDAS> Data_INSERIDAS { get; set; }
        public virtual DbSet<Max_Agendamentos> Max_Agendamentos { get; set; }
        public virtual DbSet<Obra_Chave> Obra_Chave { get; set; }
        public virtual DbSet<Obras_Agenda> Obras_Agenda { get; set; }
        public virtual DbSet<Prev_DAT> Prev_DAT { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Agen_Obra)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Agen_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Agen_CPF)
                .IsFixedLength();

            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Agen_Idendificador)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Agen_Açao)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Agen_Prioridade)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Agen_Responsavel)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Agen_Protocolo)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Agen_Link)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Agen_Liberacao)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Agen_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Agen_Astec)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Agen_Vistoria)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Agen_Resp_Execução)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_Cancelado>()
                .Property(e => e.Agen_Obra)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_Cancelado>()
                .Property(e => e.Agen_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_Cancelado>()
                .Property(e => e.Agen_CPF)
                .IsFixedLength();

            modelBuilder.Entity<Agendamento_Cancelado>()
                .Property(e => e.Agen_Idendificador)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_Cancelado>()
                .Property(e => e.Agen_Açao)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_Cancelado>()
                .Property(e => e.Agen_Prioridade)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_Cancelado>()
                .Property(e => e.Agen_Responsavel)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_Cancelado>()
                .Property(e => e.Agen_Protocolo)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_Cancelado>()
                .Property(e => e.Agen_Link)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_Cancelado>()
                .Property(e => e.Agen_Liberacao)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_Cancelado>()
                .Property(e => e.Agen_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_Cancelado>()
                .Property(e => e.Agen_Astec)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_Cancelado>()
                .Property(e => e.Agen_Vistoria)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_TEMP>()
                .Property(e => e.Agen_Obra)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_TEMP>()
                .Property(e => e.Agen_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_TEMP>()
                .Property(e => e.Agen_CPF)
                .IsFixedLength();

            modelBuilder.Entity<Agendamento_TEMP>()
                .Property(e => e.Agen_Idendificador)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_TEMP>()
                .Property(e => e.Agen_Açao)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_TEMP>()
                .Property(e => e.Agen_Prioridade)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_TEMP>()
                .Property(e => e.Agen_Responsavel)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_TEMP>()
                .Property(e => e.Agen_Protocolo)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_TEMP>()
                .Property(e => e.Agen_Link)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_TEMP>()
                .Property(e => e.Agen_Liberacao)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_TEMP>()
                .Property(e => e.Agen_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_TEMP>()
                .Property(e => e.Agen_Astec)
                .IsUnicode(false);

            modelBuilder.Entity<Agendamento_TEMP>()
                .Property(e => e.Agen_Vistoria)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Chave)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Regional)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Obra)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Desc_obra)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Obra_Analise)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Idendificador)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Status_UAU)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Tipo_Venda)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Num_venda)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_CPF)
                .IsFixedLength();

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Status_Cobranca)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Tipo_Imovel)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Liberacao)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Liberacao_Prot)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Entrega_Prot)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Astec)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Astec_Prot)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Vistoria)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Vistoria_Prot)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Inadimplencia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Prioridade)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cli_Prev_DAT)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Canceladas>()
                .Property(e => e.Obra)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Canceladas>()
                .Property(e => e.VISITA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Canceladas>()
                .Property(e => e.VISTORIA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Canceladas>()
                .Property(e => e.REVISTORIA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Canceladas>()
                .Property(e => e.VISTORIA_DE_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Canceladas>()
                .Property(e => e.REVISTORIA_DE_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Canceladas>()
                .Property(e => e.ANALISE_DE_ASTEC)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Canceladas>()
                .Property(e => e.EXECUÇÃO_DE_ASTEC)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Canceladas>()
                .Property(e => e.ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Canceladas>()
                .Property(e => e.Responsavel_Execução)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Canceladas>()
                .Property(e => e.QUEM_CANCELOU)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis>()
                .Property(e => e.Obra)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis>()
                .Property(e => e.VISITA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis>()
                .Property(e => e.VISTORIA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis>()
                .Property(e => e.REVISTORIA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis>()
                .Property(e => e.VISTORIA_DE_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis>()
                .Property(e => e.REVISTORIA_DE_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis>()
                .Property(e => e.ANALISE_DE_ASTEC)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis>()
                .Property(e => e.EXECUÇÃO_DE_ASTEC)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis>()
                .Property(e => e.ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis>()
                .Property(e => e.Responsavel_Execução)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis_temp>()
                .Property(e => e.Obra)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis_temp>()
                .Property(e => e.VISITA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis_temp>()
                .Property(e => e.VISTORIA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis_temp>()
                .Property(e => e.REVISTORIA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis_temp>()
                .Property(e => e.VISTORIA_DE_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis_temp>()
                .Property(e => e.REVISTORIA_DE_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis_temp>()
                .Property(e => e.ANALISE_DE_ASTEC)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis_temp>()
                .Property(e => e.EXECUÇÃO_DE_ASTEC)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Disponiveis_temp>()
                .Property(e => e.ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_INSERIDAS>()
                .Property(e => e.Obra)
                .IsUnicode(false);

            modelBuilder.Entity<Data_INSERIDAS>()
                .Property(e => e.VISITA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_INSERIDAS>()
                .Property(e => e.VISTORIA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_INSERIDAS>()
                .Property(e => e.REVISTORIA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_INSERIDAS>()
                .Property(e => e.VISTORIA_DE_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_INSERIDAS>()
                .Property(e => e.REVISTORIA_DE_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_INSERIDAS>()
                .Property(e => e.ANALISE_DE_ASTEC)
                .IsUnicode(false);

            modelBuilder.Entity<Data_INSERIDAS>()
                .Property(e => e.EXECUÇÃO_DE_ASTEC)
                .IsUnicode(false);

            modelBuilder.Entity<Data_INSERIDAS>()
                .Property(e => e.ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<Data_INSERIDAS>()
                .Property(e => e.Responsavel_Execução)
                .IsUnicode(false);

            modelBuilder.Entity<Data_INSERIDAS>()
                .Property(e => e.QUEM_INSERIU)
                .IsUnicode(false);

            modelBuilder.Entity<Max_Agendamentos>()
                .Property(e => e.Chave)
                .IsUnicode(false);

            modelBuilder.Entity<Max_Agendamentos>()
                .Property(e => e.SERVICO)
                .IsUnicode(false);

            modelBuilder.Entity<Max_Agendamentos>()
                .Property(e => e.Responsavel_Execução)
                .IsUnicode(false);

            modelBuilder.Entity<Obra_Chave>()
                .Property(e => e.Regional)
                .IsUnicode(false);

            modelBuilder.Entity<Obra_Chave>()
                .Property(e => e.Obra)
                .IsUnicode(false);

            modelBuilder.Entity<Obra_Chave>()
                .Property(e => e.Chave)
                .IsUnicode(false);

            modelBuilder.Entity<Obra_Chave>()
                .Property(e => e.Responsavel_Execução)
                .IsUnicode(false);

            modelBuilder.Entity<Obras_Agenda>()
                .Property(e => e.Regional)
                .IsUnicode(false);

            modelBuilder.Entity<Obras_Agenda>()
                .Property(e => e.cod_obra)
                .IsUnicode(false);

            modelBuilder.Entity<Obras_Agenda>()
                .Property(e => e.Desc_obra)
                .IsUnicode(false);

            modelBuilder.Entity<Prev_DAT>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Prev_DAT>()
                .Property(e => e.Regional)
                .IsUnicode(false);

            modelBuilder.Entity<Prev_DAT>()
                .Property(e => e.Obra)
                .IsUnicode(false);

            modelBuilder.Entity<Prev_DAT>()
                .Property(e => e.Unidade)
                .IsUnicode(false);

            modelBuilder.Entity<Prev_DAT>()
                .Property(e => e.Priordade)
                .IsUnicode(false);

            modelBuilder.Entity<Prev_DAT>()
                .Property(e => e.DataPrevista)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.De_Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Nome_Usuario)
                .IsUnicode(false);
        }
    }
}
