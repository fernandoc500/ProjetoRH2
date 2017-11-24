using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RHModel;

namespace RHControl
{
    public class EmpregadoControl
    {
        RHContext ctx = new RHContext();

        public void SalvarEmpregado(Empregado e)
        {
            try
            {
                if (e.Id == 0)
                {
                    e.CargoId = e.Cargo.Id;
                    e.Cargo = null;

                    e.SuperiorId = e.Superior.Id;
                    e.Superior = null;

                    ctx.Empregados.Add(e);
                }
                else
                {
                    Empregado empregado = ctx.Empregados.Find(e.Id);
                    e.CargoId = e.Cargo.Id;
                    e.Cargo = null;

                    e.SuperiorId = e.Superior.Id;
                    e.Superior = null;

                    empregado.Cpf = e.Cpf;
                    empregado.DataContratacao = e.DataContratacao;
                    empregado.DataNascimento = e.DataNascimento;
                    empregado.Nome = e.Nome;
                }
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

        public void RemoveEmpregado(Empregado e)
        {
            if (e.Id != 0)
            {
                ctx.Empregados.Remove(e);
                ctx.SaveChanges();
            }
        }

        public IList<Empregado> ObterEmpregados()
        {
            var empregados =
                from empregado
                in ctx.Empregados.Include("Superior").Include("Cargo")
                select empregado;
            return empregados.ToList();
        }

        public IList<Empregado> ObterSubordinados(Empregado e)
        {
            var subordinados =
                from empregado
                in ctx.Empregados
                where empregado.SuperiorId == e.Id
                select empregado;

            return subordinados.ToList();
        }
    }
}
