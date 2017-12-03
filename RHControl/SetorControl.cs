using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RHModel;

namespace RHControl
{
    class SetorControl
    {
        RHContext ctx = new RHContext();

        public void SalvarSetor(Setor s)
        {
            try
            {
                if (s.Id == 0)
                {
                    s.SetorPaiId = s.SetorPai.Id;

                    s.SetorPai = null;

                    ctx.Setores.Add(s);
                }
                else
                {
                    Setor setor = ctx.Setores.Find(s.Id);

                    setor.Nome = s.Nome;
                    setor.Atividades = s.Atividades;
                    setor.DataCriacao = s.DataCriacao;
                    setor.DataExtincao = s.DataExtincao;

                    setor.SetorPaiId = s.SetorPai.Id;

                    setor.SetorPai = null;
                }
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

        public void RemoverSetor(Setor s)
        {
            if (s.Id != 0)
            {
                ctx.Setores.Remove(s);
                ctx.SaveChanges();
            }
        }

        public IList<Setor> ObterSetores()
        {
            var setores = 
                from setor 
                in ctx.Setores.Include("SetorPai").Include("Responsavel")
                select setor;
            return setores.ToList();
        }
    }
}
