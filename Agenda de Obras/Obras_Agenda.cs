namespace Agenda_de_Obras
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Obras_Agenda
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Regional { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string cod_obra { get; set; }

        [StringLength(50)]
        public string Desc_obra { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Dt_Modificação { get; set; }
    }
}
