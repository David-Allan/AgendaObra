namespace Agenda_de_Obras
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Prev_DAT
    {
        [Key]
        [Column(Order = 0)]
        public DateTime Dataalteração { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string Regional { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string Obra { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Unidade { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Priordade { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string DataPrevista { get; set; }
    }
}
