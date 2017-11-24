﻿using System;
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
            try
            {
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
                } 

                HistoricoCargo hc = new HistoricoCargo();
                hc.DataInicio = DateTime.Now;
                hc.EmpregadoId = e.Id;
                hc.CargoId = e.CargoId;
                ctx.HistoricoCargo.Add(hc);

                ctx.SaveChanges();
            }
            catch (Exception ex)
            {

            }
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
    }
}