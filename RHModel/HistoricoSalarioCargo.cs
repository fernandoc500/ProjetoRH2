using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHModel
{
    [Table("HistoricoSalarioCargo")]
    public class HistoricoSalarioCargo
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CargoId")]
        public Cargo Cargo { get; set; }
        public int CargoId { get; set; }

        public decimal Salario { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
