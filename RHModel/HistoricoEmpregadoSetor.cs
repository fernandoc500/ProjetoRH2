using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHModel
{
    [Table("HistoricoEmpregadoSetor")]
    public class HistoricoEmpregadoSetor
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("SetorId")]
        public Setor Setor { get; set; }
        public int SetorId { get; set; }

        [ForeignKey("EmpregadoId")]
        public Empregado Empregado { get; set; }
        public int EmpregadoId { get; set; }


        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
