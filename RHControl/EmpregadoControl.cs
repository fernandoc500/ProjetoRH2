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

        public String SalvarEmpregado(Empregado e)
        {
            try
            {
                HistoricoCargoControl hcc = new HistoricoCargoControl();

                if (e.Id == 0)
                {
                    e.CargoId = e.Cargo.Id;
                    e.Cargo = null;

                    ctx.Empregados.Add(e);

                    ctx.SaveChanges();

                    hcc.SalvarHistoricoCargo(e);

                }
                else
                {
                    Empregado empregado = ctx.Empregados.Find(e.Id);

                    if (e.Cargo != null)
                    {
                        e.CargoId = e.Cargo.Id;
                        e.Cargo = null;
                    }

                    empregado.Cpf = e.Cpf;
                    empregado.DataContratacao = e.DataContratacao;
                    empregado.DataNascimento = e.DataNascimento;
                    empregado.Nome = e.Nome;
                    empregado.Salario = e.Salario;
                    empregado.CargoId = e.CargoId;

                    ctx.SaveChanges();

                    hcc.SalvarHistoricoCargo(empregado);

                }



                return "Item salvo com sucesso!";
            } catch(Exception ex)
            {
                return ex.Message;
            }
            
        }

        public void RemoveEmpregado(Empregado e)
        {
            if (e.Id != 0)
            {
                HistoricoCargoControl hcc = new HistoricoCargoControl();
                hcc.RemoverHistorico(e);

                Empregado empregado = ctx.Empregados.Find(e.Id);
                ctx.Empregados.Remove(empregado);
                ctx.SaveChanges();
            }
        }

        public IList<Empregado> ObterEmpregados()
        {
            HistoricoCargoControl hc = new HistoricoCargoControl();
            var empregados =
                from empregado
                in ctx.Empregados.Include("Cargo")
                select empregado;

            IList<Empregado> aux = empregados.ToList();

            foreach (Empregado emp in aux)
            {
                DateTime hoje = DateTime.Today;
                int idade = hoje.Year - emp.DataNascimento.Year;
                if (emp.DataNascimento > hoje.AddYears(-idade)) idade--;

                emp.Idade = idade;
                emp.InicioUltimoCargo = hc.RecuperarDataInicioUltimoCargo(emp);
                emp.DiasNoCargo = (int)(DateTime.Today - emp.InicioUltimoCargo).TotalDays;
            }

            return empregados.ToList();
        }
    }
}
