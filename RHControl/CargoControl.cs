﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using RHModel;

namespace RHControl
{
    public class CargoControl
    {
        RHContext ctx = new RHContext();

        public void SalvarCargo(Cargo c)
        {
            if (c.Id == 0)
            {
                if (c.CargoPai != null)
                {
                    c.CargoPaiId = c.CargoPai.Id;
                    c.CargoPai = null;
                }
                ctx.Cargos.Add(c);
            }
            else
            {
                Cargo cargo = ctx.Cargos.Find(c.Id);
                cargo.Nome = c.Nome;
                cargo.SalarioBase = c.SalarioBase;

                if (cargo.CargoPai != null)
                {
                    cargo.CargoPaiId = c.CargoPai.Id;
                    cargo.CargoPai = null;
                }
                
            }
            ctx.SaveChanges();
        }

        public void RemoveCargo(Cargo c)
        {
            if (c.Id != 0)
            {
                Cargo cargo = ctx.Cargos.Find(c.Id);
                ctx.Cargos.Remove(cargo);
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

        public IList<Empregado> ObterEmpregadosPorCargo(int cargoId)
        {
            /// Eager loading.
            /// O include força que na busca dos carros as propriedades dono também serão preenchidas.
            /// Sem o include as propriedades que são outras classes estarão nulas.
            var empregados = 
                from emp 
                in ctx.Empregados
                where emp.CargoId == cargoId
                select emp;
            return empregados.ToList();
        }
    }
}
