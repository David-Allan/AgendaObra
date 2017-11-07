namespace Agenda_de_Obras
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Obra_Chave
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string Regional { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string Obra { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Chave { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Responsavel_Execução { get; set; }
    }
}
