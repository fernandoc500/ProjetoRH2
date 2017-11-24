using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHControl
{
    public class HistoricoSalarioEmpregadoControl
    {
        RHContext ctx = new RHContext();

        public void SalvarCargo(Cargo c)
        {
            try
            {
                if (c.Id == 0)
                {
                    c.CargoPaiId = c.CargoPai.Id;
                    c.CargoPai = null;
                    ctx.Cargos.Add(c);
                }
                else
                {
                    Cargo cargo = ctx.Cargos.Find(c.Id);
                    cargo.Nome = c.Nome;
                    cargo.SalarioBase = c.SalarioBase;
                    cargo.CargoPaiId = c.CargoPai.Id;
                    cargo.CargoPai = null;
                }
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

        public void RemoveCargo(Cargo c)
        {
            if (c.Id != 0)
            {
                ctx.Cargos.Remove(c);
                ctx.SaveChanges();
            }
        }

        public IList<Cargo> ObterCargos()
        {
            /// Eager loading.
            /// O include força que na busca dos carros as propriedades dono também serão preenchidas.
            /// Sem o include as propriedades que são outras classes estarão nulas.
            var cargos = from cargo in ctx.Cargos.Include("CargoPai") select cargo;
            return cargos.ToList();
        }
    }
}
