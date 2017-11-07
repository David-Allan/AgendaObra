namespace Agenda_de_Obras
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Data_Disponiveis
    {
        [Key]
        [Column(Order = 0)]
        public string Obra { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime Data { get; set; }

        [Key]
        [Column(Order = 2)]
        public TimeSpan Hora { get; set; }

        [StringLength(3)]
        public string VISITA { get; set; }

        [StringLength(3)]
        public string VISTORIA { get; set; }

        [StringLength(3)]
        public string REVISTORIA { get; set; }

        [Column("VISTORIA DE ENTREGA")]
        [StringLength(3)]
        public string VISTORIA_DE_ENTREGA { get; set; }

        [Column("REVISTORIA DE ENTREGA")]
        [StringLength(3)]
        public string REVISTORIA_DE_ENTREGA { get; set; }

        [Column("ANALISE DE ASTEC")]
        [StringLength(3)]
        public string ANALISE_DE_ASTEC { get; set; }

        [Column("EXECUÇÃO DE ASTEC")]
        [StringLength(3)]
        public string EXECUÇÃO_DE_ASTEC { get; set; }

        [StringLength(3)]
        public string ENTREGA { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Responsavel_Execução { get; set; }
    }
}
