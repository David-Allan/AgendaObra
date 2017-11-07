namespace Agenda_de_Obras
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes
    {
        [StringLength(500)]
        public string Cli_Chave { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string Cli_Regional { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Cli_Empresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string Cli_Obra { get; set; }

        public string Cli_Desc_obra { get; set; }

        [StringLength(3)]
        public string Cli_Obra_Analise { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string Cli_Idendificador { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Cli_Status_UAU { get; set; }

        [StringLength(50)]
        public string Cli_Tipo_Venda { get; set; }

        [StringLength(10)]
        public string Cli_Num_venda { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Cli_Data_Venda { get; set; }

        public string Cli_Cliente { get; set; }

        [StringLength(14)]
        public string Cli_CPF { get; set; }

        [StringLength(30)]
        public string Cli_Status_Cobranca { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string Cli_Tipo_Imovel { get; set; }

        [StringLength(30)]
        public string Cli_Liberacao { get; set; }

        [StringLength(30)]
        public string Cli_Liberacao_Prot { get; set; }

        [StringLength(30)]
        public string Cli_Entrega { get; set; }

        [StringLength(30)]
        public string Cli_Entrega_Prot { get; set; }

        [StringLength(30)]
        public string Cli_Astec { get; set; }

        [StringLength(30)]
        public string Cli_Astec_Prot { get; set; }

        [StringLength(30)]
        public string Cli_Vistoria { get; set; }

        [StringLength(30)]
        public string Cli_Vistoria_Prot { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cli_Inadimplencia { get; set; }

        [StringLength(30)]
        public string Cli_Prioridade { get; set; }

        [StringLength(30)]
        public string Cli_Prev_DAT { get; set; }
    }
}
