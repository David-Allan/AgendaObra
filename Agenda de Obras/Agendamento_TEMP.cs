namespace Agenda_de_Obras
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Agendamento_TEMP
    {
        [Key]
        [Column(Order = 0)]
        public string Agen_Obra { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime Agen_Data { get; set; }

        [Key]
        [Column(Order = 2)]
        public TimeSpan Agen_Hora { get; set; }

        public string Agen_Cliente { get; set; }

        [StringLength(14)]
        public string Agen_CPF { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string Agen_Idendificador { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Agen_Açao { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string Agen_Prioridade { get; set; }

        [Key]
        [Column(Order = 6)]
        public string Agen_Responsavel { get; set; }

        [StringLength(13)]
        public string Agen_Protocolo { get; set; }

        public string Agen_Link { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(30)]
        public string Agen_Liberacao { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(30)]
        public string Agen_Entrega { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(30)]
        public string Agen_Astec { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(30)]
        public string Agen_Vistoria { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime Agen_Dt_e_Hora_Agendamento { get; set; }
    }
}
