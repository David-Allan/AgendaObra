namespace Agenda_de_Obras
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string De_Usuario { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Nome_Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Dtcad_Usuario { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Acesso { get; set; }
    }
}
