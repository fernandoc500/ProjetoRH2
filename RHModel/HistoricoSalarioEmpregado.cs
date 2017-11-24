using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHModel
{
    [Table("HistoricoSalarioEmpregado")]
    public class HistoricoSalarioEmpregado
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("EmpregadoId")]
        public Empregado Empregado { get; set; }
        public int EmpregadoId { get; set; }

        public decimal Salario { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
