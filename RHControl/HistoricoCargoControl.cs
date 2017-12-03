using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RHModel;

namespace RHControl
{
    public class HistoricoCargoControl
    {
        RHContext ctx = new RHContext();

        public void SalvarHistoricoCargo(Empregado e)
        {
            Boolean primeiroCargo = false;
            var historicoAnterior =
                from historico
                in ctx.HistoricoCargo
                where (historico.EmpregadoId == e.Id && historico.DataFim == null)
                select historico;

            if (historicoAnterior.Any())
            {
                HistoricoCargo hca = historicoAnterior.First();
                if (hca.CargoId != e.CargoId)
                {
                    hca.DataFim = DateTime.Now;
                }
            } else
            {
                primeiroCargo = true;
            }

            HistoricoCargo hc = new HistoricoCargo();
            if (primeiroCargo)
            {
                hc.DataInicio = e.DataContratacao;
            }
            else
            {
                hc.DataInicio = DateTime.Today;
            }
            hc.DataFim = null;
            hc.EmpregadoId = e.Id;
            hc.CargoId = e.CargoId;
            ctx.HistoricoCargo.Add(hc);

            ctx.SaveChanges();
        }

        public IList<HistoricoCargo> ObterHistoricoCargos(Empregado e)
        {
            var historicos =
                from historico
                in ctx.HistoricoCargo.Include("Empregado").Include("Cargo")
                where historico.EmpregadoId == e.Id
                select historico;
            return historicos.ToList();
        }

        public DateTime RecuperarDataInicioUltimoCargo(Empregado e)
        {
            var datas =
                from data
                in ctx.HistoricoCargo
                where (data.EmpregadoId == e.Id && data.DataFim.Equals(null))
                select data;

            HistoricoCargo hc = datas.First();
            return hc.DataInicio;
        }
    }
}
