namespace Agenda_de_Obras
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Max_Agendamentos
    {
        [Key]
        [Column(Order = 0)]
        public string Chave { get; set; }

        public string SERVICO { get; set; }

        public int? QTD { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Responsavel_Execução { get; set; }
    }
}
